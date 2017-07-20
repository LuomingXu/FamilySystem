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
    public partial class FormModifyWhoHoldCard : Form
    {
        public FormModifyWhoHoldCard()
        {
            InitializeComponent();
        }

        private INterface DataChange;

        /// <summary>
        /// 全form保存的卡号
        /// </summary>
        string strCardNumber = string.Empty;

        SQLExcute excute = new SQLExcute();

        public FormModifyWhoHoldCard(INterface DataChange,string strCardNumber,Form main)
        {
            InitializeComponent();
            this.strCardNumber = strCardNumber;
            LblCardNumber.Text = strCardNumber;

            this.DataChange = DataChange;
            this.MdiParent = main;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtWhoHoldCardNow.Text = string.Empty;

            TxtWhoHoldCardNow.Focus();
        }

        private void FormModifyWhoHoldCard_Load(object sender, EventArgs e)
        {
            LblWhoHoldCardBefore.Text = excute.GetWhoHoldCard(strCardNumber);
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (TxtWhoHoldCardNow.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("没有输入!", 
                    "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            string strHoldCardNow = TxtWhoHoldCardNow.Text.Trim();

            if (excute.UpdateWhoHoldCard(strCardNumber, strHoldCardNow))
            {
                MessageBox.Show("更新成功!!",
                    "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            else
            {
                MessageBox.Show("更新失败!!",
                     "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormModifyWhoHoldCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataChange.ChangeDataGridView(excute.GetAllCardInfo());
        }
    }
}
