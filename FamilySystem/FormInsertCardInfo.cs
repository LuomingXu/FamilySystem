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
using CardInfo;
using PasswordSecurity;

namespace FamilySystem
{
    public partial class FormInsertCardInfo : Form
    {
        public FormInsertCardInfo()
        {
            InitializeComponent();
        }

        private INterface DataChange;

        public FormInsertCardInfo(INterface DataChange,string strUserName, Form main)
        {
            InitializeComponent();
            this.strUserName = strUserName;
            this.MdiParent = main;
            this.DataChange = DataChange;
        }
        
        /// <summary>
        /// 全局的用户名
        /// </summary>
        private string strUserName = string.Empty;

        /// <summary>
        /// 全局的excute
        /// </summary>
        private SQLExcute excute = new SQLExcute();

        /// <summary>
        /// 全局的card类
        /// </summary>
        private Card card = new Card();

        private void FormInsertCardInfo_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = excute.GetBankName();

            for (int i = 0; i < dt.DefaultView.Count; i++)
            {
                CmbBankName.Items.Add(Convert.ToString(dt.Rows[i][0]));
            }
            CmbBankName.SelectedIndex = 0;

            LblWhoCreatCard.Text = strUserName;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (TxtCardName.Equals(string.Empty) || TxtCardPWD.Equals(string.Empty) || TxtWhoHoldCard.Equals(string.Empty))
            {
                MessageBox.Show("您有信息没有输入", 
                    "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            card.CardName = TxtCardName.Text.Trim();
            card.CardPWD = PasswordStorage.CreateHash(TxtCardPWD.Text.Trim());
            card.WhoHoldCard = TxtWhoHoldCard.Text.Trim();
            card.WhoCreatCard = LblWhoCreatCard.Text.Trim();
            card.Balance = Convert.ToDouble(TxtBalance.Text.Trim());
            card.BankName = CmbBankName.SelectedItem.ToString();

            if (excute.InsertCardInfo(card))
            {
                MessageBox.Show("添加存储卡信息成功!", 
                    "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            else
            {
                MessageBox.Show("添加存储卡信息失败!",
                    "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtBalance.Text = string.Empty;
            TxtCardName.Text = string.Empty;
            TxtCardPWD.Text = string.Empty;
            TxtWhoHoldCard.Text = string.Empty;

            CmbBankName.SelectedIndex = 0;

            TxtCardName.Focus();
        }

        private void TxtCardName_TextChanged(object sender, EventArgs e)
        {
            if (excute.ConfirmTheOnlyCardNumber(TxtCardName.Text.Trim()))
            {
                LblConfirmCardNumber.Text = "存在的存储卡号!";
                LblConfirmCardNumber.ForeColor = Color.Red;
                LblConfirmCardNumber.Visible = true;
                BtnConfirm.Enabled = false;
            }
            else
            {
                LblConfirmCardNumber.Text = "可用的存储卡号.";
                LblConfirmCardNumber.ForeColor = Color.Green;
                LblConfirmCardNumber.Visible = true;
                BtnConfirm.Enabled = true;
            }
        }

        private void FormInsertCardInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataChange.ChangeDataGridView(excute.GetAllCardInfo());
        }
    }
}
