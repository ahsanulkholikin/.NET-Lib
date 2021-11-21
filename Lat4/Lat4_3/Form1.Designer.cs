
namespace Lat4_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputbuku = new System.Windows.Forms.TextBox();
            this.inputpensil = new System.Windows.Forms.TextBox();
            this.inputpulpen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pensil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pulpen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Isikan dengan (y / n) atau jumlah barangnya.";
            // 
            // inputbuku
            // 
            this.inputbuku.Location = new System.Drawing.Point(103, 57);
            this.inputbuku.Name = "inputbuku";
            this.inputbuku.Size = new System.Drawing.Size(178, 23);
            this.inputbuku.TabIndex = 4;
            // 
            // inputpensil
            // 
            this.inputpensil.Location = new System.Drawing.Point(103, 93);
            this.inputpensil.Name = "inputpensil";
            this.inputpensil.Size = new System.Drawing.Size(178, 23);
            this.inputpensil.TabIndex = 5;
            // 
            // inputpulpen
            // 
            this.inputpulpen.Location = new System.Drawing.Point(103, 137);
            this.inputpulpen.Name = "inputpulpen";
            this.inputpulpen.Size = new System.Drawing.Size(178, 23);
            this.inputpulpen.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "HASIL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 276);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputpulpen);
            this.Controls.Add(this.inputpensil);
            this.Controls.Add(this.inputbuku);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputbuku;
        private System.Windows.Forms.TextBox inputpensil;
        private System.Windows.Forms.TextBox inputpulpen;
        private System.Windows.Forms.Button button1;
    }
}

