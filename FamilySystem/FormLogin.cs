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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            TxtUserName.Focus();

            {//测试代码
                TxtUserName.Text = "123";
                TxtPWD.Text = "qwe";
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string strUserName = TxtUserName.Text.Trim();
            string strPWD = TxtPWD.Text.Trim();

            bool isPwdRight;
            bool isEnable;

            DataSet ds = new DataSet();
            SQLExcute excute = new SQLExcute();
            ds = excute.IdentifyUser(strUserName);
            string strPWDFromServer = Convert.ToString(ds.Tables[0].Rows[0][0]);

            isPwdRight = PasswordStorage.VerifyPassword(strPWD, strPWDFromServer);
            isEnable = excute.ConfirmUserEnable(strUserName);

            if (isPwdRight)
            {
                if (isEnable)
                {
                    MessageBox.Show("登录成功!",
                    "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormMain FrmMain = new FormMain();
                    FrmMain.toolStripStatusLabel1.Text = "欢迎您:" + strUserName;

                    FrmMain.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("用户未启用!",
                        "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("登陆失败!", 
                    "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtUserName.Text = string.Empty;
            TxtPWD.Text = string.Empty;

            TxtUserName.Focus();
        }
    }
}
