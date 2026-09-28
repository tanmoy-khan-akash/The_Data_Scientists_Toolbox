using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace product_management_system.PL
{
    public partial class Form_add_product : Form
    {
        BL.Cls_product pro = new BL.Cls_product();
        public string state = "add";
        public Form_add_product()
        {
            InitializeComponent();
            get_cat.DataSource = pro.GET_all_categories();
           get_cat.DisplayMember = "Description_cat";
            get_cat.ValueMember = "Cat_id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images |*.JPG; *.PNG; *.GIF; *.PMD";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void get_cat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);

                byte[] imagebyte = ms.ToArray();
                pro.add_product(IDtxt.Text, Destext.Text, Convert.ToInt32(qtytext.Text), pricetext.Text, imagebyte, Convert.ToInt32(get_cat.SelectedValue));
                MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else 
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);

                byte[] imagebyte = ms.ToArray();
                pro.update_product(IDtxt.Text, Destext.Text, Convert.ToInt32(qtytext.Text), pricetext.Text, imagebyte, Convert.ToInt32(get_cat.SelectedValue));
                MessageBox.Show("تم التحديث بنجاح", "عمليةالتحديث ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
        }

        private void Form_add_product_Load(object sender, EventArgs e)
        {

        }

        private void IDtxt_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable Dt = new DataTable();
                Dt = pro.verify_product(IDtxt.Text);
                if (Dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا المنتج موجود مسبقا", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IDtxt.Focus(); //this to prevent going to another textbox
                    IDtxt.SelectionStart = 0;
                    IDtxt.SelectionLength = IDtxt.TextLength; // to make shadow from the begin of the word to the end
                }//end_of_if

            }//end _of_if
        }// event validated :this event will be achieved when user out from this textbox 

        private void btcancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IDtxt_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
