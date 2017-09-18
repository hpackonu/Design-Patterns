namespace FacadeBand
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.BreakBtn = new System.Windows.Forms.Button();
            this.EndBtn = new System.Windows.Forms.Button();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(13, 13);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // BreakBtn
            // 
            this.BreakBtn.Location = new System.Drawing.Point(13, 42);
            this.BreakBtn.Name = "BreakBtn";
            this.BreakBtn.Size = new System.Drawing.Size(75, 23);
            this.BreakBtn.TabIndex = 1;
            this.BreakBtn.Text = "Break";
            this.BreakBtn.UseVisualStyleBackColor = true;
            this.BreakBtn.Click += new System.EventHandler(this.BreakBtn_Click);
            // 
            // EndBtn
            // 
            this.EndBtn.Location = new System.Drawing.Point(13, 71);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(75, 23);
            this.EndBtn.TabIndex = 2;
            this.EndBtn.Text = "End";
            this.EndBtn.UseVisualStyleBackColor = true;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Location = new System.Drawing.Point(94, 18);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(93, 13);
            this.ResultsLabel.TabIndex = 7;
            this.ResultsLabel.Text = "Replaced In Code";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 109);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.EndBtn);
            this.Controls.Add(this.BreakBtn);
            this.Controls.Add(this.StartBtn);
            this.Name = "Form1";
            this.Text = "Setab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button BreakBtn;
        private System.Windows.Forms.Button EndBtn;
        public System.Windows.Forms.Label ResultsLabel;
    }
}

