namespace Timer
{
    partial class Timer
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnLap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(148, 42);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(227, 39);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "00:00:00 000";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(89, 131);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(117, 61);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Start";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnLap
            // 
            this.btnLap.Location = new System.Drawing.Point(323, 130);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(135, 62);
            this.btnLap.TabIndex = 2;
            this.btnLap.Text = "Lap";
            this.btnLap.UseVisualStyleBackColor = true;
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLap);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblTimer);
            this.Name = "Timer";
            this.Size = new System.Drawing.Size(537, 284);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnLap;
    }
}
