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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(943, 606);
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
    }
}

