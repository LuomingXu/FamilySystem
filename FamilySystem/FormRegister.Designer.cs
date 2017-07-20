namespace FamilySystem
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTUserName = new System.Windows.Forms.TextBox();
            this.TxtPWD = new System.Windows.Forms.TextBox();
            this.TxtPWDConfirm = new System.Windows.Forms.TextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblConfirmUserName = new System.Windows.Forms.Label();
            this.LblLevel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RdbNormal = new System.Windows.Forms.RadioButton();
            this.RdbAdm = new System.Windows.Forms.RadioButton();
            this.BtnShowPWD = new System.Windows.Forms.Button();
            this.LblUserStatus = new System.Windows.Forms.Label();
            this.LblCreatTime = new System.Windows.Forms.Label();
            this.TxtCreatTime = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RdbEnableFalse = new System.Windows.Forms.RadioButton();
            this.RdbEnableTrue = new System.Windows.Forms.RadioButton();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(63, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(87, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(51, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码确认";
            // 
            // TXTUserName
            // 
            this.TXTUserName.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXTUserName.Location = new System.Drawing.Point(275, 59);
            this.TXTUserName.Name = "TXTUserName";
            this.TXTUserName.Size = new System.Drawing.Size(251, 50);
            this.TXTUserName.TabIndex = 0;
            this.TXTUserName.TextChanged += new System.EventHandler(this.TXTUserName_TextChanged);
            // 
            // TxtPWD
            // 
            this.TxtPWD.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtPWD.Location = new System.Drawing.Point(275, 180);
            this.TxtPWD.Name = "TxtPWD";
            this.TxtPWD.PasswordChar = '*';
            this.TxtPWD.Size = new System.Drawing.Size(251, 50);
            this.TxtPWD.TabIndex = 1;
            // 
            // TxtPWDConfirm
            // 
            this.TxtPWDConfirm.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtPWDConfirm.Location = new System.Drawing.Point(275, 255);
            this.TxtPWDConfirm.Name = "TxtPWDConfirm";
            this.TxtPWDConfirm.PasswordChar = '*';
            this.TxtPWDConfirm.Size = new System.Drawing.Size(251, 50);
            this.TxtPWDConfirm.TabIndex = 2;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRegister.Location = new System.Drawing.Point(94, 743);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(156, 75);
            this.BtnRegister.TabIndex = 6;
            this.BtnRegister.Text = "注册";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(367, 743);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(156, 75);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblConfirmUserName
            // 
            this.LblConfirmUserName.AutoSize = true;
            this.LblConfirmUserName.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblConfirmUserName.Location = new System.Drawing.Point(275, 130);
            this.LblConfirmUserName.Name = "LblConfirmUserName";
            this.LblConfirmUserName.Size = new System.Drawing.Size(131, 37);
            this.LblConfirmUserName.TabIndex = 8;
            this.LblConfirmUserName.Text = "label4";
            this.LblConfirmUserName.Visible = false;
            // 
            // LblLevel
            // 
            this.LblLevel.AutoSize = true;
            this.LblLevel.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblLevel.Location = new System.Drawing.Point(51, 350);
            this.LblLevel.Name = "LblLevel";
            this.LblLevel.Size = new System.Drawing.Size(165, 37);
            this.LblLevel.TabIndex = 11;
            this.LblLevel.Text = "权限选择";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RdbNormal);
            this.panel1.Controls.Add(this.RdbAdm);
            this.panel1.Location = new System.Drawing.Point(279, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 125);
            this.panel1.TabIndex = 12;
            // 
            // RdbNormal
            // 
            this.RdbNormal.AutoSize = true;
            this.RdbNormal.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RdbNormal.Location = new System.Drawing.Point(9, 69);
            this.RdbNormal.Name = "RdbNormal";
            this.RdbNormal.Size = new System.Drawing.Size(196, 41);
            this.RdbNormal.TabIndex = 4;
            this.RdbNormal.TabStop = true;
            this.RdbNormal.Text = "普通用户";
            this.RdbNormal.UseVisualStyleBackColor = true;
            // 
            // RdbAdm
            // 
            this.RdbAdm.AutoSize = true;
            this.RdbAdm.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RdbAdm.Location = new System.Drawing.Point(9, 13);
            this.RdbAdm.Name = "RdbAdm";
            this.RdbAdm.Size = new System.Drawing.Size(159, 41);
            this.RdbAdm.TabIndex = 3;
            this.RdbAdm.TabStop = true;
            this.RdbAdm.Text = "管理员";
            this.RdbAdm.UseVisualStyleBackColor = true;
            // 
            // BtnShowPWD
            // 
            this.BtnShowPWD.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnShowPWD.Location = new System.Drawing.Point(556, 156);
            this.BtnShowPWD.Name = "BtnShowPWD";
            this.BtnShowPWD.Size = new System.Drawing.Size(75, 169);
            this.BtnShowPWD.TabIndex = 13;
            this.BtnShowPWD.Text = "显示密码";
            this.BtnShowPWD.UseVisualStyleBackColor = true;
            this.BtnShowPWD.MouseLeave += new System.EventHandler(this.BtnShowPWD_MouseLeave);
            this.BtnShowPWD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnShowPWD_MouseMove);
            // 
            // LblUserStatus
            // 
            this.LblUserStatus.AutoSize = true;
            this.LblUserStatus.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblUserStatus.Location = new System.Drawing.Point(63, 522);
            this.LblUserStatus.Name = "LblUserStatus";
            this.LblUserStatus.Size = new System.Drawing.Size(165, 37);
            this.LblUserStatus.TabIndex = 14;
            this.LblUserStatus.Text = "用户状态";
            this.LblUserStatus.Visible = false;
            // 
            // LblCreatTime
            // 
            this.LblCreatTime.AutoSize = true;
            this.LblCreatTime.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblCreatTime.Location = new System.Drawing.Point(26, 625);
            this.LblCreatTime.Name = "LblCreatTime";
            this.LblCreatTime.Size = new System.Drawing.Size(165, 37);
            this.LblCreatTime.TabIndex = 15;
            this.LblCreatTime.Text = "创建时间";
            this.LblCreatTime.Visible = false;
            // 
            // TxtCreatTime
            // 
            this.TxtCreatTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtCreatTime.Location = new System.Drawing.Point(213, 625);
            this.TxtCreatTime.Name = "TxtCreatTime";
            this.TxtCreatTime.ReadOnly = true;
            this.TxtCreatTime.Size = new System.Drawing.Size(418, 44);
            this.TxtCreatTime.TabIndex = 16;
            this.TxtCreatTime.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RdbEnableFalse);
            this.panel2.Controls.Add(this.RdbEnableTrue);
            this.panel2.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(275, 480);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 111);
            this.panel2.TabIndex = 17;
            this.panel2.Visible = false;
            // 
            // RdbEnableFalse
            // 
            this.RdbEnableFalse.AutoSize = true;
            this.RdbEnableFalse.Location = new System.Drawing.Point(13, 57);
            this.RdbEnableFalse.Name = "RdbEnableFalse";
            this.RdbEnableFalse.Size = new System.Drawing.Size(159, 41);
            this.RdbEnableFalse.TabIndex = 1;
            this.RdbEnableFalse.TabStop = true;
            this.RdbEnableFalse.Text = "不可用";
            this.RdbEnableFalse.UseVisualStyleBackColor = true;
            // 
            // RdbEnableTrue
            // 
            this.RdbEnableTrue.AutoSize = true;
            this.RdbEnableTrue.Location = new System.Drawing.Point(13, 10);
            this.RdbEnableTrue.Name = "RdbEnableTrue";
            this.RdbEnableTrue.Size = new System.Drawing.Size(122, 41);
            this.RdbEnableTrue.TabIndex = 0;
            this.RdbEnableTrue.TabStop = true;
            this.RdbEnableTrue.Text = "可用";
            this.RdbEnableTrue.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnUpdate.Location = new System.Drawing.Point(94, 747);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(156, 66);
            this.BtnUpdate.TabIndex = 18;
            this.BtnUpdate.Text = "更改";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // FormRegister
            // 
            this.AcceptButton = this.BtnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(665, 864);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtCreatTime);
            this.Controls.Add(this.LblCreatTime);
            this.Controls.Add(this.LblUserStatus);
            this.Controls.Add(this.BtnShowPWD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblLevel);
            this.Controls.Add(this.LblConfirmUserName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.TxtPWDConfirm);
            this.Controls.Add(this.TxtPWD);
            this.Controls.Add(this.TXTUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户注册";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegister_FormClosed);
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TXTUserName;
        private System.Windows.Forms.TextBox TxtPWD;
        private System.Windows.Forms.TextBox TxtPWDConfirm;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblConfirmUserName;
        private System.Windows.Forms.Label LblLevel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RdbNormal;
        private System.Windows.Forms.RadioButton RdbAdm;
        private System.Windows.Forms.Button BtnShowPWD;
        private System.Windows.Forms.Label LblUserStatus;
        private System.Windows.Forms.Label LblCreatTime;
        private System.Windows.Forms.TextBox TxtCreatTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RdbEnableFalse;
        private System.Windows.Forms.RadioButton RdbEnableTrue;
        private System.Windows.Forms.Button BtnUpdate;
    }
}