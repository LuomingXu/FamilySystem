using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordSecurity;
using BLL;

namespace FamilySystem
{
    public partial class FormModifyCardPWD : Form
    {
        public FormModifyCardPWD()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 全form保存的卡号
        /// </summary>
        private string strCardNumber = string.Empty;

        public FormModifyCardPWD(string strCardNumber,Form main)
        {
            InitializeComponent();
            this.strCardNumber = strCardNumber;
            LblCardNumber.Text = strCardNumber;

            this.MdiParent = main;
        }

        private void BtnShowPWD_MouseLeave(object sender, EventArgs e)
        {
            TxtPWD.PasswordChar = '*';
            TxtPWDConfirm.PasswordChar = '*';
        }

        private void BtnShowPWD_MouseMove(object sender, MouseEventArgs e)
        {
            TxtPWD.PasswordChar = '\0';
            TxtPWDConfirm.PasswordChar = '\0';
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtPWD.Text = string.Empty;
            TxtPWDConfirm.Text = string.Empty;

            TxtPWD.Focus();
        }

        private void BtnModifyCardPWD_Click(object sender, EventArgs e)
        {
            if (TxtPWD.Text.Equals(string.Empty) || TxtPWDConfirm.Text.Equals(string.Empty))
            {
                MessageBox.Show("有空没有输入!",
                    "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (TxtPWD.Text.Equals(TxtPWDConfirm.Text))
            {
                MessageBox.Show("前后密码不一致!",
                    "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            string strPWD = PasswordStorage.CreateHash(TxtPWD.Text.Trim());

            SQLExcute excute = new SQLExcute();

            if (excute.ModifyCardPWD(strPWD, strCardNumber))
            {
                MessageBox.Show("更改密码成功!",
                    "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            else
            {
                MessageBox.Show("更改密码失败!",
                    "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormModifyCardPWD_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
