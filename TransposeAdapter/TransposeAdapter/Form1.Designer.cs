namespace TransposeAdapter
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
            this.cbStartInstrument = new System.Windows.Forms.ComboBox();
            this.cbEndInstrument = new System.Windows.Forms.ComboBox();
            this.cbNote = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbResultNote = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbStartInstrument
            // 
            this.cbStartInstrument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartInstrument.FormattingEnabled = true;
            this.cbStartInstrument.Items.AddRange(new object[] {
            "C"});
            this.cbStartInstrument.Location = new System.Drawing.Point(8, 41);
            this.cbStartInstrument.Name = "cbStartInstrument";
            this.cbStartInstrument.Size = new System.Drawing.Size(121, 21);
            this.cbStartInstrument.TabIndex = 1;
            // 
            // cbEndInstrument
            // 
            this.cbEndInstrument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEndInstrument.FormattingEnabled = true;
            this.cbEndInstrument.Items.AddRange(new object[] {
            "Bb"});
            this.cbEndInstrument.Location = new System.Drawing.Point(5, 90);
            this.cbEndInstrument.Name = "cbEndInstrument";
            this.cbEndInstrument.Size = new System.Drawing.Size(121, 21);
            this.cbEndInstrument.TabIndex = 3;
            // 
            // cbNote
            // 
            this.cbNote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNote.FormattingEnabled = true;
            this.cbNote.Items.AddRange(new object[] {
            "C",
            "F",
            "Bb",
            "Eb",
            "Ab",
            "Db",
            "Gb",
            "B",
            "E",
            "A",
            "D",
            "G"});
            this.cbNote.Location = new System.Drawing.Point(135, 41);
            this.cbNote.Name = "cbNote";
            this.cbNote.Size = new System.Drawing.Size(44, 21);
            this.cbNote.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Starting Instrument Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Starting Note";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ending Instrument Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resulting Note:";
            // 
            // tbResultNote
            // 
            this.tbResultNote.Enabled = false;
            this.tbResultNote.Location = new System.Drawing.Point(218, 87);
            this.tbResultNote.Name = "tbResultNote";
            this.tbResultNote.Size = new System.Drawing.Size(78, 20);
            this.tbResultNote.TabIndex = 8;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(221, 41);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 9;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 137);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.tbResultNote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNote);
            this.Controls.Add(this.cbEndInstrument);
            this.Controls.Add(this.cbStartInstrument);
            this.Name = "Form1";
            this.Text = "Note Transposer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStartInstrument;
        private System.Windows.Forms.ComboBox cbEndInstrument;
        private System.Windows.Forms.ComboBox cbNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbResultNote;
        private System.Windows.Forms.Button btnConvert;
    }
}

