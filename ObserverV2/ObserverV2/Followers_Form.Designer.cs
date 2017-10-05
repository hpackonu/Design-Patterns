namespace ObserverV2
{
    partial class Followers_Form
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
            this.lblUserOne = new System.Windows.Forms.Label();
            this.cbUserOne = new System.Windows.Forms.CheckBox();
            this.cbUserTwo = new System.Windows.Forms.CheckBox();
            this.lblUserTwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserOne
            // 
            this.lblUserOne.AutoSize = true;
            this.lblUserOne.Location = new System.Drawing.Point(129, 17);
            this.lblUserOne.Name = "lblUserOne";
            this.lblUserOne.Size = new System.Drawing.Size(55, 13);
            this.lblUserOne.TabIndex = 0;
            this.lblUserOne.Text = "User One:";
            // 
            // cbUserOne
            // 
            this.cbUserOne.AutoSize = true;
            this.cbUserOne.Location = new System.Drawing.Point(13, 13);
            this.cbUserOne.Name = "cbUserOne";
            this.cbUserOne.Size = new System.Drawing.Size(110, 17);
            this.cbUserOne.TabIndex = 1;
            this.cbUserOne.Text = "Follow User One?";
            this.cbUserOne.UseVisualStyleBackColor = true;
            // 
            // cbUserTwo
            // 
            this.cbUserTwo.AutoSize = true;
            this.cbUserTwo.Location = new System.Drawing.Point(12, 52);
            this.cbUserTwo.Name = "cbUserTwo";
            this.cbUserTwo.Size = new System.Drawing.Size(111, 17);
            this.cbUserTwo.TabIndex = 2;
            this.cbUserTwo.Text = "Follow User Two?";
            this.cbUserTwo.UseVisualStyleBackColor = true;
            // 
            // lblUserTwo
            // 
            this.lblUserTwo.AutoSize = true;
            this.lblUserTwo.Location = new System.Drawing.Point(128, 56);
            this.lblUserTwo.Name = "lblUserTwo";
            this.lblUserTwo.Size = new System.Drawing.Size(56, 13);
            this.lblUserTwo.TabIndex = 3;
            this.lblUserTwo.Text = "User Two:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 95);
            this.Controls.Add(this.lblUserTwo);
            this.Controls.Add(this.cbUserTwo);
            this.Controls.Add(this.cbUserOne);
            this.Controls.Add(this.lblUserOne);
            this.Name = "Form2";
            this.Text = "Follower";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserOne;
        private System.Windows.Forms.CheckBox cbUserOne;
        private System.Windows.Forms.CheckBox cbUserTwo;
        private System.Windows.Forms.Label lblUserTwo;
    }
}