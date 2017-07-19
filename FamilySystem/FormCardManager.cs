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
    public partial class FormCardManager : Form
    {
        public FormCardManager()
        {
            InitializeComponent();
        }

        private string strUserName = string.Empty;

        public FormCardManager(string strUserName)
        {
            InitializeComponent();
            this.strUserName = strUserName;
        }

        FormInsertCardInfo FrmInserCardInfo = null;

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
                FrmInserCardInfo = new FormInsertCardInfo(strUserName,this.MdiParent);
                FrmInserCardInfo.Show();
            }
            else
            {
                if (FrmInserCardInfo.IsDisposed == true)
                {
                    FrmInserCardInfo = new FormInsertCardInfo(strUserName,this.MdiParent);
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
    }
}
