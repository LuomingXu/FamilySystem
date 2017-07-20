namespace FamilySystem
{
    partial class FormCountSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCountSearch));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RdbSave = new System.Windows.Forms.RadioButton();
            this.RdbWithdraw = new System.Windows.Forms.RadioButton();
            this.TxtTransAmount = new System.Windows.Forms.TextBox();
            this.LblBalance = new System.Windows.Forms.Label();
            this.LblBankName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPWD = new System.Windows.Forms.TextBox();
            this.TxtCardNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.TxtPWD);
            this.groupBox1.Controls.Add(this.TxtCardNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(33, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 737);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "统计与查询";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RdbSave);
            this.panel1.Controls.Add(this.RdbWithdraw);
            this.panel1.Controls.Add(this.TxtTransAmount);
            this.panel1.Controls.Add(this.LblBalance);
            this.panel1.Controls.Add(this.LblBankName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(21, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 478);
            this.panel1.TabIndex = 4;
            // 
            // RdbSave
            // 
            this.RdbSave.AutoSize = true;
            this.RdbSave.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RdbSave.Location = new System.Drawing.Point(367, 167);
            this.RdbSave.Name = "RdbSave";
            this.RdbSave.Size = new System.Drawing.Size(122, 41);
            this.RdbSave.TabIndex = 8;
            this.RdbSave.TabStop = true;
            this.RdbSave.Text = "存钱";
            this.RdbSave.UseVisualStyleBackColor = true;
            // 
            // RdbWithdraw
            // 
            this.RdbWithdraw.AutoSize = true;
            this.RdbWithdraw.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RdbWithdraw.Location = new System.Drawing.Point(218, 165);
            this.RdbWithdraw.Name = "RdbWithdraw";
            this.RdbWithdraw.Size = new System.Drawing.Size(122, 41);
            this.RdbWithdraw.TabIndex = 7;
            this.RdbWithdraw.TabStop = true;
            this.RdbWithdraw.Text = "取钱";
            this.RdbWithdraw.UseVisualStyleBackColor = true;
            // 
            // TxtTransAmount
            // 
            this.TxtTransAmount.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtTransAmount.Location = new System.Drawing.Point(241, 258);
            this.TxtTransAmount.Name = "TxtTransAmount";
            this.TxtTransAmount.Size = new System.Drawing.Size(232, 50);
            this.TxtTransAmount.TabIndex = 6;
            // 
            // LblBalance
            // 
            this.LblBalance.AutoSize = true;
            this.LblBalance.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblBalance.Location = new System.Drawing.Point(211, 372);
            this.LblBalance.Name = "LblBalance";
            this.LblBalance.Size = new System.Drawing.Size(165, 37);
            this.LblBalance.TabIndex = 5;
            this.LblBalance.Text = "余额显示";
            // 
            // LblBankName
            // 
            this.LblBankName.AutoSize = true;
            this.LblBankName.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblBankName.Location = new System.Drawing.Point(234, 59);
            this.LblBankName.Name = "LblBankName";
            this.LblBankName.Size = new System.Drawing.Size(239, 37);
            this.LblBankName.TabIndex = 4;
            this.LblBankName.Text = "银行名称显示";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(64, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 37);
            this.label6.TabIndex = 3;
            this.label6.Text = "余额";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(27, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "交易金额";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(27, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "交易类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(27, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "银行名称";
            // 
            // TxtPWD
            // 
            this.TxtPWD.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtPWD.Location = new System.Drawing.Point(241, 151);
            this.TxtPWD.Name = "TxtPWD";
            this.TxtPWD.PasswordChar = '*';
            this.TxtPWD.Size = new System.Drawing.Size(295, 50);
            this.TxtPWD.TabIndex = 3;
            this.TxtPWD.TextChanged += new System.EventHandler(this.TxtPWD_TextChanged);
            this.TxtPWD.Leave += new System.EventHandler(this.TxtPWD_Leave);
            // 
            // TxtCardNumber
            // 
            this.TxtCardNumber.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtCardNumber.Location = new System.Drawing.Point(241, 79);
            this.TxtCardNumber.Name = "TxtCardNumber";
            this.TxtCardNumber.Size = new System.Drawing.Size(295, 50);
            this.TxtCardNumber.TabIndex = 2;
            this.TxtCardNumber.TextChanged += new System.EventHandler(this.TxtCardNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(65, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(65, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "卡号";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConfirm.Location = new System.Drawing.Point(86, 784);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(156, 68);
            this.BtnConfirm.TabIndex = 1;
            this.BtnConfirm.Text = "确定";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(361, 784);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(156, 68);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FormCountSearch
            // 
            this.AcceptButton = this.BtnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(650, 892);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCountSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCountSearch";
            this.Load += new System.EventHandler(this.FormCountSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPWD;
        private System.Windows.Forms.TextBox TxtCardNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RdbSave;
        private System.Windows.Forms.RadioButton RdbWithdraw;
        private System.Windows.Forms.TextBox TxtTransAmount;
        private System.Windows.Forms.Label LblBalance;
        private System.Windows.Forms.Label LblBankName;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnCancel;
    }
}