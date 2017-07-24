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
    public partial class FormUserInfo : Form, INterface
    {
        public FormUserInfo()
        {
            InitializeComponent();
        }

        private FormRegister FrmRegister = null;

        public void ChangeDataGridView(DataTable dt)
        {
            dataGridView1.DataSource = dt;
        }

        private void GetAllUserInfo()
        {
            SQLExcute excute = new SQLExcute();
            dataGridView1.DataSource = excute.GetAllUserInfo().Tables["用户信息表"];
        }

        /// <summary>
        /// 全From保存的用户名
        /// </summary>
        private string strUserName = string.Empty;

        /// <summary>
        /// 删除时保存用户选择删除的用户名
        /// </summary>
        private string strSelectedUserName = string.Empty;

        //在此load事件中确定了登录用户的等级, 以此来确定实例化一个怎样的
        //用户修改窗体, 怎样的右键菜单, 不同的右键菜单下有不一样的菜单项
        //这样就能然用户等级有一定的作用
        private void FormUserInfo_Load(object sender, EventArgs e)
        {
            string[] strTempUserName = toolStripStatusLabel1.Text.Split(':');
            strUserName = strTempUserName[1];

            TxtSearch.Text = "请在此需要输入查询的用户名...";

            SQLExcute excute = new SQLExcute();
            DataTable dt = new DataTable();
            dt = excute.GetAllUserInfo().Tables["用户信息表"];
            dataGridView1.DataSource = dt;

            toolStripStatusLabel1.Text += "      共计加载了" + dt.DefaultView.Count.ToString() + "条数据";

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
            if (FrmRegister == null)
            {
                FrmRegister = new FormRegister(this, this.MdiParent);
                FrmRegister.Show();
            }
            else if (FrmRegister != null)
            {
                if (FrmRegister.IsDisposed == true)
                {
                    FrmRegister = new FormRegister(this, this.MdiParent);
                    FrmRegister.Show();
                }
                else
                {
                    FrmRegister.Activate();
                }
            }
        }

        private void CtmItemUpdate_Click(object sender, EventArgs e)
        {
            if (FrmRegister == null)
            {
                FrmRegister = new FormRegister(strUserName, this, this.MdiParent);
                FrmRegister.Show();
            }
            else if (FrmRegister != null)
            {
                if (FrmRegister.IsDisposed == true)
                {
                    FrmRegister = new FormRegister(strUserName, this, this.MdiParent);
                    FrmRegister.Show();
                }
                else
                {
                    FrmRegister.Activate();
                }                 
            }
        }

        private void CtmItmUpdateNormal_Click(object sender, EventArgs e)
        {
            if (FrmRegister == null)
            {
                FrmRegister = new FormRegister(strUserName, "Normal", this, this.MdiParent);
                FrmRegister.Show();
            }
            else if (FrmRegister != null)
            {
                if (FrmRegister.IsDisposed == true)
                {
                    FrmRegister = new FormRegister(strUserName, "Normal", this, this.MdiParent);
                    FrmRegister.Show();
                }
                else
                {
                    FrmRegister.Activate();
                }                 
            }
        }

        private void CtmItemDelete_Click(object sender, EventArgs e)
        {
            //FormDelete FrmDel = new FormDelete(strUserName);
            //FrmDel.Show();
            if (strSelectedUserName.Equals(string.Empty) != true)
            {
                SQLExcute excute = new SQLExcute();

                if (strSelectedUserName.Equals(strUserName))
                {
                    MessageBox.Show("不可以删除自己!",
                        "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                DialogResult isExit =
                    MessageBox.Show("真的要删除\"" + strSelectedUserName + "\"的数据吗?",
                    "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (isExit.Equals(DialogResult.Yes))
                {
                    if (excute.DeleteUserInfo(strSelectedUserName))
                    {
                        MessageBox.Show("删除成功!",
                            "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GetAllUserInfo();
                    }
                    else
                    {
                        MessageBox.Show("删除失败!",
                            "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            
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

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {//右键直接点击, 可以直接选择一行数据
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                strSelectedUserName = Convert.ToString(dataGridView1.CurrentRow.Cells["UserName"].Value);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {//左键点击, 选择一行数据
            if (e.RowIndex > -1)
            {
                strSelectedUserName = Convert.ToString(dataGridView1.CurrentRow.Cells["UserName"].Value);
            }
        }
    }
}
