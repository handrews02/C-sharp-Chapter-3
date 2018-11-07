namespace ProjectedRaisesGUI
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
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.lblTotal3 = new System.Windows.Forms.Label();
            this.txtSalary1 = new System.Windows.Forms.TextBox();
            this.txtSalary3 = new System.Windows.Forms.TextBox();
            this.txtSalary2 = new System.Windows.Forms.TextBox();
            this.lblEnterSalary1 = new System.Windows.Forms.Label();
            this.lblterSalary3 = new System.Windows.Forms.Label();
            this.lblEnterSalary2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotal1
            // 
            this.lblTotal1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal1.Location = new System.Drawing.Point(393, 113);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(236, 23);
            this.lblTotal1.TabIndex = 0;
            // 
            // lblTotal2
            // 
            this.lblTotal2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal2.Location = new System.Drawing.Point(393, 161);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(236, 23);
            this.lblTotal2.TabIndex = 1;
            this.lblTotal2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTotal3
            // 
            this.lblTotal3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal3.Location = new System.Drawing.Point(393, 206);
            this.lblTotal3.Name = "lblTotal3";
            this.lblTotal3.Size = new System.Drawing.Size(236, 23);
            this.lblTotal3.TabIndex = 2;
            // 
            // txtSalary1
            // 
            this.txtSalary1.Location = new System.Drawing.Point(212, 113);
            this.txtSalary1.Multiline = true;
            this.txtSalary1.Name = "txtSalary1";
            this.txtSalary1.Size = new System.Drawing.Size(115, 23);
            this.txtSalary1.TabIndex = 3;
            // 
            // txtSalary3
            // 
            this.txtSalary3.Location = new System.Drawing.Point(212, 206);
            this.txtSalary3.Multiline = true;
            this.txtSalary3.Name = "txtSalary3";
            this.txtSalary3.Size = new System.Drawing.Size(115, 23);
            this.txtSalary3.TabIndex = 4;
            // 
            // txtSalary2
            // 
            this.txtSalary2.Location = new System.Drawing.Point(212, 161);
            this.txtSalary2.Multiline = true;
            this.txtSalary2.Name = "txtSalary2";
            this.txtSalary2.Size = new System.Drawing.Size(115, 23);
            this.txtSalary2.TabIndex = 5;
            // 
            // lblEnterSalary1
            // 
            this.lblEnterSalary1.AutoSize = true;
            this.lblEnterSalary1.Location = new System.Drawing.Point(26, 123);
            this.lblEnterSalary1.Name = "lblEnterSalary1";
            this.lblEnterSalary1.Size = new System.Drawing.Size(164, 13);
            this.lblEnterSalary1.TabIndex = 6;
            this.lblEnterSalary1.Text = "Please Enter Employee 1\'s Salary";
            // 
            // lblterSalary3
            // 
            this.lblterSalary3.AutoSize = true;
            this.lblterSalary3.Location = new System.Drawing.Point(26, 216);
            this.lblterSalary3.Name = "lblterSalary3";
            this.lblterSalary3.Size = new System.Drawing.Size(164, 13);
            this.lblterSalary3.TabIndex = 7;
            this.lblterSalary3.Text = "Please Enter Employee 3\'s Salary";
            // 
            // lblEnterSalary2
            // 
            this.lblEnterSalary2.AutoSize = true;
            this.lblEnterSalary2.Location = new System.Drawing.Point(26, 171);
            this.lblEnterSalary2.Name = "lblEnterSalary2";
            this.lblEnterSalary2.Size = new System.Drawing.Size(164, 13);
            this.lblEnterSalary2.TabIndex = 8;
            this.lblEnterSalary2.Text = "Please Enter Employee 2\'s Salary";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Click to see your future salary!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblEnterSalary2);
            this.Controls.Add(this.lblterSalary3);
            this.Controls.Add(this.lblEnterSalary1);
            this.Controls.Add(this.txtSalary2);
            this.Controls.Add(this.txtSalary3);
            this.Controls.Add(this.txtSalary1);
            this.Controls.Add(this.lblTotal3);
            this.Controls.Add(this.lblTotal2);
            this.Controls.Add(this.lblTotal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal1;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Label lblTotal3;
        private System.Windows.Forms.TextBox txtSalary1;
        private System.Windows.Forms.TextBox txtSalary3;
        private System.Windows.Forms.TextBox txtSalary2;
        private System.Windows.Forms.Label lblEnterSalary1;
        private System.Windows.Forms.Label lblterSalary3;
        private System.Windows.Forms.Label lblEnterSalary2;
        private System.Windows.Forms.Button button1;
    }
}

