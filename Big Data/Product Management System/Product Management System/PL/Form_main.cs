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
    public partial class Form_main : Form

    {
        private static Form_main frm;
        public static void frm_formclosed(object sender ,FormClosedEventArgs e)
        {
            frm = null;

        }
        public static  Form_main getmainform
        {
            get
            {
                if(frm == null)
                {
                    frm = new Form_main();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed); //msh fahm

                }//end_of_end
                return frm;
            }//end_of_get
        }
        public Form_main()
        {
            
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.استعادةنسخةToolStripMenuItem.Enabled = false;
            this.انشاءنسخةاحتياطيهToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمينToolStripMenuItem.Enabled = false;
            this.المنتجاتToolStripMenuItem.Enabled= false;
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
          
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_login frm = new Form_login();
            frm.ShowDialog();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void إدارةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_product_show show = new Form_product_show();
            show.ShowDialog();
        }

        private void إضافةمنتججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_add_product fap = new Form_add_product();
            fap.ShowDialog();

        }

        private void إدارةالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_categories frm = new Form_categories();
            frm.ShowDialog();
        }

        private void العملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void إدارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Form_customer cust = new Form_customer();
            cust.ShowDialog();
        }

        //private void إضافةصنفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}
    }
}
