
namespace _2001216316_PhanNgocbaoVinh_Buoi3
{
    partial class timechay
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
            this.timer1 = new Timer.Timer();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.flag = 0;
            this.timer1.Location = new System.Drawing.Point(127, 61);
            this.timer1.Name = "timer1";
            this.timer1.Size = new System.Drawing.Size(484, 230);
            this.timer1.TabIndex = 0;
            // 
            // timechay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timer1);
            this.Name = "timechay";
            this.Text = "timechay";
            this.ResumeLayout(false);

        }

        #endregion

        private Timer.Timer timer1;
    }
}