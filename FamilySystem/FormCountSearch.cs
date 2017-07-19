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

namespace FamilySystem
{
    public partial class FormCountSearch : Form
    {
        public FormCountSearch()
        {
            InitializeComponent();
        }

        SQLExcute excute = new SQLExcute();

        /// <summary>
        /// 用来保存卡号
        /// </summary>
        string strCardNumber = string.Empty;
        /// <summary>
        /// 用来保存密码
        /// </summary>
        string strPWD = string.Empty;

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            double dbMoneySave = 0.0;
            double dbMoneyMinus = 0.0;
            string strMoneyChanged = TxtTransAmount.Text.Trim();
            double dbMoneyChanged = Convert.ToDouble(strMoneyChanged);
            double dbBalance = Convert.ToDouble(LblBalance.Text.Trim());

            if (RdbSave.Checked)
            {
                dbMoneySave = dbBalance + dbMoneyChanged;

                UpdateMoneyChange(dbMoneySave);
            }
            else if (RdbWithdraw.Checked)
            {
                if (dbBalance < dbMoneyChanged)
                {
                    MessageBox.Show("余额不足!", 
                        "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else
                {
                    dbMoneyMinus = dbBalance - dbMoneyChanged;

                    UpdateMoneyChange(dbMoneyMinus);
                }
            }
        }

        private void UpdateMoneyChange(double dbBalance)
        {
            if(excute.UpdateBalance(dbBalance,strCardNumber))
            {
                MessageBox.Show("修改余额成功!", 
                    "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LblBalance.Text = excute.GetBalanceByCardNumber(strCardNumber);
            }
            else
            {
                MessageBox.Show("修改余额失败!",
                     "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtCardNumber.Text = string.Empty;
            TxtPWD.Text = string.Empty;
            TxtTransAmount.Text = string.Empty;

            LblBalance.Text = "等待加载";
            LblBankName.Text = "等待加载";

            RdbSave.Checked = false;
            RdbWithdraw.Checked = false;
        }

        private void VertifyPWD()
        {
            string Hash = string.Empty;

            try
            {
                Hash = Convert.ToString(excute.IdentifyCard(strCardNumber).Rows[0][0]);
            }
            catch
            {
                return;
            }

            if (PasswordStorage.VerifyPassword(strPWD, Hash))
            {
                panel1.Enabled = true;
                ChangeLbl();
            }
            else
            {
                panel1.Enabled = false;
            }
        }

        private void TxtCardNumber_TextChanged(object sender, EventArgs e)
        {
            strCardNumber = TxtCardNumber.Text.Trim();

            VertifyPWD();
        }

        private void TxtPWD_TextChanged(object sender, EventArgs e)
        {
            strPWD = TxtPWD.Text.Trim();

            VertifyPWD();
        }

        private void TxtPWD_Leave(object sender, EventArgs e)
        {
            
        }

        private void ChangeLbl()
        {
            DataTable dt = new DataTable();
            dt = excute.GetCardInfoByNumber(strCardNumber);

            LblBankName.Text = Convert.ToString(dt.Rows[0]["BankName"]);
            LblBalance.Text = Convert.ToString(dt.Rows[0]["Balance"]);
        }

        private void FormCountSearch_Load(object sender, EventArgs e)
        {
            RdbSave.Checked = true;
        }
    }
}
