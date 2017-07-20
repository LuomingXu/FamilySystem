namespace FamilySystem
{
    partial class FormModifyWhoHoldCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifyWhoHoldCard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblCardNumber = new System.Windows.Forms.Label();
            this.LblWhoHoldCardBefore = new System.Windows.Forms.Label();
            this.TxtWhoHoldCardNow = new System.Windows.Forms.TextBox();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(68, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "卡号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(30, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "原持卡人";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(39, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "现持卡人";
            // 
            // LblCardNumber
            // 
            this.LblCardNumber.AutoSize = true;
            this.LblCardNumber.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblCardNumber.Location = new System.Drawing.Point(243, 32);
            this.LblCardNumber.Name = "LblCardNumber";
            this.LblCardNumber.Size = new System.Drawing.Size(264, 37);
            this.LblCardNumber.TabIndex = 3;
            this.LblCardNumber.Text = "LblCardNumber";
            // 
            // LblWhoHoldCardBefore
            // 
            this.LblWhoHoldCardBefore.AutoSize = true;
            this.LblWhoHoldCardBefore.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblWhoHoldCardBefore.Location = new System.Drawing.Point(243, 114);
            this.LblWhoHoldCardBefore.Name = "LblWhoHoldCardBefore";
            this.LblWhoHoldCardBefore.Size = new System.Drawing.Size(397, 37);
            this.LblWhoHoldCardBefore.TabIndex = 4;
            this.LblWhoHoldCardBefore.Text = "LblWhoHoldCardBefore";
            // 
            // TxtWhoHoldCardNow
            // 
            this.TxtWhoHoldCardNow.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtWhoHoldCardNow.Location = new System.Drawing.Point(250, 197);
            this.TxtWhoHoldCardNow.Name = "TxtWhoHoldCardNow";
            this.TxtWhoHoldCardNow.Size = new System.Drawing.Size(238, 50);
            this.TxtWhoHoldCardNow.TabIndex = 5;
            // 
            // BtnModify
            // 
            this.BtnModify.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnModify.Location = new System.Drawing.Point(88, 285);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(132, 67);
            this.BtnModify.TabIndex = 6;
            this.BtnModify.Text = "修改";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(356, 285);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(132, 67);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FormModifyWhoHoldCard
            // 
            this.AcceptButton = this.BtnModify;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(632, 392);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.TxtWhoHoldCardNow);
            this.Controls.Add(this.LblWhoHoldCardBefore);
            this.Controls.Add(this.LblCardNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormModifyWhoHoldCard";
            this.Text = "FormModifyWhoHoldCard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormModifyWhoHoldCard_FormClosed);
            this.Load += new System.EventHandler(this.FormModifyWhoHoldCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblCardNumber;
        private System.Windows.Forms.Label LblWhoHoldCardBefore;
        private System.Windows.Forms.TextBox TxtWhoHoldCardNow;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnCancel;
    }
}