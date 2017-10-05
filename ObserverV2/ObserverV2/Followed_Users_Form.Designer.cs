namespace ObserverV2
{
    partial class Followed_Users_Form
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
            this.lblCONSTUserOne = new System.Windows.Forms.Label();
            this.lblCONSTUserTwo = new System.Windows.Forms.Label();
            this.btnFollower = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbUserOne = new System.Windows.Forms.TextBox();
            this.tbUserTwo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCONSTUserOne
            // 
            this.lblCONSTUserOne.AutoSize = true;
            this.lblCONSTUserOne.Location = new System.Drawing.Point(13, 13);
            this.lblCONSTUserOne.Name = "lblCONSTUserOne";
            this.lblCONSTUserOne.Size = new System.Drawing.Size(55, 13);
            this.lblCONSTUserOne.TabIndex = 0;
            this.lblCONSTUserOne.Text = "User One:";
            // 
            // lblCONSTUserTwo
            // 
            this.lblCONSTUserTwo.AutoSize = true;
            this.lblCONSTUserTwo.Location = new System.Drawing.Point(12, 38);
            this.lblCONSTUserTwo.Name = "lblCONSTUserTwo";
            this.lblCONSTUserTwo.Size = new System.Drawing.Size(56, 13);
            this.lblCONSTUserTwo.TabIndex = 1;
            this.lblCONSTUserTwo.Text = "User Two:";
            // 
            // btnFollower
            // 
            this.btnFollower.Location = new System.Drawing.Point(13, 72);
            this.btnFollower.Name = "btnFollower";
            this.btnFollower.Size = new System.Drawing.Size(77, 23);
            this.btnFollower.TabIndex = 2;
            this.btnFollower.Text = "Add Follower";
            this.btnFollower.UseVisualStyleBackColor = true;
            this.btnFollower.Click += new System.EventHandler(this.btnFollower_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(197, 72);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbUserOne
            // 
            this.tbUserOne.Location = new System.Drawing.Point(75, 13);
            this.tbUserOne.Name = "tbUserOne";
            this.tbUserOne.Size = new System.Drawing.Size(197, 20);
            this.tbUserOne.TabIndex = 4;
            // 
            // tbUserTwo
            // 
            this.tbUserTwo.Location = new System.Drawing.Point(74, 39);
            this.tbUserTwo.Name = "tbUserTwo";
            this.tbUserTwo.Size = new System.Drawing.Size(197, 20);
            this.tbUserTwo.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 107);
            this.Controls.Add(this.tbUserTwo);
            this.Controls.Add(this.tbUserOne);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnFollower);
            this.Controls.Add(this.lblCONSTUserTwo);
            this.Controls.Add(this.lblCONSTUserOne);
            this.Name = "Form1";
            this.Text = "Followed Users";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCONSTUserOne;
        private System.Windows.Forms.Label lblCONSTUserTwo;
        private System.Windows.Forms.Button btnFollower;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbUserOne;
        private System.Windows.Forms.TextBox tbUserTwo;
    }
}

