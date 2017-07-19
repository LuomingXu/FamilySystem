using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilySystem
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        FormUserInfo FrmUserInfo = null;
        FormAppInfo appInfo = null;

        private void systemManage_Click(object sender, EventArgs e)
        {
            if (FrmUserInfo == null)
            {
                FrmUserInfo = new FormUserInfo();
                string[] strTemp = toolStripStatusLabel1.Text.Trim().Split(':');
                FrmUserInfo.toolStripStatusLabel1.Text = "当前用户:" + strTemp[1].ToString();

                FrmUserInfo.MdiParent = this;
                FrmUserInfo.Show();
            }
            else
            {
                if (FrmUserInfo.IsDisposed == true)
                {
                    FrmUserInfo = new FormUserInfo();
                    string[] strTemp = toolStripStatusLabel1.Text.Trim().Split(':');
                    FrmUserInfo.toolStripStatusLabel1.Text = "当前用户:" + strTemp[1].ToString();

                    FrmUserInfo.MdiParent = this;
                    FrmUserInfo.Show();
                }
                else
                {
                    FrmUserInfo.Activate();
                }
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);         
        }

        private void CtmHelpItemAbout_Click(object sender, EventArgs e)
        {
            if (appInfo == null)
            {
                appInfo = new FormAppInfo();
                appInfo.MdiParent = this;
                appInfo.Show();
            }
            else
            {
                if (appInfo.IsDisposed == true)
                {
                    appInfo = new FormAppInfo();
                    appInfo.MdiParent = this;
                    appInfo.Show();
                }
                else
                {
                    appInfo.Activate();
                }           
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           
        }
    }
}
