namespace FamilySystem
{
    partial class FormInsertCardInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInsertCardInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblConfirmCardNumber = new System.Windows.Forms.Label();
            this.TxtCardPWD = new System.Windows.Forms.TextBox();
            this.TxtCardName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtWhoHoldCard = new System.Windows.Forms.TextBox();
            this.TxtBalance = new System.Windows.Forms.TextBox();
            this.CmbBankName = new System.Windows.Forms.ComboBox();
            this.LblWhoCreatCard = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.LblConfirmCardNumber);
            this.groupBox1.Controls.Add(this.TxtCardPWD);
            this.groupBox1.Controls.Add(this.TxtCardName);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(31, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 698);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "存储卡信息添加";
            // 
            // LblConfirmCardNumber
            // 
            this.LblConfirmCardNumber.AutoSize = true;
            this.LblConfirmCardNumber.Location = new System.Drawing.Point(255, 130);
            this.LblConfirmCardNumber.Name = "LblConfirmCardNumber";
            this.LblConfirmCardNumber.Size = new System.Drawing.Size(131, 37);
            this.LblConfirmCardNumber.TabIndex = 5;
            this.LblConfirmCardNumber.Text = "label7";
            this.LblConfirmCardNumber.Visible = false;
            // 
            // TxtCardPWD
            // 
            this.TxtCardPWD.Location = new System.Drawing.Point(255, 184);
            this.TxtCardPWD.Name = "TxtCardPWD";
            this.TxtCardPWD.Size = new System.Drawing.Size(227, 50);
            this.TxtCardPWD.TabIndex = 4;
            // 
            // TxtCardName
            // 
            this.TxtCardName.Location = new System.Drawing.Point(254, 68);
            this.TxtCardName.Name = "TxtCardName";
            this.TxtCardName.Size = new System.Drawing.Size(227, 50);
            this.TxtCardName.TabIndex = 3;
            this.TxtCardName.TextChanged += new System.EventHandler(this.TxtCardName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtWhoHoldCard);
            this.panel1.Controls.Add(this.TxtBalance);
            this.panel1.Controls.Add(this.CmbBankName);
            this.panel1.Controls.Add(this.LblWhoCreatCard);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(19, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 390);
            this.panel1.TabIndex = 2;
            // 
            // TxtWhoHoldCard
            // 
            this.TxtWhoHoldCard.Location = new System.Drawing.Point(235, 226);
            this.TxtWhoHoldCard.Name = "TxtWhoHoldCard";
            this.TxtWhoHoldCard.Size = new System.Drawing.Size(228, 50);
            this.TxtWhoHoldCard.TabIndex = 7;
            // 
            // TxtBalance
            // 
            this.TxtBalance.Location = new System.Drawing.Point(235, 135);
            this.TxtBalance.Name = "TxtBalance";
            this.TxtBalance.Size = new System.Drawing.Size(228, 50);
            this.TxtBalance.TabIndex = 6;
            // 
            // CmbBankName
            // 
            this.CmbBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBankName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmbBankName.FormattingEnabled = true;
            this.CmbBankName.Location = new System.Drawing.Point(217, 45);
            this.CmbBankName.Name = "CmbBankName";
            this.CmbBankName.Size = new System.Drawing.Size(322, 41);
            this.CmbBankName.TabIndex = 5;
            // 
            // LblWhoCreatCard
            // 
            this.LblWhoCreatCard.AutoSize = true;
            this.LblWhoCreatCard.Location = new System.Drawing.Point(236, 314);
            this.LblWhoCreatCard.Name = "LblWhoCreatCard";
            this.LblWhoCreatCard.Size = new System.Drawing.Size(202, 37);
            this.LblWhoCreatCard.TabIndex = 4;
            this.LblWhoCreatCard.Text = "建卡人显示";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 37);
            this.label6.TabIndex = 3;
            this.label6.Text = "建卡人";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "持卡人";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "卡内余额";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "银行名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "卡号";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConfirm.Location = new System.Drawing.Point(110, 780);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(161, 67);
            this.BtnConfirm.TabIndex = 1;
            this.BtnConfirm.Text = "确定";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(396, 780);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(161, 67);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FormInsertCardInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 891);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormInsertCardInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInsertCardInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInsertCardInfo_FormClosed);
            this.Load += new System.EventHandler(this.FormInsertCardInfo_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtCardPWD;
        private System.Windows.Forms.TextBox TxtCardName;
        private System.Windows.Forms.TextBox TxtWhoHoldCard;
        private System.Windows.Forms.TextBox TxtBalance;
        private System.Windows.Forms.ComboBox CmbBankName;
        private System.Windows.Forms.Label LblWhoCreatCard;
        private System.Windows.Forms.Label LblConfirmCardNumber;
    }
}