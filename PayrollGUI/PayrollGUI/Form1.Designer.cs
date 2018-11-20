namespace PayrollGUI
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSocial = new System.Windows.Forms.TextBox();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSocial = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblGrossPayOut = new System.Windows.Forms.Label();
            this.lblFedTaxOut = new System.Windows.Forms.Label();
            this.lblStateTaxOut = new System.Windows.Forms.Label();
            this.lblNetPayOut = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(225, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtSocial
            // 
            this.txtSocial.Location = new System.Drawing.Point(225, 108);
            this.txtSocial.Name = "txtSocial";
            this.txtSocial.Size = new System.Drawing.Size(100, 20);
            this.txtSocial.TabIndex = 1;
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(225, 168);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(100, 20);
            this.txtPay.TabIndex = 2;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(225, 238);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 20);
            this.txtHours.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(85, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Enter your name";
            // 
            // lblSocial
            // 
            this.lblSocial.AutoSize = true;
            this.lblSocial.Location = new System.Drawing.Point(85, 111);
            this.lblSocial.Name = "lblSocial";
            this.lblSocial.Size = new System.Drawing.Size(127, 13);
            this.lblSocial.TabIndex = 5;
            this.lblSocial.Text = "Enter your Social Number";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Location = new System.Drawing.Point(85, 171);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(127, 13);
            this.lblPay.TabIndex = 6;
            this.lblPay.Text = "Enter your hourly pay rate";
            // 
            // lblHours
            // 
            this.lblHours.Location = new System.Drawing.Point(85, 221);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(101, 46);
            this.lblHours.TabIndex = 7;
            this.lblHours.Text = "Enter how many hours you work every pay period";
            // 
            // lblGrossPayOut
            // 
            this.lblGrossPayOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrossPayOut.Location = new System.Drawing.Point(596, 54);
            this.lblGrossPayOut.Name = "lblGrossPayOut";
            this.lblGrossPayOut.Size = new System.Drawing.Size(100, 23);
            this.lblGrossPayOut.TabIndex = 8;
            // 
            // lblFedTaxOut
            // 
            this.lblFedTaxOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFedTaxOut.Location = new System.Drawing.Point(596, 108);
            this.lblFedTaxOut.Name = "lblFedTaxOut";
            this.lblFedTaxOut.Size = new System.Drawing.Size(100, 23);
            this.lblFedTaxOut.TabIndex = 9;
            // 
            // lblStateTaxOut
            // 
            this.lblStateTaxOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStateTaxOut.Location = new System.Drawing.Point(596, 161);
            this.lblStateTaxOut.Name = "lblStateTaxOut";
            this.lblStateTaxOut.Size = new System.Drawing.Size(100, 23);
            this.lblStateTaxOut.TabIndex = 10;
            // 
            // lblNetPayOut
            // 
            this.lblNetPayOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetPayOut.Location = new System.Drawing.Point(596, 221);
            this.lblNetPayOut.Name = "lblNetPayOut";
            this.lblNetPayOut.Size = new System.Drawing.Size(100, 24);
            this.lblNetPayOut.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNetPayOut);
            this.Controls.Add(this.lblStateTaxOut);
            this.Controls.Add(this.lblFedTaxOut);
            this.Controls.Add(this.lblGrossPayOut);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.lblSocial);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.txtSocial);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSocial;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSocial;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblGrossPayOut;
        private System.Windows.Forms.Label lblFedTaxOut;
        private System.Windows.Forms.Label lblStateTaxOut;
        private System.Windows.Forms.Label lblNetPayOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

