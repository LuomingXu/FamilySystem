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
    public partial class FormCardManager : Form,INterface
    {
        public FormCardManager()
        {
            InitializeComponent();
        }

        private string strUserName = string.Empty;
        private string strSelectedCardNumber = string.Empty;

        public FormCardManager(string strUserName)
        {
            InitializeComponent();
            this.strUserName = strUserName;
        }

        public void ChangeDataGridView(DataTable dt)
        {
            dataGridView1.DataSource = dt;
        }

        FormInsertCardInfo FrmInserCardInfo = null;
        FormModifyCardPWD FrmModifyCardPWD = new FormModifyCardPWD();
        FormModifyWhoHoldCard FrmModifyHoldPerson = new FormModifyWhoHoldCard();

        SQLExcute excute = new SQLExcute();

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                menuStripSearch.PerformClick();
            }
        }

        private void FormCardManager_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = excute.GetAllCardInfo();
            toolStripTextBox1.Text = "请在此输入查询卡号...";
        }

        private void menuStripInsert_Click(object sender, EventArgs e)
        {
            if (FrmInserCardInfo == null)
            {
                FrmInserCardInfo = new FormInsertCardInfo(this,strUserName,this.MdiParent);
                FrmInserCardInfo.Show();
            }
            else
            {
                if (FrmInserCardInfo.IsDisposed == true)
                {
                    FrmInserCardInfo = new FormInsertCardInfo(this,strUserName,this.MdiParent);
                    FrmInserCardInfo.Show();
                }
                else
                {
                    FrmInserCardInfo.Activate();
                }
            }
        }

        private void menuStripSearch_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text.Trim().Equals("all"))
            {
                dataGridView1.DataSource = excute.GetAllCardInfo();
                return;
            }
            dataGridView1.DataSource = excute.GetCardInfoByNumber(toolStripTextBox1.Text.Trim());
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.SelectAll();
        }

        private void toolStripTextBox1_Leave(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text.Equals(string.Empty))
            {
                toolStripTextBox1.Text = "请在此输入查询卡号...";
            }
        }

        private void cmsBtnModifyPWD_Click(object sender, EventArgs e)
        {
            FrmModifyCardPWD.Close();
            FrmModifyHoldPerson.Close();
            FrmModifyCardPWD = new FormModifyCardPWD(strSelectedCardNumber, this.MdiParent);
            FrmModifyCardPWD.Show();
        }

        private void cmsBtnModifyWhoHoldCard_Click(object sender, EventArgs e)
        {
            FrmModifyHoldPerson.Close();
            FrmModifyCardPWD.Close();
            FrmModifyHoldPerson = new FormModifyWhoHoldCard(this,strSelectedCardNumber, this.MdiParent);
            FrmModifyHoldPerson.Show();
        }

        private void cmsBtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult ret;
            ret = MessageBox.Show("确定删除\"" + strSelectedCardNumber + "\"的信息吗??", 
                "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (ret.Equals(DialogResult.Yes))
            {
                if (excute.DeleteCardInfo(strSelectedCardNumber))
                {
                    MessageBox.Show("成功删除\""+strSelectedCardNumber+"\"的信息",
                   "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridView1.DataSource = excute.GetAllCardInfo();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strTemp = string.Empty;
            //左键点击, 选择一行数据
            if (e.RowIndex > -1)
            {
                strSelectedCardNumber = Convert.ToString(dataGridView1.CurrentRow.Cells["CardNumber"].Value);
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                strSelectedCardNumber = Convert.ToString(dataGridView1.CurrentRow.Cells["CardNumber"].Value);
            }
        }

        
    }
}
