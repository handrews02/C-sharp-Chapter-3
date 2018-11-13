namespace CarRentalInteractive
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
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.lblMiles = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(375, 99);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 0;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(24, 102);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(265, 13);
            this.lblDays.TabIndex = 1;
            this.lblDays.Text = "Please enter how many days you will be renting the car";
            this.lblDays.Click += new System.EventHandler(this.lblDays_Click);
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(375, 148);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 2;
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(24, 151);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(229, 13);
            this.lblMiles.TabIndex = 3;
            this.lblMiles.Text = "Please enter how many miles you will be driving";
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(122, 238);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(101, 66);
            this.btnTotal.TabIndex = 4;
            this.btnTotal.Text = "Click to see your estimated total!";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(318, 275);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(157, 29);
            this.lblTotal.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.txtDays);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}

