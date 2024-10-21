namespace _2001216316_PhanNgocbaoVinh_Buoi3
{
    partial class Form1
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
            this.uC_DangNhap1 = new UC_DN.UC_DangNhap();
            this.SuspendLayout();
            // 
            // uC_DangNhap1
            // 
            this.uC_DangNhap1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_DangNhap1.Cnn = null;
            this.uC_DangNhap1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uC_DangNhap1.Flag = 0;
            this.uC_DangNhap1.Location = new System.Drawing.Point(81, 27);
            this.uC_DangNhap1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_DangNhap1.Name = "uC_DangNhap1";
            this.uC_DangNhap1.Size = new System.Drawing.Size(403, 286);
            this.uC_DangNhap1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 363);
            this.Controls.Add(this.uC_DangNhap1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_DN.UC_DangNhap uC_DangNhap1;


    }
}

