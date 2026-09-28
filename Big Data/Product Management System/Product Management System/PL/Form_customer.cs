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
    public partial class Form_customer : Form
    {
        BL.Cls_Customers cust = new BL.Cls_Customers();
        int id;
        public Form_customer()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = cust.get_all_customers();
            dataGridView1.Columns[0].Visible = false;
            btn_save.Enabled = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل فعلا تريد حذف هذا العميل ؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cust.DELETE_CUSTOMER(id);
                MessageBox.Show("تم الحذف", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = cust.get_all_customers();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();

            }
            else
                return;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            textBox6.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                cust.ADD_CUSTOMER(textBox6.Text, textBox5.Text, textBox4.Text, textBox3.Text);
                MessageBox.Show("تمت الاضافه بنجاح", "اضافة عميل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = cust.get_all_customers();
                btn_add.Enabled = true;
                btn_save.Enabled = false;
            }
            catch
            {
                return;
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                textBox5.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save.Focus();
                btn_save.Enabled = true;
            }
        }

        private void Form_customer_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                this.textBox6.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.textBox5.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
            }
            catch
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cust.EDIT_CUSTOMER(textBox6.Text, textBox5.Text, textBox4.Text, textBox3.Text, id);
                MessageBox.Show("تمت التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = cust.get_all_customers();
                
            }
            catch
            {
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cust.search_customer(textBox1.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button7_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button7_Click(sender, e);
            }
        }
        
    }
}
