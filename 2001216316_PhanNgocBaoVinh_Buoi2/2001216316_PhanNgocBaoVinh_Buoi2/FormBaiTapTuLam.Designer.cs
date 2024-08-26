namespace _2001216316_PhanNgocBaoVinh_Buoi2
{
    partial class FormBaiTapTuLam
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox1 = new CustomControl.PasswordTextBox();
            this.userTextBoxNonCharacter1 = new CustomControl.UserTextBoxNonCharacter();
            this.mailTextBox1 = new CustomControl.MailTextBox();
            this.upperTextBox1 = new CustomControl.UpperTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UppercaseTextBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "txNonChareacter";
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.Location = new System.Drawing.Point(259, 147);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox1.TabIndex = 6;
            // 
            // userTextBoxNonCharacter1
            // 
            this.userTextBoxNonCharacter1.Location = new System.Drawing.Point(259, 77);
            this.userTextBoxNonCharacter1.Name = "userTextBoxNonCharacter1";
            this.userTextBoxNonCharacter1.Size = new System.Drawing.Size(100, 20);
            this.userTextBoxNonCharacter1.TabIndex = 4;
            // 
            // mailTextBox1
            // 
            this.mailTextBox1.Location = new System.Drawing.Point(43, 148);
            this.mailTextBox1.Name = "mailTextBox1";
            this.mailTextBox1.Size = new System.Drawing.Size(100, 20);
            this.mailTextBox1.TabIndex = 2;
            // 
            // upperTextBox1
            // 
            this.upperTextBox1.Location = new System.Drawing.Point(56, 77);
            this.upperTextBox1.Name = "upperTextBox1";
            this.upperTextBox1.Size = new System.Drawing.Size(100, 20);
            this.upperTextBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(460, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // FormBaiTapTuLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 296);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.passwordTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userTextBoxNonCharacter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mailTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upperTextBox1);
            this.Name = "FormBaiTapTuLam";
            this.Text = "FormBaiTapTuLam";
            this.Load += new System.EventHandler(this.FormBaiTapTuLam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.UpperTextBox upperTextBox1;
        private System.Windows.Forms.Label label1;
        private CustomControl.MailTextBox mailTextBox1;
        private System.Windows.Forms.Label label2;
        private CustomControl.UserTextBoxNonCharacter userTextBoxNonCharacter1;
        private System.Windows.Forms.Label label3;
        private CustomControl.PasswordTextBox passwordTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}