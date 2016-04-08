using System.Windows.Forms;

namespace Screen_Capture_test1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始截屏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止截屏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看截图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改保存位置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空所有截图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.帮助ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始截屏";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "停止截屏";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "自动截屏软件";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示窗口ToolStripMenuItem,
            this.隐藏窗口ToolStripMenuItem,
            this.开始截屏ToolStripMenuItem,
            this.停止截屏ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 124);
            // 
            // 显示窗口ToolStripMenuItem
            // 
            this.显示窗口ToolStripMenuItem.Name = "显示窗口ToolStripMenuItem";
            this.显示窗口ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.显示窗口ToolStripMenuItem.Text = "显示窗口";
            this.显示窗口ToolStripMenuItem.Click += new System.EventHandler(this.显示窗口ToolStripMenuItem_Click);
            // 
            // 隐藏窗口ToolStripMenuItem
            // 
            this.隐藏窗口ToolStripMenuItem.Name = "隐藏窗口ToolStripMenuItem";
            this.隐藏窗口ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.隐藏窗口ToolStripMenuItem.Text = "隐藏窗口";
            this.隐藏窗口ToolStripMenuItem.Click += new System.EventHandler(this.隐藏窗口ToolStripMenuItem_Click);
            // 
            // 开始截屏ToolStripMenuItem
            // 
            this.开始截屏ToolStripMenuItem.Name = "开始截屏ToolStripMenuItem";
            this.开始截屏ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.开始截屏ToolStripMenuItem.Text = "开始截屏";
            this.开始截屏ToolStripMenuItem.Click += new System.EventHandler(this.开始截屏ToolStripMenuItem_Click);
            // 
            // 停止截屏ToolStripMenuItem
            // 
            this.停止截屏ToolStripMenuItem.Name = "停止截屏ToolStripMenuItem";
            this.停止截屏ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.停止截屏ToolStripMenuItem.Text = "停止截屏";
            this.停止截屏ToolStripMenuItem.Click += new System.EventHandler(this.停止截屏ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "仅一次",
            "5秒(仅作测试)",
            "3分钟",
            "5分钟",
            "30分钟",
            "1小时"});
            this.comboBox1.Location = new System.Drawing.Point(130, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "间隔时间：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(572, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看截图ToolStripMenuItem,
            this.修改保存位置ToolStripMenuItem,
            this.清空所有截图ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 查看截图ToolStripMenuItem
            // 
            this.查看截图ToolStripMenuItem.Name = "查看截图ToolStripMenuItem";
            this.查看截图ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.查看截图ToolStripMenuItem.Text = "查看已保存的截图";
            this.查看截图ToolStripMenuItem.Click += new System.EventHandler(this.查看截图ToolStripMenuItem_Click);
            // 
            // 修改保存位置ToolStripMenuItem
            // 
            this.修改保存位置ToolStripMenuItem.Name = "修改保存位置ToolStripMenuItem";
            this.修改保存位置ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.修改保存位置ToolStripMenuItem.Text = "修改保存位置";
            this.修改保存位置ToolStripMenuItem.Click += new System.EventHandler(this.修改保存位置ToolStripMenuItem_Click);
            // 
            // 清空所有截图ToolStripMenuItem
            // 
            this.清空所有截图ToolStripMenuItem.Name = "清空所有截图ToolStripMenuItem";
            this.清空所有截图ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.清空所有截图ToolStripMenuItem.Text = "清空所有截图";
            this.清空所有截图ToolStripMenuItem.Click += new System.EventHandler(this.清空所有截图ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.帮助ToolStripMenuItem1});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "设置";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuItem1.Text = "开机自启动";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Screen_Capture_test1.Properties.Resources.red;
            this.pictureBox1.Location = new System.Drawing.Point(43, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "本次截图数：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 25);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "0";
            // 
            // 帮助ToolStripMenuItem1
            // 
            this.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1";
            this.帮助ToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.帮助ToolStripMenuItem1.Text = "帮助";
            this.帮助ToolStripMenuItem1.Click += new System.EventHandler(this.帮助ToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 334);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自动截屏软件";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看截图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空所有截图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止截屏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 开始截屏ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem 隐藏窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改保存位置ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem 帮助ToolStripMenuItem1;
    }
}

