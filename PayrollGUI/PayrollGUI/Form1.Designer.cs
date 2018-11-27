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
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.lblFdrlTax = new System.Windows.Forms.Label();
            this.lblStateWth = new System.Windows.Forms.Label();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
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
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Location = new System.Drawing.Point(454, 54);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(55, 13);
            this.lblGrossPay.TabIndex = 12;
            this.lblGrossPay.Text = "Gross Pay";
            // 
            // lblFdrlTax
            // 
            this.lblFdrlTax.AutoSize = true;
            this.lblFdrlTax.Location = new System.Drawing.Point(454, 108);
            this.lblFdrlTax.Name = "lblFdrlTax";
            this.lblFdrlTax.Size = new System.Drawing.Size(119, 13);
            this.lblFdrlTax.TabIndex = 13;
            this.lblFdrlTax.Text = "Federal Tax withholding";
            // 
            // lblStateWth
            // 
            this.lblStateWth.AutoSize = true;
            this.lblStateWth.Location = new System.Drawing.Point(454, 168);
            this.lblStateWth.Name = "lblStateWth";
            this.lblStateWth.Size = new System.Drawing.Size(105, 13);
            this.lblStateWth.TabIndex = 14;
            this.lblStateWth.Text = "State tax withholding";
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Location = new System.Drawing.Point(454, 222);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(44, 13);
            this.lblNetPay.TabIndex = 15;
            this.lblNetPay.Text = "Net pay";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(307, 316);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(181, 81);
            this.btnInfo.TabIndex = 16;
            this.btnInfo.Text = "Click to get more information!";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblNetPay);
            this.Controls.Add(this.lblStateWth);
            this.Controls.Add(this.lblFdrlTax);
            this.Controls.Add(this.lblGrossPay);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label lblFdrlTax;
        private System.Windows.Forms.Label lblStateWth;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.Button btnInfo;
    }
}

