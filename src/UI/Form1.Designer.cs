namespace UI
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
            this.lblWatchedDir = new System.Windows.Forms.Label();
            this.txtBoxWatchedDir = new System.Windows.Forms.TextBox();
            this.btnWatchedDir = new System.Windows.Forms.Button();
            this.btnStartWatch = new System.Windows.Forms.Button();
            this.btnStopWatch = new System.Windows.Forms.Button();
            this.btnDestDir = new System.Windows.Forms.Button();
            this.txtDestDir = new System.Windows.Forms.TextBox();
            this.lblDestDir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWatchedDir
            // 
            this.lblWatchedDir.AutoSize = true;
            this.lblWatchedDir.Location = new System.Drawing.Point(12, 9);
            this.lblWatchedDir.Name = "lblWatchedDir";
            this.lblWatchedDir.Size = new System.Drawing.Size(96, 13);
            this.lblWatchedDir.TabIndex = 0;
            this.lblWatchedDir.Text = "Watched Directory";
            // 
            // txtBoxWatchedDir
            // 
            this.txtBoxWatchedDir.Enabled = false;
            this.txtBoxWatchedDir.Location = new System.Drawing.Point(8, 25);
            this.txtBoxWatchedDir.Name = "txtBoxWatchedDir";
            this.txtBoxWatchedDir.Size = new System.Drawing.Size(361, 20);
            this.txtBoxWatchedDir.TabIndex = 1;
            // 
            // btnWatchedDir
            // 
            this.btnWatchedDir.Location = new System.Drawing.Point(388, 22);
            this.btnWatchedDir.Name = "btnWatchedDir";
            this.btnWatchedDir.Size = new System.Drawing.Size(180, 23);
            this.btnWatchedDir.TabIndex = 2;
            this.btnWatchedDir.Text = "Select Watched Directory";
            this.btnWatchedDir.UseVisualStyleBackColor = true;
            this.btnWatchedDir.Click += new System.EventHandler(this.btnWatchedDir_Click);
            // 
            // btnStartWatch
            // 
            this.btnStartWatch.Enabled = false;
            this.btnStartWatch.Location = new System.Drawing.Point(15, 159);
            this.btnStartWatch.Name = "btnStartWatch";
            this.btnStartWatch.Size = new System.Drawing.Size(145, 39);
            this.btnStartWatch.TabIndex = 3;
            this.btnStartWatch.Text = "Start Watch";
            this.btnStartWatch.UseVisualStyleBackColor = true;
            this.btnStartWatch.Click += new System.EventHandler(this.btnStartWatch_Click);
            // 
            // btnStopWatch
            // 
            this.btnStopWatch.Enabled = false;
            this.btnStopWatch.Location = new System.Drawing.Point(388, 159);
            this.btnStopWatch.Name = "btnStopWatch";
            this.btnStopWatch.Size = new System.Drawing.Size(145, 39);
            this.btnStopWatch.TabIndex = 4;
            this.btnStopWatch.Text = "Stop Watch";
            this.btnStopWatch.UseVisualStyleBackColor = true;
            this.btnStopWatch.Click += new System.EventHandler(this.btnStopWatch_Click);
            // 
            // btnDestDir
            // 
            this.btnDestDir.Location = new System.Drawing.Point(388, 71);
            this.btnDestDir.Name = "btnDestDir";
            this.btnDestDir.Size = new System.Drawing.Size(180, 23);
            this.btnDestDir.TabIndex = 7;
            this.btnDestDir.Text = "Select Watched Directory";
            this.btnDestDir.UseVisualStyleBackColor = true;
            this.btnDestDir.Click += new System.EventHandler(this.btnDestDir_Click);
            // 
            // txtDestDir
            // 
            this.txtDestDir.Enabled = false;
            this.txtDestDir.Location = new System.Drawing.Point(8, 74);
            this.txtDestDir.Name = "txtDestDir";
            this.txtDestDir.Size = new System.Drawing.Size(361, 20);
            this.txtDestDir.TabIndex = 6;
            // 
            // lblDestDir
            // 
            this.lblDestDir.AutoSize = true;
            this.lblDestDir.Location = new System.Drawing.Point(12, 58);
            this.lblDestDir.Name = "lblDestDir";
            this.lblDestDir.Size = new System.Drawing.Size(105, 13);
            this.lblDestDir.TabIndex = 5;
            this.lblDestDir.Text = "Destination Directory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 309);
            this.Controls.Add(this.btnDestDir);
            this.Controls.Add(this.txtDestDir);
            this.Controls.Add(this.lblDestDir);
            this.Controls.Add(this.btnStopWatch);
            this.Controls.Add(this.btnStartWatch);
            this.Controls.Add(this.btnWatchedDir);
            this.Controls.Add(this.txtBoxWatchedDir);
            this.Controls.Add(this.lblWatchedDir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWatchedDir;
        private System.Windows.Forms.TextBox txtBoxWatchedDir;
        private System.Windows.Forms.Button btnWatchedDir;
        private System.Windows.Forms.Button btnStartWatch;
        private System.Windows.Forms.Button btnStopWatch;
        private System.Windows.Forms.Button btnDestDir;
        private System.Windows.Forms.TextBox txtDestDir;
        private System.Windows.Forms.Label lblDestDir;
    }
}

