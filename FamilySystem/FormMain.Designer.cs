namespace FamilySystem
{
    partial class FormMain
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemManage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCardManage = new System.Windows.Forms.ToolStripMenuItem();
            this.系统操作日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.家政财务报表TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMoneyManage = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发送反馈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册产品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CtmHelpItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.家政财务报表TToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1597, 39);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemManage,
            this.MenuCardManage,
            this.系统操作日志ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(149, 35);
            this.文件ToolStripMenuItem.Text = "系统设置(&s)";
            // 
            // systemManage
            // 
            this.systemManage.Name = "systemManage";
            this.systemManage.Size = new System.Drawing.Size(256, 38);
            this.systemManage.Text = "系统用户管理";
            this.systemManage.Click += new System.EventHandler(this.systemManage_Click);
            // 
            // MenuCardManage
            // 
            this.MenuCardManage.Name = "MenuCardManage";
            this.MenuCardManage.Size = new System.Drawing.Size(256, 38);
            this.MenuCardManage.Text = "存储卡管理";
            this.MenuCardManage.Click += new System.EventHandler(this.MenuCardManage_Click);
            // 
            // 系统操作日志ToolStripMenuItem
            // 
            this.系统操作日志ToolStripMenuItem.Name = "系统操作日志ToolStripMenuItem";
            this.系统操作日志ToolStripMenuItem.Size = new System.Drawing.Size(256, 38);
            this.系统操作日志ToolStripMenuItem.Text = "系统操作日志";
            // 
            // 家政财务报表TToolStripMenuItem
            // 
            this.家政财务报表TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMoneyManage});
            this.家政财务报表TToolStripMenuItem.Name = "家政财务报表TToolStripMenuItem";
            this.家政财务报表TToolStripMenuItem.Size = new System.Drawing.Size(195, 35);
            this.家政财务报表TToolStripMenuItem.Text = "家政财务报表(&t)";
            // 
            // MenuMoneyManage
            // 
            this.MenuMoneyManage.Name = "MenuMoneyManage";
            this.MenuMoneyManage.Size = new System.Drawing.Size(280, 38);
            this.MenuMoneyManage.Text = "交易统计与查询";
            this.MenuMoneyManage.Click += new System.EventHandler(this.MenuMoneyManage_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.发送反馈ToolStripMenuItem,
            this.注册产品ToolStripMenuItem,
            this.CtmHelpItemAbout});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(105, 35);
            this.帮助ToolStripMenuItem.Text = "帮助(&h)";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.关于ToolStripMenuItem.Text = "查看帮助";
            // 
            // 发送反馈ToolStripMenuItem
            // 
            this.发送反馈ToolStripMenuItem.Name = "发送反馈ToolStripMenuItem";
            this.发送反馈ToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.发送反馈ToolStripMenuItem.Text = "发送反馈";
            // 
            // 注册产品ToolStripMenuItem
            // 
            this.注册产品ToolStripMenuItem.Name = "注册产品ToolStripMenuItem";
            this.注册产品ToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.注册产品ToolStripMenuItem.Text = "注册产品";
            // 
            // CtmHelpItemAbout
            // 
            this.CtmHelpItemAbout.Name = "CtmHelpItemAbout";
            this.CtmHelpItemAbout.Size = new System.Drawing.Size(208, 38);
            this.CtmHelpItemAbout.Text = "关于";
            this.CtmHelpItemAbout.Click += new System.EventHandler(this.CtmHelpItemAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 775);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1597, 36);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(257, 31);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 811);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "家政财务管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemManage;
        private System.Windows.Forms.ToolStripMenuItem MenuCardManage;
        private System.Windows.Forms.ToolStripMenuItem 系统操作日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 家政财务报表TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发送反馈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注册产品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CtmHelpItemAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem MenuMoneyManage;
    }
}

