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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;

namespace product_management_system.PL
{
    public partial class Form_product_show : Form
    {
        BL.Cls_product pro = new BL.Cls_product();
        public Form_product_show()
        {
        
            InitializeComponent();
            this.dataGridView1.DataSource = pro.GET_all_product_info();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            // add  product
            PL.Form_add_product show = new PL.Form_add_product();
            show.ShowDialog();
            this.dataGridView1.DataSource = pro.GET_all_product_info(); //make refresh to data  //video 23(el badel)
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = pro.search_product(searchbox.Text);
            this.dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delete product
            if (MessageBox.Show("هل تريد حذف المنتج المحدد؟", "عملية الحذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                pro.delete_product(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                this.dataGridView1.DataSource = pro.GET_all_product_info(); //make refresh to data 
            }
            else 
            {
                MessageBox.Show("تم إلغاءالحذف", "عملية الحذف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_add_product frm = new Form_add_product();
            frm.IDtxt.Text =this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.Destext.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.qtytext.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.pricetext.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.get_cat.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = "تحديث المنتج :" + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btlogin.Text = "تحديث";
            frm.state = "update";
            frm.IDtxt.ReadOnly = true;
            byte[] image = (byte[])pro.get_image(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);


            frm.ShowDialog();

            this.dataGridView1.DataSource = pro.GET_all_product_info(); //make refresh to data 
        }

        private void Form_product_show_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            review frm = new review();
            byte[] image = (byte[])pro.get_image(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0]; // idex of array of byte that contain data table
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox_review.Image = Image.FromStream(ms);
            frm.ShowDialog();

        }//this btn to show the picture of the product

        private void button6_Click(object sender, EventArgs e)//vedio 25 (procedure)
        {
            //bya5od el ID bta3 el row ely ana wa2ef 3ndo w yb3ato lel procedure ely fel first_rpt
            report.first_report myreport = new report.first_report();
            myreport.SetParameterValue("@ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //bya5od el first_rpt  w y7oto fel frm_rpt w b3den y3mlo show
            report.frm_rpt myform = new report.frm_rpt();
            myform.crystalReportViewer1.ReportSource = myreport;
            myform.ShowDialog();

        }//this btn shows the report طباعة المنتج المحدد 
        //form wa7da lkol el reports
        private void button7_Click(object sender, EventArgs e) //vedio 26 (table)
        {
            //bya5od el report w y7oto fel form w y3mlo show 
            report.rpt_all_products myreport = new report.rpt_all_products();
            report.frm_rpt myform = new report.frm_rpt();
            myform.crystalReportViewer1.ReportSource = myreport;
            myform.ShowDialog();

        }//this btn shows the report طباعة كل المنتجات 

        private void button8_Click(object sender, EventArgs e) //video 27
        {
            report.rpt_all_products myreport = new report.rpt_all_products();

            //create export option
            ExportOptions export = new ExportOptions();

            //create option for destination
            DiskFileDestinationOptions dfoption = new DiskFileDestinationOptions();
            ExcelFormatOptions excelformat = new ExcelFormatOptions();
           
            //set the path of destination
            dfoption.DiskFileName = @"E:\product.xls";

            export = myreport.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.Excel;
            export.ExportFormatOptions = excelformat;
            export.ExportDestinationOptions = dfoption;

            myreport.Export();

            MessageBox.Show("(E:\\products.xls) تم نقل جميع البيانات الى الملف","نقل البيانات",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }//btn حفظ القائمه في ملف اكسيل
    }
}

//1)

//2)data grid view
// autoSizeColumn -->fill
// selectonmode--->fill row select
