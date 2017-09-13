namespace IteratorPhone
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
            this.cbVerizon = new System.Windows.Forms.CheckBox();
            this.gbCarriers = new System.Windows.Forms.GroupBox();
            this.cbTMobile = new System.Windows.Forms.CheckBox();
            this.cbSprint = new System.Windows.Forms.CheckBox();
            this.cbATNT = new System.Windows.Forms.CheckBox();
            this.lbTotalIterated = new System.Windows.Forms.ListBox();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.labelResults = new System.Windows.Forms.Label();
            this.gbCarriers.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbVerizon
            // 
            this.cbVerizon.AutoSize = true;
            this.cbVerizon.Location = new System.Drawing.Point(6, 19);
            this.cbVerizon.Name = "cbVerizon";
            this.cbVerizon.Size = new System.Drawing.Size(61, 17);
            this.cbVerizon.TabIndex = 0;
            this.cbVerizon.Text = "Verizon";
            this.cbVerizon.UseVisualStyleBackColor = true;
            this.cbVerizon.CheckedChanged += new System.EventHandler(this.cbVerizon_CheckedChanged);
            // 
            // gbCarriers
            // 
            this.gbCarriers.Controls.Add(this.cbTMobile);
            this.gbCarriers.Controls.Add(this.cbSprint);
            this.gbCarriers.Controls.Add(this.cbATNT);
            this.gbCarriers.Controls.Add(this.cbVerizon);
            this.gbCarriers.Location = new System.Drawing.Point(12, 12);
            this.gbCarriers.Name = "gbCarriers";
            this.gbCarriers.Size = new System.Drawing.Size(109, 111);
            this.gbCarriers.TabIndex = 1;
            this.gbCarriers.TabStop = false;
            this.gbCarriers.Text = "Carrier(s)";
            // 
            // cbTMobile
            // 
            this.cbTMobile.AutoSize = true;
            this.cbTMobile.Location = new System.Drawing.Point(6, 88);
            this.cbTMobile.Name = "cbTMobile";
            this.cbTMobile.Size = new System.Drawing.Size(67, 17);
            this.cbTMobile.TabIndex = 3;
            this.cbTMobile.Text = "T-Moblie";
            this.cbTMobile.UseVisualStyleBackColor = true;
            this.cbTMobile.CheckedChanged += new System.EventHandler(this.cbTMobile_CheckedChanged);
            // 
            // cbSprint
            // 
            this.cbSprint.AutoSize = true;
            this.cbSprint.Location = new System.Drawing.Point(6, 65);
            this.cbSprint.Name = "cbSprint";
            this.cbSprint.Size = new System.Drawing.Size(53, 17);
            this.cbSprint.TabIndex = 2;
            this.cbSprint.Text = "Sprint";
            this.cbSprint.UseVisualStyleBackColor = true;
            this.cbSprint.CheckedChanged += new System.EventHandler(this.cbSprint_CheckedChanged);
            // 
            // cbATNT
            // 
            this.cbATNT.AutoSize = true;
            this.cbATNT.Location = new System.Drawing.Point(6, 42);
            this.cbATNT.Name = "cbATNT";
            this.cbATNT.Size = new System.Drawing.Size(53, 17);
            this.cbATNT.TabIndex = 1;
            this.cbATNT.Text = "AT&&T";
            this.cbATNT.UseVisualStyleBackColor = true;
            this.cbATNT.CheckedChanged += new System.EventHandler(this.cbATNT_CheckedChanged);
            // 
            // lbTotalIterated
            // 
            this.lbTotalIterated.FormattingEnabled = true;
            this.lbTotalIterated.Location = new System.Drawing.Point(18, 130);
            this.lbTotalIterated.Name = "lbTotalIterated";
            this.lbTotalIterated.Size = new System.Drawing.Size(103, 121);
            this.lbTotalIterated.TabIndex = 2;
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(169, 37);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(103, 212);
            this.lbResults.TabIndex = 3;
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(166, 12);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(45, 13);
            this.labelResults.TabIndex = 4;
            this.labelResults.Text = "Results:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.lbTotalIterated);
            this.Controls.Add(this.gbCarriers);
            this.Name = "Form1";
            this.Text = "Phone Iterator";
            this.gbCarriers.ResumeLayout(false);
            this.gbCarriers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbVerizon;
        private System.Windows.Forms.GroupBox gbCarriers;
        private System.Windows.Forms.CheckBox cbTMobile;
        private System.Windows.Forms.CheckBox cbSprint;
        private System.Windows.Forms.CheckBox cbATNT;
        private System.Windows.Forms.ListBox lbTotalIterated;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Label labelResults;
    }
}

