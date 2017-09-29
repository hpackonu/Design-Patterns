namespace FactoryPattern
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
            this.btnNote8 = new System.Windows.Forms.Button();
            this.btniPhone7 = new System.Windows.Forms.Button();
            this.btnPriv = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.Label();
            this.lbPhoneInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNote8
            // 
            this.btnNote8.Location = new System.Drawing.Point(13, 13);
            this.btnNote8.Name = "btnNote8";
            this.btnNote8.Size = new System.Drawing.Size(75, 23);
            this.btnNote8.TabIndex = 0;
            this.btnNote8.Text = " Note8";
            this.btnNote8.UseVisualStyleBackColor = true;
            this.btnNote8.Click += new System.EventHandler(this.btnNote8_Click);
            // 
            // btniPhone7
            // 
            this.btniPhone7.Location = new System.Drawing.Point(13, 43);
            this.btniPhone7.Name = "btniPhone7";
            this.btniPhone7.Size = new System.Drawing.Size(75, 23);
            this.btniPhone7.TabIndex = 1;
            this.btniPhone7.Text = "iPhone 7";
            this.btniPhone7.UseVisualStyleBackColor = true;
            this.btniPhone7.Click += new System.EventHandler(this.btniPhone7_Click);
            // 
            // btnPriv
            // 
            this.btnPriv.Location = new System.Drawing.Point(13, 73);
            this.btnPriv.Name = "btnPriv";
            this.btnPriv.Size = new System.Drawing.Size(75, 23);
            this.btnPriv.TabIndex = 2;
            this.btnPriv.Text = "Priv";
            this.btnPriv.UseVisualStyleBackColor = true;
            this.btnPriv.Click += new System.EventHandler(this.btnPriv_Click);
            // 
            // lbResults
            // 
            this.lbResults.AutoSize = true;
            this.lbResults.Location = new System.Drawing.Point(94, 26);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(0, 13);
            this.lbResults.TabIndex = 3;
            // 
            // lbPhoneInformation
            // 
            this.lbPhoneInformation.AutoSize = true;
            this.lbPhoneInformation.Location = new System.Drawing.Point(95, 13);
            this.lbPhoneInformation.Name = "lbPhoneInformation";
            this.lbPhoneInformation.Size = new System.Drawing.Size(96, 13);
            this.lbPhoneInformation.TabIndex = 4;
            this.lbPhoneInformation.Text = "Phone Information:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 105);
            this.Controls.Add(this.lbPhoneInformation);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnPriv);
            this.Controls.Add(this.btniPhone7);
            this.Controls.Add(this.btnNote8);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "What\'s a Phone?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNote8;
        private System.Windows.Forms.Button btniPhone7;
        private System.Windows.Forms.Button btnPriv;
        private System.Windows.Forms.Label lbResults;
        private System.Windows.Forms.Label lbPhoneInformation;
    }
}

