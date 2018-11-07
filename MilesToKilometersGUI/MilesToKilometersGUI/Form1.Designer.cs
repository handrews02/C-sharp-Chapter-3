namespace MilesToKilometersGUI
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
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKilometers = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(360, 99);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(173, 20);
            this.txtMiles.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter a distance in Miles";
            // 
            // btnKilometers
            // 
            this.btnKilometers.Location = new System.Drawing.Point(153, 185);
            this.btnKilometers.Name = "btnKilometers";
            this.btnKilometers.Size = new System.Drawing.Size(80, 56);
            this.btnKilometers.TabIndex = 2;
            this.btnKilometers.Text = "Convert to Kilometers";
            this.btnKilometers.UseVisualStyleBackColor = true;
            this.btnKilometers.Click += new System.EventHandler(this.btnKilometers_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(360, 185);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(173, 56);
            this.lblResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnKilometers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKilometers;
        private System.Windows.Forms.Label lblResult;
    }
}

