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

namespace FamilySystem
{
    public partial class FormUserInfo : Form
    {
        public FormUserInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 全From保存的用户名
        /// </summary>
        private string strUserName = string.Empty;

        //在此load事件中确定了登录用户的等级, 以此来确定实例化一个怎样的
        //用户修改窗体, 怎样的右键菜单, 不同的右键菜单下有不一样的菜单项
        //这样就能然用户等级有一定的作用
        private void FormUserInfo_Load(object sender, EventArgs e)
        {
            string[] strTempUserName = toolStripStatusLabel1.Text.Split(':');
            strUserName = strTempUserName[1];

            TxtSearch.Text = "请在此需要输入查询的用户名...";
            
            SQLExcute excute = new SQLExcute();
            dataGridView1.DataSource = excute.GetAllUserInfo().Tables["用户信息表"];

            bool isAdm = excute.IsAdm(strUserName);

            if (isAdm)
            {
                dataGridView1.ContextMenuStrip = CtmAdm;
            }
            else
            {
                dataGridView1.ContextMenuStrip = CTMNormal;
            }
        }

        private void TxtSearch_Click(object sender, EventArgs e)
        {
            TxtSearch.Text = string.Empty;
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (TxtSearch.Text.Equals(string.Empty))
            {
                TxtSearch.Text = "请在此需要输入查询的用户名...";
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string strUserName = TxtSearch.Text.Trim();

            SQLExcute excute = new SQLExcute();

            if (strUserName.Equals("all"))
            {
                dataGridView1.DataSource = excute.GetAllUserInfo().Tables["用户信息表"];

                return;
            }

            dataGridView1.DataSource = excute.GetUserInfoByUserName(strUserName).Tables["单一用户信息表"];
        }

        private void CtmItemInsert_Click(object sender, EventArgs e)
        {
            FormRegister FrmRegister = new FormRegister();
            FrmRegister.Show();
        }

        private void CtmItemUpdate_Click(object sender, EventArgs e)
        {
            FormRegister FrmRegister = new FormRegister(strUserName);
            FrmRegister.Show();
        }

        private void CtmItemDelete_Click(object sender, EventArgs e)
        {
            FormDelete FrmDel = new FormDelete(strUserName);
            FrmDel.Show();
        }

        private void CtmItmUpdateNormal_Click(object sender, EventArgs e)
        {
            FormRegister FrmRegister = new FormRegister(strUserName,"Normal");
            FrmRegister.Show();
        }

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnSearch.PerformClick();
                return;
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                TxtSearch.Text = string.Empty;
                return;
            }
        }

        /// <summary>
        /// 显示修改密码窗体
        /// </summary>
        private void ShowMdPwd()
        {
            FormModifyPWD MdPWD = new FormModifyPWD(strUserName);
            MdPWD.Show();
        }

        private void CtmItemModifyPWD_Click(object sender, EventArgs e)
        {
            ShowMdPwd();
        }

        private void CtmItmMdPwdNormal_Click(object sender, EventArgs e)
        {
            ShowMdPwd();
        }
    }
}
