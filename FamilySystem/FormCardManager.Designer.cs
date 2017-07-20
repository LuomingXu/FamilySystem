namespace FamilySystem
{
    partial class FormCardManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCardManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStripSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WhoHoldCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WhoCreatCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardPWD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsDataGird = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsBtnModifyPWD = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsBtnModifyWhoHoldCard = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cmsDataGird.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripTextBox1,
            this.menuStripSearch,
            this.menuStripInsert});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1377, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(39, 45);
            this.toolStripMenuItem1.Text = "|";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(240, 45);
            this.toolStripTextBox1.Leave += new System.EventHandler(this.toolStripTextBox1_Leave);
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // menuStripSearch
            // 
            this.menuStripSearch.Name = "menuStripSearch";
            this.menuStripSearch.Size = new System.Drawing.Size(94, 45);
            this.menuStripSearch.Text = "查询";
            this.menuStripSearch.Click += new System.EventHandler(this.menuStripSearch_Click);
            // 
            // menuStripInsert
            // 
            this.menuStripInsert.Name = "menuStripInsert";
            this.menuStripInsert.Size = new System.Drawing.Size(94, 45);
            this.menuStripInsert.Text = "添加";
            this.menuStripInsert.Click += new System.EventHandler(this.menuStripInsert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1377, 603);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "系统用户列表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CardNumber,
            this.BankName,
            this.Balance,
            this.WhoHoldCard,
            this.WhoCreatCard,
            this.CreatTime,
            this.CardPWD});
            this.dataGridView1.ContextMenuStrip = this.cmsDataGird;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1371, 569);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // CardNumber
            // 
            this.CardNumber.DataPropertyName = "CardNumber";
            this.CardNumber.HeaderText = "卡号";
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.ReadOnly = true;
            this.CardNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BankName
            // 
            this.BankName.DataPropertyName = "BankName";
            this.BankName.HeaderText = "银行名称";
            this.BankName.Name = "BankName";
            this.BankName.ReadOnly = true;
            this.BankName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "卡内余额";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // WhoHoldCard
            // 
            this.WhoHoldCard.DataPropertyName = "WhoHoldCard";
            this.WhoHoldCard.HeaderText = "持卡人";
            this.WhoHoldCard.Name = "WhoHoldCard";
            this.WhoHoldCard.ReadOnly = true;
            this.WhoHoldCard.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WhoHoldCard.Width = 130;
            // 
            // WhoCreatCard
            // 
            this.WhoCreatCard.DataPropertyName = "WhoCreatCard";
            this.WhoCreatCard.HeaderText = "创建人";
            this.WhoCreatCard.Name = "WhoCreatCard";
            this.WhoCreatCard.ReadOnly = true;
            this.WhoCreatCard.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WhoCreatCard.Width = 60;
            // 
            // CreatTime
            // 
            this.CreatTime.DataPropertyName = "CreatTime";
            this.CreatTime.HeaderText = "创建时间";
            this.CreatTime.Name = "CreatTime";
            this.CreatTime.ReadOnly = true;
            this.CreatTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CreatTime.Width = 140;
            // 
            // CardPWD
            // 
            this.CardPWD.DataPropertyName = "CardPWD";
            this.CardPWD.HeaderText = "密码";
            this.CardPWD.Name = "CardPWD";
            this.CardPWD.ReadOnly = true;
            this.CardPWD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CardPWD.Visible = false;
            // 
            // cmsDataGird
            // 
            this.cmsDataGird.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsDataGird.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsBtnModifyPWD,
            this.cmsBtnModifyWhoHoldCard});
            this.cmsDataGird.Name = "cmsDataGird";
            this.cmsDataGird.Size = new System.Drawing.Size(209, 76);
            // 
            // cmsBtnModifyPWD
            // 
            this.cmsBtnModifyPWD.Name = "cmsBtnModifyPWD";
            this.cmsBtnModifyPWD.Size = new System.Drawing.Size(208, 36);
            this.cmsBtnModifyPWD.Text = "修改密码";
            this.cmsBtnModifyPWD.Click += new System.EventHandler(this.cmsBtnModifyPWD_Click);
            // 
            // cmsBtnModifyWhoHoldCard
            // 
            this.cmsBtnModifyWhoHoldCard.Name = "cmsBtnModifyWhoHoldCard";
            this.cmsBtnModifyWhoHoldCard.Size = new System.Drawing.Size(208, 36);
            this.cmsBtnModifyWhoHoldCard.Text = "修改持卡人";
            this.cmsBtnModifyWhoHoldCard.Click += new System.EventHandler(this.cmsBtnModifyWhoHoldCard_Click);
            // 
            // FormCardManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 652);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormCardManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCardManager";
            this.Load += new System.EventHandler(this.FormCardManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cmsDataGird.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem menuStripSearch;
        private System.Windows.Forms.ToolStripMenuItem menuStripInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip cmsDataGird;
        private System.Windows.Forms.ToolStripMenuItem cmsBtnModifyPWD;
        private System.Windows.Forms.ToolStripMenuItem cmsBtnModifyWhoHoldCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn WhoHoldCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn WhoCreatCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardPWD;
    }
}