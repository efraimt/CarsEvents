
namespace CarsEvents.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFrontLeft = new System.Windows.Forms.Label();
            this.lblFrontRight = new System.Windows.Forms.Label();
            this.lblBackRight = new System.Windows.Forms.Label();
            this.lblBackLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFrontLeft
            // 
            this.lblFrontLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFrontLeft.Location = new System.Drawing.Point(371, 70);
            this.lblFrontLeft.Name = "lblFrontLeft";
            this.lblFrontLeft.Size = new System.Drawing.Size(62, 72);
            this.lblFrontLeft.TabIndex = 0;
            this.lblFrontLeft.Text = "label1";
            // 
            // lblFrontRight
            // 
            this.lblFrontRight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFrontRight.Location = new System.Drawing.Point(569, 70);
            this.lblFrontRight.Name = "lblFrontRight";
            this.lblFrontRight.Size = new System.Drawing.Size(62, 72);
            this.lblFrontRight.TabIndex = 1;
            this.lblFrontRight.Text = "label2";
            // 
            // lblBackRight
            // 
            this.lblBackRight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBackRight.Location = new System.Drawing.Point(569, 302);
            this.lblBackRight.Name = "lblBackRight";
            this.lblBackRight.Size = new System.Drawing.Size(62, 72);
            this.lblBackRight.TabIndex = 2;
            this.lblBackRight.Text = "label2";
            // 
            // lblBackLeft
            // 
            this.lblBackLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBackLeft.Location = new System.Drawing.Point(371, 302);
            this.lblBackLeft.Name = "lblBackLeft";
            this.lblBackLeft.Size = new System.Drawing.Size(62, 72);
            this.lblBackLeft.TabIndex = 3;
            this.lblBackLeft.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 532);
            this.Controls.Add(this.lblBackLeft);
            this.Controls.Add(this.lblBackRight);
            this.Controls.Add(this.lblFrontRight);
            this.Controls.Add(this.lblFrontLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFrontLeft;
        private System.Windows.Forms.Label lblFrontRight;
        private System.Windows.Forms.Label lblBackRight;
        private System.Windows.Forms.Label lblBackLeft;
    }
}

