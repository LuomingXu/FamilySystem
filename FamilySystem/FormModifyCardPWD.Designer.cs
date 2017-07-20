namespace FamilySystem
{
    partial class FormModifyCardPWD
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
            this.TxtPWDConfirm = new System.Windows.Forms.TextBox();
            this.TxtPWD = new System.Windows.Forms.TextBox();
            this.BtnShowPWD = new System.Windows.Forms.Button();
            this.BtnModifyCardPWD = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblCardNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtPWDConfirm
            // 
            this.TxtPWDConfirm.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtPWDConfirm.Location = new System.Drawing.Point(250, 198);
            this.TxtPWDConfirm.Name = "TxtPWDConfirm";
            this.TxtPWDConfirm.PasswordChar = '*';
            this.TxtPWDConfirm.Size = new System.Drawing.Size(228, 50);
            this.TxtPWDConfirm.TabIndex = 17;
            // 
            // TxtPWD
            // 
            this.TxtPWD.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtPWD.Location = new System.Drawing.Point(250, 109);
            this.TxtPWD.Name = "TxtPWD";
            this.TxtPWD.PasswordChar = '*';
            this.TxtPWD.Size = new System.Drawing.Size(228, 50);
            this.TxtPWD.TabIndex = 9;
            // 
            // BtnShowPWD
            // 
            this.BtnShowPWD.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnShowPWD.Location = new System.Drawing.Point(528, 105);
            this.BtnShowPWD.Name = "BtnShowPWD";
            this.BtnShowPWD.Size = new System.Drawing.Size(75, 143);
            this.BtnShowPWD.TabIndex = 16;
            this.BtnShowPWD.Text = "显示密码";
            this.BtnShowPWD.UseVisualStyleBackColor = true;
            this.BtnShowPWD.MouseLeave += new System.EventHandler(this.BtnShowPWD_MouseLeave);
            this.BtnShowPWD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnShowPWD_MouseMove);
            // 
            // BtnModifyCardPWD
            // 
            this.BtnModifyCardPWD.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnModifyCardPWD.Location = new System.Drawing.Point(75, 285);
            this.BtnModifyCardPWD.Name = "BtnModifyCardPWD";
            this.BtnModifyCardPWD.Size = new System.Drawing.Size(162, 65);
            this.BtnModifyCardPWD.TabIndex = 15;
            this.BtnModifyCardPWD.Text = "确定";
            this.BtnModifyCardPWD.UseVisualStyleBackColor = true;
            this.BtnModifyCardPWD.Click += new System.EventHandler(this.BtnModifyCardPWD_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(307, 285);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(162, 65);
            this.BtnCancel.TabIndex = 14;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblCardNumber
            // 
            this.LblCardNumber.AutoSize = true;
            this.LblCardNumber.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblCardNumber.Location = new System.Drawing.Point(243, 43);
            this.LblCardNumber.Name = "LblCardNumber";
            this.LblCardNumber.Size = new System.Drawing.Size(264, 37);
            this.LblCardNumber.TabIndex = 13;
            this.LblCardNumber.Text = "LblCardNumber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(36, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "密码确认";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(68, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(68, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "卡号";
            // 
            // FormModifyCardPWD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 397);
            this.Controls.Add(this.TxtPWDConfirm);
            this.Controls.Add(this.TxtPWD);
            this.Controls.Add(this.BtnShowPWD);
            this.Controls.Add(this.BtnModifyCardPWD);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.LblCardNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormModifyCardPWD";
            this.Text = "FormModifyCardPWD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormModifyCardPWD_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPWDConfirm;
        private System.Windows.Forms.TextBox TxtPWD;
        private System.Windows.Forms.Button BtnShowPWD;
        private System.Windows.Forms.Button BtnModifyCardPWD;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblCardNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}