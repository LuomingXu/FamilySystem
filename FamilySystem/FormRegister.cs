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
using UserInfo;

namespace FamilySystem
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private string strUserName = string.Empty;
        private User user = new User();
        private string strLevel = string.Empty;

        private void Edit(string strUserName)
        {
            this.strUserName = strUserName;
            this.Text = "用户信息修改";
            user.Name = strUserName;

            SQLExcute excute = new SQLExcute();
            DataSet ds = new DataSet();
            ds = excute.GetUserInfoByUserName(strUserName);

            TXTUserName.TabIndex = 10;
            BtnUpdate.TabIndex = 0;
            BtnUpdate.Visible = true;

            TXTUserName.ReadOnly = true;
            TXTUserName.Text = strUserName;

            LblCreatTime.Visible = true;
            LblUserStatus.Visible = true;
            panel2.Visible = true;
            TxtCreatTime.Visible = true;

            TxtPWD.ReadOnly = true;
            TxtPWD.Text = "                  ";
            TxtPWD.PasswordChar = '*';
            TxtPWDConfirm.ReadOnly = true;
            TxtPWDConfirm.Text = "                 ";
            TxtPWDConfirm.PasswordChar = '*';

            BtnShowPWD.Visible = false;
            BtnRegister.Visible = false;

            if (ds.Tables[0].Rows[0][1].Equals("管理员"))
            {
                RdbAdm.Checked = true;
            }
            else
            {
                RdbNormal.Checked = true;
            }

            if (ds.Tables[0].Rows[0][2].Equals("是"))
            {
                RdbEnableTrue.Checked = true;
            }
            else
            {
                RdbEnableFalse.Checked = true;
            }

            TxtCreatTime.Text = Convert.ToString(ds.Tables[0].Rows[0][3]);
        }

        //管理员账户实例化的修改界面
        public FormRegister(string strUserName)
        {
            InitializeComponent();

            strLevel = "Adm";//在Edit里面就有了txtchage所以要把这个写在前面
            //这样在txtchange事件时, 就会不再使用注册的时候使用的lbl的判断代码
            //而是使用, 在修改用户信息的时候使用的lbl的判断代码
            Edit(strUserName);
        
            TXTUserName.ReadOnly = false;
        }

        //普通用户实例化的修改界面
        public FormRegister(string strUserName, string strLevel)
        {
            InitializeComponent();

            Edit(strUserName);

            this.strLevel = strLevel;
            panel1.Visible = false;
            LblLevel.Text = "权限:      普通用户";
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string strUserName = TXTUserName.Text.Trim();
            string strPWD = TxtPWD.Text.Trim();
            string strPWDConfirm = TxtPWDConfirm.Text.Trim();

            if (strUserName.Equals(string.Empty) || strPWD.Equals(string.Empty))
            {
                MessageBox.Show("您有信息没有输入!", 
                    "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (strPWD.Equals(strPWDConfirm).Equals(false))
            {
                MessageBox.Show("前后密码不一致!", 
                    "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            user.Name = strUserName;
            user.PWD = PasswordStorage.CreateHash(strPWD);

            if (RdbAdm.Checked == true)
            {
                user.Level = 1;
            }
            else if(RdbNormal.Checked == true)
            {
                user.Level = 0;
            }

            SQLExcute excute = new SQLExcute();

            if (excute.InsertUserInfo(user) == 1)
            {
                MessageBox.Show("注册成功!", 
                    "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            else
            {
                MessageBox.Show("注册失败!",
                 "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TXTUserName.Text = string.Empty;
            TxtPWD.Text = string.Empty;
            TxtPWDConfirm.Text = string.Empty;

            TXTUserName.Focus();
        }

        private void TXTUserName_TextChanged(object sender, EventArgs e)
        {
            string strUserName = TXTUserName.Text.Trim();

            if (strUserName.Equals("all"))
            {
                LblConfirmUserName.Text = "系统保留的用户名!";
                LblConfirmUserName.ForeColor = Color.Red;
                LblConfirmUserName.Visible = true;
                BtnRegister.Enabled = false;

                return;
            }

            int ret = 0;
            SQLExcute excute = new SQLExcute();
            ret = excute.ConfirmTheOnlyUserName(strUserName);

            if (strLevel.Equals("Adm"))//在修改用户的时候使用的代码
            {
                LblConfirmUserName.Visible = false;

                if (ret > 0)
                {
                    LblConfirmUserName.Text = "此用户名存在.";
                    LblConfirmUserName.ForeColor = Color.Green;
                    LblConfirmUserName.Visible = true;
                    BtnUpdate.Enabled = true;
                }
                else
                {
                    LblConfirmUserName.Text = "不存在此用户名!";
                    LblConfirmUserName.ForeColor = Color.Red;
                    LblConfirmUserName.Visible = true;
                    BtnUpdate.Enabled = false;
                }

                return;
            }

            if (ret > 0)//在注册的时候使用的代码
            {
                LblConfirmUserName.Text = "此用户名已存在!";
                LblConfirmUserName.ForeColor = Color.Red;
                LblConfirmUserName.Visible = true;
                BtnRegister.Enabled = false;
            }
            else
            {
                LblConfirmUserName.Text = "可用的用户名";
                LblConfirmUserName.ForeColor = Color.Green;
                LblConfirmUserName.Visible = true;
                BtnRegister.Enabled = true;
            }
        }

        private void BtnShowPWD_MouseMove(object sender, MouseEventArgs e)
        {
            TxtPWD.PasswordChar = '\0';
            TxtPWDConfirm.PasswordChar = '\0';
        }

        private void BtnShowPWD_MouseLeave(object sender, EventArgs e)
        {
            TxtPWDConfirm.PasswordChar = '*';
            TxtPWD.PasswordChar = '*';
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (RdbAdm.Checked == true)
            {
                user.Level = 1;
            }
            else if (RdbNormal.Checked == true)
            {
                user.Level = 0;
            }

            if (RdbEnableTrue.Checked==true)
            {
                user.Enable = "是";
            }
            else
            {
                user.Enable = "否";
            }

            DialogResult isUpdate;
            isUpdate = MessageBox.Show("是否更新?",
                "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (isUpdate.Equals(DialogResult.Yes))
            {
                SQLExcute excute = new SQLExcute();
                if (excute.UpdateUserInfo(user))
                {
                    MessageBox.Show("更新成功!",
                        "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                else
                {
                    MessageBox.Show("更新失败",
                        "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            TXTUserName.Text = strUserName;
        }
    }
}
