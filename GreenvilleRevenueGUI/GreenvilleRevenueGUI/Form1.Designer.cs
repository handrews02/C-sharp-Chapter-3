namespace GreenvilleRevenueGUI
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
            this.txtGuests1 = new System.Windows.Forms.TextBox();
            this.lblGuests1 = new System.Windows.Forms.Label();
            this.lblGuests2 = new System.Windows.Forms.Label();
            this.txtGuests2 = new System.Windows.Forms.TextBox();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblMoreOrLess = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGuests1
            // 
            this.txtGuests1.Location = new System.Drawing.Point(276, 93);
            this.txtGuests1.Name = "txtGuests1";
            this.txtGuests1.Size = new System.Drawing.Size(100, 20);
            this.txtGuests1.TabIndex = 0;
            // 
            // lblGuests1
            // 
            this.lblGuests1.Location = new System.Drawing.Point(43, 82);
            this.lblGuests1.Name = "lblGuests1";
            this.lblGuests1.Size = new System.Drawing.Size(176, 31);
            this.lblGuests1.TabIndex = 1;
            this.lblGuests1.Text = "Please enter the number of guests entered  in last year\'s competition ";
            // 
            // lblGuests2
            // 
            this.lblGuests2.Location = new System.Drawing.Point(43, 165);
            this.lblGuests2.Name = "lblGuests2";
            this.lblGuests2.Size = new System.Drawing.Size(176, 31);
            this.lblGuests2.TabIndex = 2;
            this.lblGuests2.Text = "Please enter the number of guests entered  in this year\'s competition ";
            this.lblGuests2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtGuests2
            // 
            this.txtGuests2.Location = new System.Drawing.Point(276, 176);
            this.txtGuests2.Name = "txtGuests2";
            this.txtGuests2.Size = new System.Drawing.Size(100, 20);
            this.txtGuests2.TabIndex = 3;
            // 
            // lblRevenue
            // 
            this.lblRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRevenue.Location = new System.Drawing.Point(46, 301);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(206, 59);
            this.lblRevenue.TabIndex = 4;
            // 
            // lblMoreOrLess
            // 
            this.lblMoreOrLess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMoreOrLess.Location = new System.Drawing.Point(381, 301);
            this.lblMoreOrLess.Name = "lblMoreOrLess";
            this.lblMoreOrLess.Size = new System.Drawing.Size(206, 59);
            this.lblMoreOrLess.TabIndex = 5;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(442, 116);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(110, 63);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.Text = "Click here to get more information!";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblMoreOrLess);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.txtGuests2);
            this.Controls.Add(this.lblGuests2);
            this.Controls.Add(this.lblGuests1);
            this.Controls.Add(this.txtGuests1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGuests1;
        private System.Windows.Forms.Label lblGuests1;
        private System.Windows.Forms.Label lblGuests2;
        private System.Windows.Forms.TextBox txtGuests2;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblMoreOrLess;
        private System.Windows.Forms.Button btnInfo;
    }
}

