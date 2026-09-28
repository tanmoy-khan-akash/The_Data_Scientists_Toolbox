using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace product_management_system.PL
{
    public partial class Form_login : Form
    {
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        public Form_login()
        {
            InitializeComponent();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            DataTable DT = log.login(txtID.Text,txtPWD.Text);
            if (DT.Rows.Count > 0)
            {
                Form_main.getmainform.استعادةنسخةToolStripMenuItem.Enabled = true;
                Form_main.getmainform.انشاءنسخةاحتياطيهToolStripMenuItem.Enabled = true;
                Form_main.getmainform.العملاءToolStripMenuItem.Enabled = true;
                Form_main.getmainform.المستخدمينToolStripMenuItem.Enabled = true;
                Form_main.getmainform.المنتجاتToolStripMenuItem.Enabled = true;
               
                this.Close();
            }

            else
            {
                MessageBox.Show("login failed !");
            }
        }
    }
}
