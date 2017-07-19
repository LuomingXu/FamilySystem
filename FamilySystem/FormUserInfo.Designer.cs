namespace FamilySystem
{
    partial class FormUserInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.BtnSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTMNormal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtmItmUpdateNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.CtmItmMdPwdNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.CtmAdm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtmItemInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.CtmItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.CtmItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.CtmItemModifyPWD = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CTMNormal.SuspendLayout();
            this.CtmAdm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.TxtSearch,
            this.BtnSearch});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1582, 42);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(32, 38);
            this.toolStripMenuItem2.Text = "|";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(450, 38);
            this.TxtSearch.Leave += new System.EventHandler(this.TxtSearch_Leave);
            this.TxtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearch_KeyPress);
            this.TxtSearch.Click += new System.EventHandler(this.TxtSearch_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(74, 38);
            this.BtnSearch.Text = "查询";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1582, 747);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询显示";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1576, 36);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(257, 31);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Enable,
            this.UserLevel,
            this.CreatTime,
            this.UpdateTime});
            this.dataGridView1.ContextMenuStrip = this.CTMNormal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1576, 713);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "用户名";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserName.Width = 60;
            // 
            // Enable
            // 
            this.Enable.DataPropertyName = "Enable";
            this.Enable.HeaderText = "是否可用";
            this.Enable.Name = "Enable";
            this.Enable.ReadOnly = true;
            this.Enable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Enable.Width = 40;
            // 
            // UserLevel
            // 
            this.UserLevel.DataPropertyName = "UserLevel";
            this.UserLevel.HeaderText = "用户等级";
            this.UserLevel.Name = "UserLevel";
            this.UserLevel.ReadOnly = true;
            this.UserLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserLevel.Width = 110;
            // 
            // CreatTime
            // 
            this.CreatTime.DataPropertyName = "CreatTime";
            this.CreatTime.HeaderText = "创建时间";
            this.CreatTime.Name = "CreatTime";
            this.CreatTime.ReadOnly = true;
            this.CreatTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CreatTime.Width = 240;
            // 
            // UpdateTime
            // 
            this.UpdateTime.DataPropertyName = "UpdateTime";
            this.UpdateTime.HeaderText = "最后更新时间";
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.ReadOnly = true;
            this.UpdateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UpdateTime.Width = 240;
            // 
            // CTMNormal
            // 
            this.CTMNormal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.CTMNormal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtmItmUpdateNormal,
            this.CtmItmMdPwdNormal});
            this.CTMNormal.Name = "CTMNormal";
            this.CTMNormal.Size = new System.Drawing.Size(185, 76);
            // 
            // CtmItmUpdateNormal
            // 
            this.CtmItmUpdateNormal.Name = "CtmItmUpdateNormal";
            this.CtmItmUpdateNormal.Size = new System.Drawing.Size(184, 36);
            this.CtmItmUpdateNormal.Text = "更改用户";
            this.CtmItmUpdateNormal.Click += new System.EventHandler(this.CtmItmUpdateNormal_Click);
            // 
            // CtmItmMdPwdNormal
            // 
            this.CtmItmMdPwdNormal.Name = "CtmItmMdPwdNormal";
            this.CtmItmMdPwdNormal.Size = new System.Drawing.Size(184, 36);
            this.CtmItmMdPwdNormal.Text = "修改密码";
            this.CtmItmMdPwdNormal.Click += new System.EventHandler(this.CtmItmMdPwdNormal_Click);
            // 
            // CtmAdm
            // 
            this.CtmAdm.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.CtmAdm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtmItemInsert,
            this.CtmItemDelete,
            this.CtmItemUpdate,
            this.CtmItemModifyPWD});
            this.CtmAdm.Name = "CtmAdm";
            this.CtmAdm.Size = new System.Drawing.Size(185, 148);
            // 
            // CtmItemInsert
            // 
            this.CtmItemInsert.Name = "CtmItemInsert";
            this.CtmItemInsert.Size = new System.Drawing.Size(184, 36);
            this.CtmItemInsert.Text = "添加用户";
            this.CtmItemInsert.Click += new System.EventHandler(this.CtmItemInsert_Click);
            // 
            // CtmItemDelete
            // 
            this.CtmItemDelete.Name = "CtmItemDelete";
            this.CtmItemDelete.Size = new System.Drawing.Size(184, 36);
            this.CtmItemDelete.Text = "删除用户";
            this.CtmItemDelete.Click += new System.EventHandler(this.CtmItemDelete_Click);
            // 
            // CtmItemUpdate
            // 
            this.CtmItemUpdate.Name = "CtmItemUpdate";
            this.CtmItemUpdate.Size = new System.Drawing.Size(184, 36);
            this.CtmItemUpdate.Text = "更改用户";
            this.CtmItemUpdate.Click += new System.EventHandler(this.CtmItemUpdate_Click);
            // 
            // CtmItemModifyPWD
            // 
            this.CtmItemModifyPWD.Name = "CtmItemModifyPWD";
            this.CtmItemModifyPWD.Size = new System.Drawing.Size(184, 36);
            this.CtmItemModifyPWD.Text = "修改密码";
            this.CtmItemModifyPWD.Click += new System.EventHandler(this.CtmItemModifyPWD_Click);
            // 
            // FormUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 789);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户信息查询";
            this.Load += new System.EventHandler(this.FormUserInfo_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CTMNormal.ResumeLayout(false);
            this.CtmAdm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripTextBox TxtSearch;
        private System.Windows.Forms.ToolStripMenuItem BtnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip CtmAdm;
        private System.Windows.Forms.ToolStripMenuItem CtmItemInsert;
        private System.Windows.Forms.ToolStripMenuItem CtmItemDelete;
        private System.Windows.Forms.ToolStripMenuItem CtmItemUpdate;
        private System.Windows.Forms.ContextMenuStrip CTMNormal;
        private System.Windows.Forms.ToolStripMenuItem CtmItmUpdateNormal;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enable;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
        private System.Windows.Forms.ToolStripMenuItem CtmItmMdPwdNormal;
        private System.Windows.Forms.ToolStripMenuItem CtmItemModifyPWD;
    }
}