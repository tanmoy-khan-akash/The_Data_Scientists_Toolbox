namespace product_management_system.PL
{
    partial class review
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
            this.pictureBox_review = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_review)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_review
            // 
            this.pictureBox_review.Location = new System.Drawing.Point(5, 5);
            this.pictureBox_review.Name = "pictureBox_review";
            this.pictureBox_review.Size = new System.Drawing.Size(429, 299);
            this.pictureBox_review.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_review.TabIndex = 0;
            this.pictureBox_review.TabStop = false;
            this.pictureBox_review.Click += new System.EventHandler(this.pictureBox_review_Click);
            // 
            // review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 304);
            this.Controls.Add(this.pictureBox_review);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "review";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صورة المنتج";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_review)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox_review;
    }
}