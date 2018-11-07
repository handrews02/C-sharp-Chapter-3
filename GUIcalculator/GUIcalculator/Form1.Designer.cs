namespace GUIcalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.lblResult3 = new System.Windows.Forms.Label();
            this.lblResult4 = new System.Windows.Forms.Label();
            this.lblResult5 = new System.Windows.Forms.Label();
            this.btnAnswers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter another number";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(280, 45);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(168, 20);
            this.txtNumber1.TabIndex = 2;
            this.txtNumber1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(280, 108);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(168, 20);
            this.txtNumber2.TabIndex = 3;
            this.txtNumber2.TextChanged += new System.EventHandler(this.txtNumber2_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(53, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(279, 155);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(168, 23);
            this.lblResult.TabIndex = 5;
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(53, 199);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(75, 23);
            this.btnSubtract.TabIndex = 6;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(53, 239);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(53, 279);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 23);
            this.btnMultiply.TabIndex = 9;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(53, 322);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 10;
            this.btnMod.Text = "Modulus";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // lblResult2
            // 
            this.lblResult2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult2.Location = new System.Drawing.Point(279, 199);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(168, 23);
            this.lblResult2.TabIndex = 11;
            // 
            // lblResult3
            // 
            this.lblResult3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult3.Location = new System.Drawing.Point(279, 239);
            this.lblResult3.Name = "lblResult3";
            this.lblResult3.Size = new System.Drawing.Size(168, 23);
            this.lblResult3.TabIndex = 12;
            // 
            // lblResult4
            // 
            this.lblResult4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult4.Location = new System.Drawing.Point(279, 279);
            this.lblResult4.Name = "lblResult4";
            this.lblResult4.Size = new System.Drawing.Size(168, 23);
            this.lblResult4.TabIndex = 13;
            // 
            // lblResult5
            // 
            this.lblResult5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult5.Location = new System.Drawing.Point(279, 322);
            this.lblResult5.Name = "lblResult5";
            this.lblResult5.Size = new System.Drawing.Size(168, 23);
            this.lblResult5.TabIndex = 14;
            // 
            // btnAnswers
            // 
            this.btnAnswers.Location = new System.Drawing.Point(53, 367);
            this.btnAnswers.Name = "btnAnswers";
            this.btnAnswers.Size = new System.Drawing.Size(75, 23);
            this.btnAnswers.TabIndex = 15;
            this.btnAnswers.Text = "All answers";
            this.btnAnswers.UseVisualStyleBackColor = true;
            this.btnAnswers.Click += new System.EventHandler(this.btnAnswers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.btnAnswers);
            this.Controls.Add(this.lblResult5);
            this.Controls.Add(this.lblResult4);
            this.Controls.Add(this.lblResult3);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Label lblResult3;
        private System.Windows.Forms.Label lblResult4;
        private System.Windows.Forms.Label lblResult5;
        private System.Windows.Forms.Button btnAnswers;
    }
}

