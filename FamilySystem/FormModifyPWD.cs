using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using PasswordSecurity;

namespace FamilySystem
{
    public partial class FormModifyPWD : Form
    {
        /// <summary>
        /// 全Form保存的用户名
        /// </summary>
        private string strUserName = string.Empty;

        public FormModifyPWD(string strUserName)
        {
            InitializeComponent();
            this.strUserName = strUserName;
        }

        private void FormModifyPWD_Load(object sender, EventArgs e)
        {
            LblUserName.Text = strUserName;
        }

        private void BtnShowPWD_MouseMove(object sender, MouseEventArgs e)
        {
            TxtPWD.PasswordChar = '\0';
            TxtPWDConfirm.PasswordChar = '\0';
        }

        private void BtnShowPWD_MouseLeave(object sender, EventArgs e)
        {
            TxtPWD.PasswordChar = '*';
            TxtPWDConfirm.PasswordChar = '*';
        }

        private void BtnModifyPWD_Click(object sender, EventArgs e)
        {
            string strPwd = TxtPWD.Text.Trim();
            string strPwdConfirm = TxtPWDConfirm.Text.Trim();

            if (strPwd.Equals(string.Empty))
            {
                MessageBox.Show("有空没有输入",
                    "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            if (strPwd.Equals(strPwdConfirm) == false)
            {
                MessageBox.Show("前后密码不一致", 
                    "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            strPwd = PasswordStorage.CreateHash(strPwd);
            SQLExcute excute = new SQLExcute();

            if (excute.ModifyPWD(strPwd, strUserName))
            {
                MessageBox.Show("修改密码成功", 
                    "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            else
            {
                MessageBox.Show("修改密码失败!",
                    "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
