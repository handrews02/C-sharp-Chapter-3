namespace EggsInteractiveGUI
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
            this.txtEggs1 = new System.Windows.Forms.TextBox();
            this.txtEggs2 = new System.Windows.Forms.TextBox();
            this.txtEggs3 = new System.Windows.Forms.TextBox();
            this.txtEggs4 = new System.Windows.Forms.TextBox();
            this.txtEggs5 = new System.Windows.Forms.TextBox();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblChicken1 = new System.Windows.Forms.Label();
            this.lblChicken2 = new System.Windows.Forms.Label();
            this.lblChicken3 = new System.Windows.Forms.Label();
            this.lblChicken4 = new System.Windows.Forms.Label();
            this.lblChicken5 = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEggs1
            // 
            this.txtEggs1.Location = new System.Drawing.Point(308, 63);
            this.txtEggs1.Name = "txtEggs1";
            this.txtEggs1.Size = new System.Drawing.Size(100, 20);
            this.txtEggs1.TabIndex = 0;
            // 
            // txtEggs2
            // 
            this.txtEggs2.Location = new System.Drawing.Point(308, 111);
            this.txtEggs2.Name = "txtEggs2";
            this.txtEggs2.Size = new System.Drawing.Size(100, 20);
            this.txtEggs2.TabIndex = 1;
            // 
            // txtEggs3
            // 
            this.txtEggs3.Location = new System.Drawing.Point(308, 159);
            this.txtEggs3.Name = "txtEggs3";
            this.txtEggs3.Size = new System.Drawing.Size(100, 20);
            this.txtEggs3.TabIndex = 2;
            // 
            // txtEggs4
            // 
            this.txtEggs4.Location = new System.Drawing.Point(308, 206);
            this.txtEggs4.Name = "txtEggs4";
            this.txtEggs4.Size = new System.Drawing.Size(100, 20);
            this.txtEggs4.TabIndex = 3;
            // 
            // txtEggs5
            // 
            this.txtEggs5.Location = new System.Drawing.Point(308, 250);
            this.txtEggs5.Name = "txtEggs5";
            this.txtEggs5.Size = new System.Drawing.Size(100, 20);
            this.txtEggs5.TabIndex = 4;
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Location = new System.Drawing.Point(60, 32);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(292, 13);
            this.lblIntro.TabIndex = 5;
            this.lblIntro.Text = "Enter the number of egss each chicken produces in a month";
            // 
            // lblChicken1
            // 
            this.lblChicken1.AutoSize = true;
            this.lblChicken1.Location = new System.Drawing.Point(125, 69);
            this.lblChicken1.Name = "lblChicken1";
            this.lblChicken1.Size = new System.Drawing.Size(55, 13);
            this.lblChicken1.TabIndex = 6;
            this.lblChicken1.Text = "Chicken 1";
            // 
            // lblChicken2
            // 
            this.lblChicken2.AutoSize = true;
            this.lblChicken2.Location = new System.Drawing.Point(125, 114);
            this.lblChicken2.Name = "lblChicken2";
            this.lblChicken2.Size = new System.Drawing.Size(55, 13);
            this.lblChicken2.TabIndex = 7;
            this.lblChicken2.Text = "Chicken 2";
            // 
            // lblChicken3
            // 
            this.lblChicken3.AutoSize = true;
            this.lblChicken3.Location = new System.Drawing.Point(125, 162);
            this.lblChicken3.Name = "lblChicken3";
            this.lblChicken3.Size = new System.Drawing.Size(55, 13);
            this.lblChicken3.TabIndex = 8;
            this.lblChicken3.Text = "Chicken 3";
            // 
            // lblChicken4
            // 
            this.lblChicken4.AutoSize = true;
            this.lblChicken4.Location = new System.Drawing.Point(125, 209);
            this.lblChicken4.Name = "lblChicken4";
            this.lblChicken4.Size = new System.Drawing.Size(55, 13);
            this.lblChicken4.TabIndex = 9;
            this.lblChicken4.Text = "Chicken 4";
            // 
            // lblChicken5
            // 
            this.lblChicken5.AutoSize = true;
            this.lblChicken5.Location = new System.Drawing.Point(125, 257);
            this.lblChicken5.Name = "lblChicken5";
            this.lblChicken5.Size = new System.Drawing.Size(55, 13);
            this.lblChicken5.TabIndex = 10;
            this.lblChicken5.Text = "Chicken 5";
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(308, 309);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(100, 38);
            this.btnTotal.TabIndex = 11;
            this.btnTotal.Text = "Click to calculate";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(245, 380);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(229, 35);
            this.lblTotal.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.lblChicken5);
            this.Controls.Add(this.lblChicken4);
            this.Controls.Add(this.lblChicken3);
            this.Controls.Add(this.lblChicken2);
            this.Controls.Add(this.lblChicken1);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.txtEggs5);
            this.Controls.Add(this.txtEggs4);
            this.Controls.Add(this.txtEggs3);
            this.Controls.Add(this.txtEggs2);
            this.Controls.Add(this.txtEggs1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEggs1;
        private System.Windows.Forms.TextBox txtEggs2;
        private System.Windows.Forms.TextBox txtEggs3;
        private System.Windows.Forms.TextBox txtEggs4;
        private System.Windows.Forms.TextBox txtEggs5;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lblChicken1;
        private System.Windows.Forms.Label lblChicken2;
        private System.Windows.Forms.Label lblChicken3;
        private System.Windows.Forms.Label lblChicken4;
        private System.Windows.Forms.Label lblChicken5;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}

