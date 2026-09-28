namespace product_management_system.PL
{
    partial class Form_add_product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_add_product));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Destext = new System.Windows.Forms.TextBox();
            this.pricetext = new System.Windows.Forms.TextBox();
            this.qtytext = new System.Windows.Forms.TextBox();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.get_cat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btlogin);
            this.groupBox1.Controls.Add(this.btcancel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Destext);
            this.groupBox1.Controls.Add(this.pricetext);
            this.groupBox1.Controls.Add(this.qtytext);
            this.groupBox1.Controls.Add(this.IDtxt);
            this.groupBox1.Controls.Add(this.get_cat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(447, 487);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المنتج :";
            // 
            // btlogin
            // 
            this.btlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btlogin.Location = new System.Drawing.Point(41, 452);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(59, 29);
            this.btlogin.TabIndex = 5;
            this.btlogin.Text = "موافق";
            this.btlogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // btcancel
            // 
            this.btcancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btcancel.ImageKey = "(none)";
            this.btcancel.Location = new System.Drawing.Point(119, 452);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(60, 29);
            this.btcancel.TabIndex = 6;
            this.btcancel.Text = "إلغاء";
            this.btcancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "اختيار الصورة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Destext
            // 
            this.Destext.Location = new System.Drawing.Point(41, 118);
            this.Destext.Multiline = true;
            this.Destext.Name = "Destext";
            this.Destext.Size = new System.Drawing.Size(272, 52);
            this.Destext.TabIndex = 1;
            // 
            // pricetext
            // 
            this.pricetext.Location = new System.Drawing.Point(41, 234);
            this.pricetext.Name = "pricetext";
            this.pricetext.Size = new System.Drawing.Size(272, 20);
            this.pricetext.TabIndex = 3;
            // 
            // qtytext
            // 
            this.qtytext.Location = new System.Drawing.Point(41, 190);
            this.qtytext.Name = "qtytext";
            this.qtytext.Size = new System.Drawing.Size(272, 20);
            this.qtytext.TabIndex = 2;
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(41, 78);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(272, 20);
            this.IDtxt.TabIndex = 0;
            this.IDtxt.TextChanged += new System.EventHandler(this.IDtxt_TextChanged);
            this.IDtxt.Validated += new System.EventHandler(this.IDtxt_Validated);
            // 
            // get_cat
            // 
            this.get_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.get_cat.FormattingEnabled = true;
            this.get_cat.Location = new System.Drawing.Point(41, 42);
            this.get_cat.Name = "get_cat";
            this.get_cat.Size = new System.Drawing.Size(272, 21);
            this.get_cat.TabIndex = 6;
            this.get_cat.SelectedIndexChanged += new System.EventHandler(this.get_cat_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "صورة المنتج :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "السعر :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "الكمية :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "وصف المنتج :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "الكود :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "الصنف :  ";
            // 
            // Form_add_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 511);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_add_product";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة منتج جديد";
            this.Load += new System.EventHandler(this.Form_add_product_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btcancel;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox Destext;
        public System.Windows.Forms.TextBox pricetext;
        public System.Windows.Forms.TextBox qtytext;
        public System.Windows.Forms.TextBox IDtxt;
        public System.Windows.Forms.ComboBox get_cat;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btlogin;
    }
}