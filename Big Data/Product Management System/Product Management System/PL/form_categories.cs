using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
using System.Data.SqlClient;

namespace product_management_system.PL
{
    public partial class Form_categories : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Server =.\SQLEXPRESS; Database =product_DB; Integrated Security =true");
        SqlDataAdapter da;
        DataTable dt=new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
        public Form_categories()
        {
            InitializeComponent();
            da = new SqlDataAdapter(@"select cat_id as'الكود' , description_cat as 'الصنف' from categories", sqlcon);
            da.Fill(dt);
            dgList.DataSource = dt;
            txtID.DataBindings.Add("text", dt, "الكود");
            txtDescription.DataBindings.Add("text", dt, "الصنف");
            bmb = this.BindingContext[dt];
            lblPos.Text =( bmb.Position + 1 )+ "/" + bmb.Count;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)//vedio 31
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم اضافة الصنف بنجاح", "أضافة صنف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNew.Enabled = true;
            btnsave.Enabled = false;
            lblPos.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {//vedio 31
            bmb.AddNew();
            btnNew.Enabled = false;
            btnsave.Enabled = true;
            //
          // txtDescription.ReadOnly = false;
            //txtDescription.Enabled = true;
            //بس كدا لو اليوزر مسح حاجه من النص و جه يضيف هييف لرقم موجود
            //video 30
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            txtID.Text = id.ToString();
            txtDescription.Focus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            report.rpt_all_categories myreport = new report.rpt_all_categories();

            //create export option
            ExportOptions export = new ExportOptions();

            //create option for destination
            DiskFileDestinationOptions dfoption = new DiskFileDestinationOptions();

            PdfFormatOptions pdfFormat = new PdfFormatOptions();
            
            //set the path of destination
            dfoption.DiskFileName = @"E:\categories.pdf";

            export = myreport.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdfFormat;
            export.ExportDestinationOptions = dfoption;

            myreport.Refresh();
            myreport.Export();

            MessageBox.Show("(E:\\categories.pdf) تم نقل جميع البيانات الى الملف", "نقل البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
        

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void form_categories_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnLast_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم تعديل الصنف بنجاح", "تعديل صنف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            lblPos.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم حذف الصنف بنجاح", "حذف صنف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNew.Enabled = true;
            btnsave.Enabled = false;
            lblPos.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            report.rpt_all_categories rpt = new report.rpt_all_categories();
            report.frm_rpt frm = new report.frm_rpt();
            rpt.Refresh();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void btnPrintCurrent_Click(object sender, EventArgs e)//////////video 33
        {
            report.rpt_single_cat rpt = new report.rpt_single_cat();
            report.frm_rpt frm = new report.frm_rpt();
            rpt.SetParameterValue("@id", Convert.ToInt32(txtID.Text));
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void btnExportTopdf_Click(object sender, EventArgs e)
        {
            report.rpt_single_cat myreport = new report.rpt_single_cat();

            //create export option
            ExportOptions export = new ExportOptions();

            //create option for destination
            DiskFileDestinationOptions dfoption = new DiskFileDestinationOptions();

            PdfFormatOptions pdfFormat = new PdfFormatOptions();

            //set the path of destination
            dfoption.DiskFileName = @"E:\singleCategory.pdf";

            export = myreport.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdfFormat;
            export.ExportDestinationOptions = dfoption;

            myreport.SetParameterValue("@id", Convert.ToInt32(txtID.Text));

            myreport.Refresh();
            myreport.Export();

            MessageBox.Show("(E:\\singleCategory.pdf) تم نقل جميع البيانات الى الملف", "نقل البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void dgList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLast_Click_1(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblPos.Text = (bmb.Position + 1) + "/" + bmb.Count;
          //  lblPos.Text = (bmb.Position + 1) + "/" + Convert.ToString(dt.Rows[dt.Rows.Count - 1][0]);
        }

        private void dgList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click_1(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblPos.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lblPos.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lblPos.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }
    }
}
