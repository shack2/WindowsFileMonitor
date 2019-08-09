using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFileMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public String currentPath = AppDomain.CurrentDomain.BaseDirectory;
        public long i = 0;
        public long add = 0;
        public long del = 0;
        public long update = 0;
        public long rename = 0;
        public long waring = 0;
        public long jump = 0;
        List<FileSystemWatcher> list_monitor = new List<FileSystemWatcher>();
        private void btn_selectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择监控文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String foldPath = dialog.SelectedPath;
                this.txt_dir.Text = foldPath;
            }
        }
        private delegate void updateResult(FileSystemEventArgs e,String type);

        private void addNode(FileSystemEventArgs e, String type)
        {
            
            if (e.FullPath.IndexOf(currentPath) != -1)
            {
                return;
            }
            try{
                if (!"".Equals(this.txt_filterExt.Text)) {
                    String[] filterExts=this.txt_filterExt.Text.Split(',');
                    foreach(String ext in filterExts){
                        if(e.Name.EndsWith(ext)){
                            jump++;
                            return;
                        }
                    }
                }
            }catch(Exception se){
                Tools.AppendLogToFile("run",se.Message);
           }
            i++;
            if (this.chk_frontLog.Checked) {
                ListViewItem lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(e.FullPath);
                lvi.SubItems.Add(type);
                lvi.SubItems.Add(DateTime.Now.ToString());
                this.lvw_log.Items.Add(lvi);
            }

            if (this.chk_backLog.Checked)
            {
                String log = i.ToString() + "----" + e.FullPath + "----" + type + "----" + DateTime.Now;
                Tools.AppendLogToFile(type, log);

            }
            if (this.chk_webshell.Checked) {
                if ("创建".Equals(type) || "重命名".Equals(type))
                {
                    List<String> list_f = Tools.readFileToList("config/MonitorName.txt");
                    foreach (String ext in list_f) {
                        if (e.Name.IndexOf(ext,StringComparison.OrdinalIgnoreCase) != -1) {
                            type = "waring";
                            String log = i.ToString() + "----" + e.FullPath + "----疑似WebShell文件----" + DateTime.Now;
                            Tools.AppendLogToFile(type, log);
                            break;
                        }
                    }
                    waring++;
                
                }
                if ("修改".Equals(type)) 
                {
                  
                    long length =Tools.getFileSize(e.FullPath);
                    //大于200KB不检测
                    if (length > 200000 || length<0)
                    {
                       return;
                    }
                    List<String> list_c = Tools.readFileToList("config/shell.txt");

                    String content = Tools.readFileToString(e.FullPath);
                    foreach (String key in list_c)
                    {
                        
                        if (content.IndexOf(key, StringComparison.OrdinalIgnoreCase) != -1)
                        {
                            type = "waring";
                            String log = i.ToString() + "----" + e.FullPath + "----文件中发现监测关键字----" + DateTime.Now;
                            Tools.AppendLogToFile(type, log);
                            break;
                        }
                    }
                    waring++;
                }
           }

        }
        private void fileCreate_EventHandle(Object sender, FileSystemEventArgs e)  //文件增删改时被调用的处理方法  
        {
            add++;
            this.lvw_log.Invoke(new updateResult(addNode), new Object[] { e,"创建" }); 
        }
        private void fileDel_EventHandle(Object sender, FileSystemEventArgs e)  //文件增删改时被调用的处理方法  
        {
            del++;
            this.lvw_log.Invoke(new updateResult(addNode), new Object[] { e, "删除" });
        }
        private void fileReName_EventHandle(Object sender, FileSystemEventArgs e)  //文件增删改时被调用的处理方法  
        {
            rename++;
            this.lvw_log.Invoke(new updateResult(addNode), new Object[] { e, "重命名" });
        }
        private void fileChange_EventHandle(Object sender, FileSystemEventArgs e)  //文件增删改时被调用的处理方法  
        {
            update++;
            this.lvw_log.Invoke(new updateResult(addNode), new Object[] { e, "修改" });
        }

        private void fileSizeChange_EventHandle(Object sender, FileSystemEventArgs e)  //文件增删改时被调用的处理方法  
        {

            this.lvw_log.Invoke(new updateResult(addNode), new Object[] { e, "大小改变" });
        }

        private void fileLastUpdateTimeChange_EventHandle(Object sender, FileSystemEventArgs e)  //文件增删改时被调用的处理方法  
        {
           
            this.lvw_log.Invoke(new updateResult(addNode), new Object[] { e, "上次修改时间改变" });
        }

        private void btn_start_Click(Object sender, EventArgs e)
        {
            
            foreach (String dir in this.chk_list.CheckedItems)
            {
                createMonitor(dir);
            }
            if (!"".Equals(this.txt_dir.Text)) {
                createMonitor(this.txt_dir.Text);
            }
            this.btn_start.Enabled = false;
            this.timer1.Start();
        }

        private void Form1_Shown(Object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo info in drives)
            {
                this.chk_list.Items.Add(info.Name);
            }
        }
        
        private void createMonitor(String path) {

            FileSystemWatcher fsw = new FileSystemWatcher(path);
            fsw.IncludeSubdirectories = true;
            
            if (!"".Equals(this.txt_selectExt.Text))
            {
                fsw.Filter = this.txt_selectExt.Text;
            }
            if (this.chk_add.Checked)
            {
                fsw.Created += fileCreate_EventHandle;
            }
            if (this.chk_del.Checked) {
                fsw.Deleted += fileDel_EventHandle;
            }
            if (this.chk_update.Checked)
            {
                fsw.Changed += fileChange_EventHandle;
            }
            if (this.chk_rename.Checked)
            {
                fsw.Renamed += fileReName_EventHandle;
            } 
          
            fsw.EnableRaisingEvents = true;
            //createWatcher(NotifyFilters.Size, path, this.txt_selectExt.Text, fileSizeChange_EventHandle);
           // createWatcher(NotifyFilters.LastWrite, path, this.txt_selectExt.Text, fileLastUpdateTimeChange_EventHandle);
            //createWatcher(NotifyFilters.Attributes, path, this.txt_selectExt.Text, fileSizeChange_EventHandle);
            list_monitor.Add(fsw);
          
        
        }


        private void createWatcher(NotifyFilters type, String path, String selectExt,FileSystemEventHandler doMethord)
        {
            FileSystemWatcher fsw = new FileSystemWatcher(path);
            fsw.IncludeSubdirectories = true;
            if (!"".Equals(this.txt_selectExt.Text))
            {
                fsw.Filter = this.txt_selectExt.Text;
            }
            fsw.NotifyFilter = type;
            fsw.Changed += doMethord;
            fsw.EnableRaisingEvents = true;
            list_monitor.Add(fsw);
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            this.btn_stop.Enabled = false;
            foreach (FileSystemWatcher fsw in list_monitor) {
                fsw.EnableRaisingEvents = false;
            }
            this.btn_stop.Enabled = true;
            this.btn_start.Enabled = true;
            list_monitor.Clear();
            this.timer1.Stop();
            
        }

        private void tsmi_clear_Click(object sender, EventArgs e)
        {
            this.lvw_log.Items.Clear();
        }
        private long runTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            runTime++;
            this.lbl_runTime.Text = runTime+"/秒";
            this.lbl_crateCount.Text = add + "次";
            this.lbl_delCount.Text = del + "次";
            this.lbl_updateCount.Text = update + "次";
            this.lbl_reNameCount.Text = rename + "次";
            this.lbl_waringCount.Text = waring + "次";
            this.lbl_jumpCount.Text = jump + "次";
        }

        private void tsmi_openDir_Click(object sender, EventArgs e)
        {
            if (this.lvw_log.SelectedItems.Count > 0)
            {
                try
                {
                    FileInfo f = new FileInfo(this.lvw_log.SelectedItems[0].SubItems[1].Text);
                    System.Diagnostics.Process.Start(f.DirectoryName);
                }
                catch (Exception fe) {
                    Tools.AppendLogToFile("run", fe.Message);
                }
            }
            
        }

        private void tsmi_copyPath_Click(object sender, EventArgs e)
        {
            if (this.lvw_log.SelectedItems.Count > 0)
            {
                try
                {
                    Clipboard.SetDataObject(this.lvw_log.SelectedItems[0].SubItems[1].Text);
                    MessageBox.Show("复制成功！");
                }
                catch (Exception fe)
                {
                    Tools.AppendLogToFile("run", fe.Message);
                }
               
            }
           
        }

    }
}
