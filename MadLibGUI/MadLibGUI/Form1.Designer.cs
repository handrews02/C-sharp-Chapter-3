namespace MadLibGUI
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
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPluralNoun = new System.Windows.Forms.TextBox();
            this.txtNoun = new System.Windows.Forms.TextBox();
            this.txtAnimal = new System.Windows.Forms.TextBox();
            this.txtBodyPart = new System.Windows.Forms.TextBox();
            this.txtWordEST = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblStory = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblEst = new System.Windows.Forms.Label();
            this.lblBodyPart = new System.Windows.Forms.Label();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.lblNoun = new System.Windows.Forms.Label();
            this.lblPluralNoun = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(237, 51);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(127, 20);
            this.txtColor.TabIndex = 0;
            // 
            // txtPluralNoun
            // 
            this.txtPluralNoun.Location = new System.Drawing.Point(237, 319);
            this.txtPluralNoun.Name = "txtPluralNoun";
            this.txtPluralNoun.Size = new System.Drawing.Size(127, 20);
            this.txtPluralNoun.TabIndex = 1;
            // 
            // txtNoun
            // 
            this.txtNoun.Location = new System.Drawing.Point(237, 263);
            this.txtNoun.Name = "txtNoun";
            this.txtNoun.Size = new System.Drawing.Size(127, 20);
            this.txtNoun.TabIndex = 2;
            // 
            // txtAnimal
            // 
            this.txtAnimal.Location = new System.Drawing.Point(237, 211);
            this.txtAnimal.Name = "txtAnimal";
            this.txtAnimal.Size = new System.Drawing.Size(127, 20);
            this.txtAnimal.TabIndex = 3;
            // 
            // txtBodyPart
            // 
            this.txtBodyPart.Location = new System.Drawing.Point(237, 159);
            this.txtBodyPart.Name = "txtBodyPart";
            this.txtBodyPart.Size = new System.Drawing.Size(127, 20);
            this.txtBodyPart.TabIndex = 4;
            // 
            // txtWordEST
            // 
            this.txtWordEST.Location = new System.Drawing.Point(237, 107);
            this.txtWordEST.Name = "txtWordEST";
            this.txtWordEST.Size = new System.Drawing.Size(127, 20);
            this.txtWordEST.TabIndex = 5;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(237, 371);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(127, 20);
            this.txtNum1.TabIndex = 6;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(237, 422);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(127, 20);
            this.txtNum2.TabIndex = 8;
            // 
            // lblStory
            // 
            this.lblStory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblStory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStory.Location = new System.Drawing.Point(572, 124);
            this.lblStory.Name = "lblStory";
            this.lblStory.Size = new System.Drawing.Size(310, 372);
            this.lblStory.TabIndex = 9;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(74, 54);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(67, 13);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Enter a color";
            // 
            // lblEst
            // 
            this.lblEst.AutoSize = true;
            this.lblEst.Location = new System.Drawing.Point(74, 110);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(140, 13);
            this.lblEst.TabIndex = 11;
            this.lblEst.Text = "Enter a word ending in \"est\"";
            // 
            // lblBodyPart
            // 
            this.lblBodyPart.AutoSize = true;
            this.lblBodyPart.Location = new System.Drawing.Point(74, 162);
            this.lblBodyPart.Name = "lblBodyPart";
            this.lblBodyPart.Size = new System.Drawing.Size(116, 13);
            this.lblBodyPart.TabIndex = 12;
            this.lblBodyPart.Text = "Enter a plural body part";
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Location = new System.Drawing.Point(75, 214);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(80, 13);
            this.lblAnimal.TabIndex = 13;
            this.lblAnimal.Text = "Enter an animal";
            // 
            // lblNoun
            // 
            this.lblNoun.AutoSize = true;
            this.lblNoun.Location = new System.Drawing.Point(74, 266);
            this.lblNoun.Name = "lblNoun";
            this.lblNoun.Size = new System.Drawing.Size(68, 13);
            this.lblNoun.TabIndex = 14;
            this.lblNoun.Text = "Enter a noun";
            this.lblNoun.Click += new System.EventHandler(this.lblNoun_Click);
            // 
            // lblPluralNoun
            // 
            this.lblPluralNoun.AutoSize = true;
            this.lblPluralNoun.Location = new System.Drawing.Point(75, 322);
            this.lblPluralNoun.Name = "lblPluralNoun";
            this.lblPluralNoun.Size = new System.Drawing.Size(96, 13);
            this.lblPluralNoun.TabIndex = 15;
            this.lblPluralNoun.Text = "Enter a plural noun";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(76, 374);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(79, 13);
            this.lblNum1.TabIndex = 16;
            this.lblNum1.Text = "Enter a number";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(76, 425);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(109, 13);
            this.lblNum2.TabIndex = 17;
            this.lblNum2.Text = "Enter another number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 76);
            this.button1.TabIndex = 19;
            this.button1.Text = "Click here to create your Mad Lib!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(943, 606);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblPluralNoun);
            this.Controls.Add(this.lblNoun);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.lblBodyPart);
            this.Controls.Add(this.lblEst);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblStory);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtWordEST);
            this.Controls.Add(this.txtBodyPart);
            this.Controls.Add(this.txtAnimal);
            this.Controls.Add(this.txtNoun);
            this.Controls.Add(this.txtPluralNoun);
            this.Controls.Add(this.txtColor);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "Form1";
            this.Text = "Mad Lib ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPluralNoun;
        private System.Windows.Forms.TextBox txtNoun;
        private System.Windows.Forms.TextBox txtAnimal;
        private System.Windows.Forms.TextBox txtBodyPart;
        private System.Windows.Forms.TextBox txtWordEST;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblStory;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblEst;
        private System.Windows.Forms.Label lblBodyPart;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Label lblNoun;
        private System.Windows.Forms.Label lblPluralNoun;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Button button1;
    }
}

