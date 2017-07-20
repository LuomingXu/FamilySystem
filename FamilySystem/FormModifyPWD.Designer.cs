namespace FamilySystem
{
    partial class FormModifyPWD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifyPWD));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnModifyPWD = new System.Windows.Forms.Button();
            this.BtnShowPWD = new System.Windows.Forms.Button();
            this.TxtPWD = new System.Windows.Forms.TextBox();
            this.TxtPWDConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(73, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(90, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(54, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码确认";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblUserName.Location = new System.Drawing.Point(248, 45);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(226, 37);
            this.LblUserName.TabIndex = 3;
            this.LblUserName.Text = "LblUserName";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(312, 287);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(162, 65);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnModifyPWD
            // 
            this.BtnModifyPWD.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnModifyPWD.Location = new System.Drawing.Point(80, 287);
            this.BtnModifyPWD.Name = "BtnModifyPWD";
            this.BtnModifyPWD.Size = new System.Drawing.Size(162, 65);
            this.BtnModifyPWD.TabIndex = 5;
            this.BtnModifyPWD.Text = "确定";
            this.BtnModifyPWD.UseVisualStyleBackColor = true;
            this.BtnModifyPWD.Click += new System.EventHandler(this.BtnModifyPWD_Click);
            // 
            // BtnShowPWD
            // 
            this.BtnShowPWD.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnShowPWD.Location = new System.Drawing.Point(533, 107);
            this.BtnShowPWD.Name = "BtnShowPWD";
            this.BtnShowPWD.Size = new System.Drawing.Size(75, 143);
            this.BtnShowPWD.TabIndex = 6;
            this.BtnShowPWD.Text = "显示密码";
            this.BtnShowPWD.UseVisualStyleBackColor = true;
            this.BtnShowPWD.MouseLeave += new System.EventHandler(this.BtnShowPWD_MouseLeave);
            this.BtnShowPWD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnShowPWD_MouseMove);
            // 
            // TxtPWD
            // 
            this.TxtPWD.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtPWD.Location = new System.Drawing.Point(255, 111);
            this.TxtPWD.Name = "TxtPWD";
            this.TxtPWD.PasswordChar = '*';
            this.TxtPWD.Size = new System.Drawing.Size(228, 50);
            this.TxtPWD.TabIndex = 0;
            // 
            // TxtPWDConfirm
            // 
            this.TxtPWDConfirm.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtPWDConfirm.Location = new System.Drawing.Point(255, 200);
            this.TxtPWDConfirm.Name = "TxtPWDConfirm";
            this.TxtPWDConfirm.PasswordChar = '*';
            this.TxtPWDConfirm.Size = new System.Drawing.Size(228, 50);
            this.TxtPWDConfirm.TabIndex = 8;
            // 
            // FormModifyPWD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 390);
            this.Controls.Add(this.TxtPWDConfirm);
            this.Controls.Add(this.TxtPWD);
            this.Controls.Add(this.BtnShowPWD);
            this.Controls.Add(this.BtnModifyPWD);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormModifyPWD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModifyPWD";
            this.Load += new System.EventHandler(this.FormModifyPWD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnModifyPWD;
        private System.Windows.Forms.Button BtnShowPWD;
        private System.Windows.Forms.TextBox TxtPWD;
        private System.Windows.Forms.TextBox TxtPWDConfirm;
    }
}