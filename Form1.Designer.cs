namespace WindowsFileMonitor
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dir = new System.Windows.Forms.TextBox();
            this.btn_selectDir = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lvw_log = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_clear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_openDir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_copyPath = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_runTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_crateCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_delCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_updateCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_reNameCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_waringCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_jumpCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_filterExt = new System.Windows.Forms.TextBox();
            this.chk_list = new System.Windows.Forms.CheckedListBox();
            this.lbl_filterExt = new System.Windows.Forms.Label();
            this.lbl_selectExt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_selectExt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_rename = new System.Windows.Forms.CheckBox();
            this.chk_webshell = new System.Windows.Forms.CheckBox();
            this.chk_frontLog = new System.Windows.Forms.CheckBox();
            this.chk_backLog = new System.Windows.Forms.CheckBox();
            this.chk_update = new System.Windows.Forms.CheckBox();
            this.chk_del = new System.Windows.Forms.CheckBox();
            this.chk_add = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "监控目录：";
            // 
            // txt_dir
            // 
            this.txt_dir.Location = new System.Drawing.Point(77, 16);
            this.txt_dir.Name = "txt_dir";
            this.txt_dir.Size = new System.Drawing.Size(231, 21);
            this.txt_dir.TabIndex = 1;
            // 
            // btn_selectDir
            // 
            this.btn_selectDir.Location = new System.Drawing.Point(304, 15);
            this.btn_selectDir.Name = "btn_selectDir";
            this.btn_selectDir.Size = new System.Drawing.Size(75, 23);
            this.btn_selectDir.TabIndex = 2;
            this.btn_selectDir.Text = "选择目录";
            this.btn_selectDir.UseVisualStyleBackColor = true;
            this.btn_selectDir.Click += new System.EventHandler(this.btn_selectDir_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(671, 16);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "开始监控";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(671, 61);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "停止监控";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // lvw_log
            // 
            this.lvw_log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_path,
            this.col_type,
            this.col_time});
            this.lvw_log.ContextMenuStrip = this.contextMenuStrip1;
            this.lvw_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvw_log.FullRowSelect = true;
            this.lvw_log.Location = new System.Drawing.Point(3, 17);
            this.lvw_log.Name = "lvw_log";
            this.lvw_log.Size = new System.Drawing.Size(769, 360);
            this.lvw_log.TabIndex = 3;
            this.lvw_log.UseCompatibleStateImageBehavior = false;
            this.lvw_log.View = System.Windows.Forms.View.Details;
            // 
            // col_id
            // 
            this.col_id.Text = "序号";
            this.col_id.Width = 58;
            // 
            // col_path
            // 
            this.col_path.Text = "文件路径";
            this.col_path.Width = 471;
            // 
            // col_type
            // 
            this.col_type.Text = "变化类型";
            this.col_type.Width = 110;
            // 
            // col_time
            // 
            this.col_time.Text = "时间";
            this.col_time.Width = 110;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_clear,
            this.tsmi_openDir,
            this.tsmi_copyPath});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // tsmi_clear
            // 
            this.tsmi_clear.Name = "tsmi_clear";
            this.tsmi_clear.Size = new System.Drawing.Size(152, 22);
            this.tsmi_clear.Text = "清 空";
            this.tsmi_clear.Click += new System.EventHandler(this.tsmi_clear_Click);
            // 
            // tsmi_openDir
            // 
            this.tsmi_openDir.Name = "tsmi_openDir";
            this.tsmi_openDir.Size = new System.Drawing.Size(152, 22);
            this.tsmi_openDir.Text = "打开文件夹";
            this.tsmi_openDir.Click += new System.EventHandler(this.tsmi_openDir_Click);
            // 
            // tsmi_copyPath
            // 
            this.tsmi_copyPath.Name = "tsmi_copyPath";
            this.tsmi_copyPath.Size = new System.Drawing.Size(152, 22);
            this.tsmi_copyPath.Text = "复制文件路径";
            this.tsmi_copyPath.Click += new System.EventHandler(this.tsmi_copyPath_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lvw_log);
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 380);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "日志";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_runTime,
            this.toolStripStatusLabel3,
            this.lbl_crateCount,
            this.toolStripStatusLabel5,
            this.lbl_delCount,
            this.toolStripStatusLabel6,
            this.lbl_updateCount,
            this.toolStripStatusLabel7,
            this.lbl_reNameCount,
            this.toolStripStatusLabel2,
            this.lbl_waringCount,
            this.toolStripStatusLabel4,
            this.lbl_jumpCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 549);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(799, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "运行时间：";
            // 
            // lbl_runTime
            // 
            this.lbl_runTime.Name = "lbl_runTime";
            this.lbl_runTime.Size = new System.Drawing.Size(15, 17);
            this.lbl_runTime.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel3.Text = "新建：";
            // 
            // lbl_crateCount
            // 
            this.lbl_crateCount.Name = "lbl_crateCount";
            this.lbl_crateCount.Size = new System.Drawing.Size(15, 17);
            this.lbl_crateCount.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel5.Text = "删除：";
            // 
            // lbl_delCount
            // 
            this.lbl_delCount.Name = "lbl_delCount";
            this.lbl_delCount.Size = new System.Drawing.Size(15, 17);
            this.lbl_delCount.Text = "0";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel6.Text = "修改：";
            // 
            // lbl_updateCount
            // 
            this.lbl_updateCount.Name = "lbl_updateCount";
            this.lbl_updateCount.Size = new System.Drawing.Size(15, 17);
            this.lbl_updateCount.Text = "0";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel7.Text = "重命名：";
            // 
            // lbl_reNameCount
            // 
            this.lbl_reNameCount.Name = "lbl_reNameCount";
            this.lbl_reNameCount.Size = new System.Drawing.Size(15, 17);
            this.lbl_reNameCount.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel2.Text = "警告：";
            // 
            // lbl_waringCount
            // 
            this.lbl_waringCount.Name = "lbl_waringCount";
            this.lbl_waringCount.Size = new System.Drawing.Size(15, 17);
            this.lbl_waringCount.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel4.Text = "忽略：";
            // 
            // lbl_jumpCount
            // 
            this.lbl_jumpCount.Name = "lbl_jumpCount";
            this.lbl_jumpCount.Size = new System.Drawing.Size(15, 17);
            this.lbl_jumpCount.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txt_filterExt);
            this.groupBox3.Controls.Add(this.chk_list);
            this.groupBox3.Controls.Add(this.lbl_filterExt);
            this.groupBox3.Controls.Add(this.lbl_selectExt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_selectExt);
            this.groupBox3.Controls.Add(this.txt_dir);
            this.groupBox3.Controls.Add(this.btn_selectDir);
            this.groupBox3.Controls.Add(this.btn_start);
            this.groupBox3.Controls.Add(this.btn_stop);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 94);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // txt_filterExt
            // 
            this.txt_filterExt.Location = new System.Drawing.Point(305, 63);
            this.txt_filterExt.Name = "txt_filterExt";
            this.txt_filterExt.Size = new System.Drawing.Size(145, 21);
            this.txt_filterExt.TabIndex = 4;
            // 
            // chk_list
            // 
            this.chk_list.FormattingEnabled = true;
            this.chk_list.Location = new System.Drawing.Point(467, 16);
            this.chk_list.Name = "chk_list";
            this.chk_list.Size = new System.Drawing.Size(175, 68);
            this.chk_list.TabIndex = 3;
            // 
            // lbl_filterExt
            // 
            this.lbl_filterExt.AutoSize = true;
            this.lbl_filterExt.Location = new System.Drawing.Point(234, 67);
            this.lbl_filterExt.Name = "lbl_filterExt";
            this.lbl_filterExt.Size = new System.Drawing.Size(65, 12);
            this.lbl_filterExt.TabIndex = 0;
            this.lbl_filterExt.Text = "跳过后缀：";
            // 
            // lbl_selectExt
            // 
            this.lbl_selectExt.AutoSize = true;
            this.lbl_selectExt.Location = new System.Drawing.Point(6, 68);
            this.lbl_selectExt.Name = "lbl_selectExt";
            this.lbl_selectExt.Size = new System.Drawing.Size(65, 12);
            this.lbl_selectExt.TabIndex = 0;
            this.lbl_selectExt.Text = "监控后缀：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "监控磁盘：";
            // 
            // txt_selectExt
            // 
            this.txt_selectExt.Location = new System.Drawing.Point(77, 63);
            this.txt_selectExt.Name = "txt_selectExt";
            this.txt_selectExt.Size = new System.Drawing.Size(145, 21);
            this.txt_selectExt.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chk_rename);
            this.groupBox1.Controls.Add(this.chk_webshell);
            this.groupBox1.Controls.Add(this.chk_frontLog);
            this.groupBox1.Controls.Add(this.chk_backLog);
            this.groupBox1.Controls.Add(this.chk_update);
            this.groupBox1.Controls.Add(this.chk_del);
            this.groupBox1.Controls.Add(this.chk_add);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 48);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "监控动作";
            // 
            // chk_rename
            // 
            this.chk_rename.AutoSize = true;
            this.chk_rename.Checked = true;
            this.chk_rename.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_rename.Location = new System.Drawing.Point(304, 20);
            this.chk_rename.Name = "chk_rename";
            this.chk_rename.Size = new System.Drawing.Size(60, 16);
            this.chk_rename.TabIndex = 3;
            this.chk_rename.Text = "重命名";
            this.chk_rename.UseVisualStyleBackColor = true;
            // 
            // chk_webshell
            // 
            this.chk_webshell.AutoSize = true;
            this.chk_webshell.Checked = true;
            this.chk_webshell.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_webshell.Location = new System.Drawing.Point(467, 20);
            this.chk_webshell.Name = "chk_webshell";
            this.chk_webshell.Size = new System.Drawing.Size(72, 16);
            this.chk_webshell.TabIndex = 2;
            this.chk_webshell.Text = "监控网马";
            this.chk_webshell.UseVisualStyleBackColor = true;
            // 
            // chk_frontLog
            // 
            this.chk_frontLog.AutoSize = true;
            this.chk_frontLog.Checked = true;
            this.chk_frontLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_frontLog.Location = new System.Drawing.Point(570, 20);
            this.chk_frontLog.Name = "chk_frontLog";
            this.chk_frontLog.Size = new System.Drawing.Size(72, 16);
            this.chk_frontLog.TabIndex = 2;
            this.chk_frontLog.Text = "前端日志";
            this.chk_frontLog.UseVisualStyleBackColor = true;
            // 
            // chk_backLog
            // 
            this.chk_backLog.AutoSize = true;
            this.chk_backLog.Checked = true;
            this.chk_backLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_backLog.Location = new System.Drawing.Point(671, 20);
            this.chk_backLog.Name = "chk_backLog";
            this.chk_backLog.Size = new System.Drawing.Size(72, 16);
            this.chk_backLog.TabIndex = 1;
            this.chk_backLog.Text = "后端日志";
            this.chk_backLog.UseVisualStyleBackColor = true;
            // 
            // chk_update
            // 
            this.chk_update.AutoSize = true;
            this.chk_update.Checked = true;
            this.chk_update.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_update.Location = new System.Drawing.Point(208, 20);
            this.chk_update.Name = "chk_update";
            this.chk_update.Size = new System.Drawing.Size(48, 16);
            this.chk_update.TabIndex = 0;
            this.chk_update.Text = "修改";
            this.chk_update.UseVisualStyleBackColor = true;
            // 
            // chk_del
            // 
            this.chk_del.AutoSize = true;
            this.chk_del.Checked = true;
            this.chk_del.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_del.Location = new System.Drawing.Point(118, 20);
            this.chk_del.Name = "chk_del";
            this.chk_del.Size = new System.Drawing.Size(48, 16);
            this.chk_del.TabIndex = 0;
            this.chk_del.Text = "删除";
            this.chk_del.UseVisualStyleBackColor = true;
            // 
            // chk_add
            // 
            this.chk_add.AutoSize = true;
            this.chk_add.Checked = true;
            this.chk_add.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_add.Location = new System.Drawing.Point(35, 20);
            this.chk_add.Name = "chk_add";
            this.chk_add.Size = new System.Drawing.Size(48, 16);
            this.chk_add.TabIndex = 0;
            this.chk_add.Text = "新建";
            this.chk_add.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 571);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "超级文件监控工具 V1.0 by shack2 www.shack2.org";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dir;
        private System.Windows.Forms.Button btn_selectDir;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.ListView lvw_log;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_path;
        private System.Windows.Forms.ColumnHeader col_type;
        private System.Windows.Forms.ColumnHeader col_time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_update;
        private System.Windows.Forms.CheckBox chk_del;
        private System.Windows.Forms.CheckBox chk_add;
        private System.Windows.Forms.CheckedListBox chk_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_selectExt;
        private System.Windows.Forms.TextBox txt_selectExt;
        private System.Windows.Forms.Label lbl_filterExt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_clear;
        private System.Windows.Forms.ToolStripMenuItem tsmi_openDir;
        private System.Windows.Forms.ToolStripMenuItem tsmi_copyPath;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_runTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lbl_crateCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel lbl_delCount;
        private System.Windows.Forms.ToolStripStatusLabel lbl_updateCount;
        private System.Windows.Forms.ToolStripStatusLabel lbl_reNameCount;
        private System.Windows.Forms.CheckBox chk_backLog;
        private System.Windows.Forms.CheckBox chk_frontLog;
        private System.Windows.Forms.CheckBox chk_webshell;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbl_waringCount;
        private System.Windows.Forms.TextBox txt_filterExt;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lbl_jumpCount;
        private System.Windows.Forms.CheckBox chk_rename;
    }
}

