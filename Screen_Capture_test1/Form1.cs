using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace Screen_Capture_test1
{
    public partial class Form1 : Form
    {
        /*全局变量*/
        //默认保存路径,即是exe工作路径
        string defaultDirectory = Directory.GetCurrentDirectory() + @"ScreenCaptureSaveImages\";
        Bitmap red = Properties.Resources.red;//不工作时窗口指示灯为红
        Bitmap green = Properties.Resources.green;//工作时窗口指示灯为绿
        Icon cat_red = Properties.Resources.cat_red;//不工作时后台显示为红
        Icon cat_green = Properties.Resources.cat_green;//工作时后台显示为绿
        long count = 0;//本次截屏数
        //不同comboBox的时间间隔，单位：秒
        //截屏时间间隔，分别是0，5s,5m,30m,1h
        int[] Cycles_Time = { 0, 5, 5 * 60, 30 * 60, 3600 };

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            comboBox1.SelectedIndex = 1;
            pictureBox1.Image = red;//初始化
            count = 0;
            if (!Directory.Exists(defaultDirectory))
            {
                Directory.CreateDirectory(defaultDirectory);
            }
        }
        //定时器
        System.Timers.Timer myTimer;
        void Form1_Load(object sender, EventArgs e)
        {
            myTimer = new System.Timers.Timer(Cycles_Time[comboBox1.SelectedIndex] * 1000);//定时周期2秒
            myTimer.Elapsed += myTimer_Elapsed;//到2秒了做的事件
            myTimer.AutoReset = true;//是否不断重复定时器操作
        }
        void myTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Bitmap bit = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            DateTime TimeNow = DateTime.Now;
            string Time = TimeNow.ToString("yyyy-MM-dd HH-mm-ss");
            Graphics g = Graphics.FromImage(bit);
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), bit.Size);
            bit.Save(defaultDirectory + Time + ".bmp");
            count++;
            textBox1.Text = count.ToString();//显示次数
            bit.Dispose();
            g.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            if (Cycles_Time[comboBox1.SelectedIndex] == 0)
            {
                //仅截一次屏
                myTimer.Enabled = false;//关闭计时器
                System.Threading.Thread.Sleep(200);
                Bitmap bit = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                DateTime TimeNow = DateTime.Now;
                string Time = TimeNow.ToString("yyyy-MM-dd HH-mm-ss");
                Graphics g = Graphics.FromImage(bit);
                g.CopyFromScreen(new Point(0, 0), new Point(0, 0), bit.Size);
                bit.Save(defaultDirectory + Time + ".bmp");
                bit.Dispose();
                g.Dispose();
                this.Visible = true;
            }
            else
            {
                //定时截屏
                myTimer.Enabled = true;
                pictureBox1.Image = green;//指示灯绿色，正在截屏
                notifyIcon1.Icon = cat_green;//后台图标变绿

            }
            Control.CheckForIllegalCrossThreadCalls = false;
            // this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = red;//指示灯红色，停止截屏
            notifyIcon1.Icon = cat_red;//后台图标变红
            myTimer.Enabled = false;//关闭定时器

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
        }

        private void 查看截图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", defaultDirectory);
        }

        private void 清空所有截图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("确定要删除所有截图吗？", "确定", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); 
            if (result == DialogResult.OK)
            {
                DeleteFolder(defaultDirectory);
                System.Threading.Thread.Sleep(800);
                MessageBox.Show("已清空所有截图！");
            }
            else
            {
                ;
            }

        }

        /// 清空指定的文件夹，但不删除文件夹
        /// </summary>
        /// <param name="dir"></param>
        public static void DeleteFolder(string dir)
        {
            foreach (string d in System.IO.Directory.GetFileSystemEntries(dir))
            {
                if (File.Exists(d))
                {
                    FileInfo fi = new FileInfo(d);
                    if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                        fi.Attributes = FileAttributes.Normal;
                    File.Delete(d);//直接删除其中的文件  
                }
                else
                {
                    DirectoryInfo d1 = new DirectoryInfo(d);
                    if (d1.GetFiles().Length != 0)
                    {
                        DeleteFolder(d1.FullName);////递归删除子文件夹
                    }
                    Directory.Delete(d);
                }
            }
        }
        /// <summary>
        /// 删除文件夹及其内容
        /// </summary>
        /// <param name="dir"></param>
        public static void DeleteFolder1(string dir)
        {
            foreach (string d in Directory.GetFileSystemEntries(dir))
            {
                if (File.Exists(d))
                {
                    FileInfo fi = new FileInfo(d);
                    if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                        fi.Attributes = FileAttributes.Normal;
                    File.Delete(d);//直接删除其中的文件  
                }
                else
                    DeleteFolder(d);////递归删除子文件夹
                Directory.Delete(d);
            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ;// MessageBox.Show
        }

        private void 显示窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void 停止截屏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = red;//指示灯红色，停止截屏
            notifyIcon1.Icon = cat_red;//后台图标变红
            myTimer.Enabled = false;//关闭定时器
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon1.Visible = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("确定退出吗？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.ExitThread();
            }
            else
            {               
                e.Cancel = true;
                this.Visible = false;
            }
        }

        private void 开始截屏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (Cycles_Time[comboBox1.SelectedIndex] == 0)//仅截一次屏
            {
                myTimer.Enabled = false;//关闭计时器
                System.Threading.Thread.Sleep(200);
                Bitmap bit = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                DateTime TimeNow = DateTime.Now;
                string Time = TimeNow.ToString("yyyy-MM-dd HH-mm-ss");
                Graphics g = Graphics.FromImage(bit);
                g.CopyFromScreen(new Point(0, 0), new Point(0, 0), bit.Size);
                bit.Save(defaultDirectory + Time + ".bmp");
                bit.Dispose();
                g.Dispose();
                this.Visible = true;
            }
            else
            {
                myTimer.Enabled = true;
                pictureBox1.Image = green;//指示灯绿色，正在截屏
                notifyIcon1.Icon = cat_green;//后台图标变绿
            }
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void 隐藏窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void 修改保存位置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                defaultDirectory = dialog.SelectedPath+@"\";
                MessageBox.Show("已选择文件夹:" + defaultDirectory, "选择文件夹提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string KJLJ = Application.ExecutablePath;
            if (!System.IO.File.Exists(KJLJ))//判断指定文件是否存在
                return;
            string newKJLJ = KJLJ.Substring(KJLJ.LastIndexOf("\\") + 1);
            RegistryKey Rkey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (Rkey == null)
                Rkey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            Rkey.SetValue(newKJLJ, KJLJ);
            MessageBox.Show("程序设置完毕,请重新启动计算机后即可生效！", "确定", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 帮助ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Designed by 115032910116zhongtao");
        }
    }
}
