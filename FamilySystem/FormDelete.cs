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
    public partial class FormDelete : Form
    {
        private INterface DataChange;

        public FormDelete(INterface DataChange,string strUserName)
        {
            InitializeComponent();
            this.strUserName = strUserName;
            this.DataChange = DataChange;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string strUserName = TxtUserName.Text.Trim();
            SQLExcute excute = new SQLExcute();

            if (strUserName.Equals(this.strUserName))
            {
                MessageBox.Show("不可以删除自己!", 
                    "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            DialogResult isExit = MessageBox.Show("真的要删除这行数据吗?", 
                "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (isExit.Equals(DialogResult.Yes))
            {
                if (excute.DeleteUserInfo(strUserName))
                {
                    MessageBox.Show("删除成功!", 
                        "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                else
                {
                    MessageBox.Show("删除失败!",
                        "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void FormDelete_FormClosed(object sender, FormClosedEventArgs e)
        {
            SQLExcute excute = new SQLExcute();
            DataChange.ChangeDataGridView(excute.GetAllUserInfo().Tables[0]);
        }
    }
}
