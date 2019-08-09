using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFileMonitor
{
    class Tools
    {
        public static void AppendLogToFile(String type,String log)
        {
            List<String> list = new List<String>();
            FileStream fs_dir = null;
            StreamWriter sw = null;
                try
                {
                    fs_dir = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "/logs/" + DateTime.Now.ToLongDateString() +"."+type+".log", FileMode.Append, FileAccess.Write);

                    sw = new StreamWriter(fs_dir);

                    sw.WriteLine(log);

                    sw.Close();

                    fs_dir.Close();

                }
                catch (Exception e)
                {
                    
                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Close();
                    }
                    if (fs_dir != null)
                    {
                        fs_dir.Close();
                    }
                }
        }

        public static List<String> readFileToList(String path)
        {

            List<String> list = new List<String>();
            FileStream fs_dir = null;
            StreamReader reader = null;
            try
            {
                fs_dir = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "/" + path, FileMode.Open, FileAccess.Read);

                reader = new StreamReader(fs_dir);

                String lineStr;

                while ((lineStr = reader.ReadLine()) != null)
                {
                    if (!lineStr.Equals(""))
                    {
                        list.Add(lineStr);
                    }
                }
            }
            catch (Exception e)
            {
                AppendLogToFile("run",e.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (fs_dir != null)
                {
                    fs_dir.Close();
                }
            }
            return list;
        }

        //读取文件
        public static String readFileToString(String path)
        {
            String str = "";
            FileStream fs_dir = null;
            StreamReader reader = null;
            try
            {
                fs_dir = new FileStream(path, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(fs_dir);
                str = reader.ReadToEnd();
            }
            catch (Exception e)
            {
                AppendLogToFile("run", e.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (fs_dir != null)
                {
                    fs_dir.Close();
                }
            }
            return str;

        }

        //文件大小
        public static long getFileSize(String path)
        {
            try
            {
                FileInfo file = new FileInfo(path);
                return file.Length;
            }
            catch (Exception e)
            {
                AppendLogToFile("run", e.Message);
            }
            return -1;
           

        }
    }
}
