
namespace Lat4_2
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
            this.txtnim = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtinggris = new System.Windows.Forms.TextBox();
            this.txtmanajemen = new System.Windows.Forms.TextBox();
            this.txtbahasa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnim
            // 
            this.txtnim.Location = new System.Drawing.Point(150, 53);
            this.txtnim.Name = "txtnim";
            this.txtnim.Size = new System.Drawing.Size(100, 23);
            this.txtnim.TabIndex = 0;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(150, 80);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(100, 23);
            this.txtnama.TabIndex = 1;
            // 
            // txtinggris
            // 
            this.txtinggris.Location = new System.Drawing.Point(150, 110);
            this.txtinggris.Name = "txtinggris";
            this.txtinggris.Size = new System.Drawing.Size(100, 23);
            this.txtinggris.TabIndex = 2;
            // 
            // txtmanajemen
            // 
            this.txtmanajemen.Location = new System.Drawing.Point(150, 141);
            this.txtmanajemen.Name = "txtmanajemen";
            this.txtmanajemen.Size = new System.Drawing.Size(100, 23);
            this.txtmanajemen.TabIndex = 3;
            // 
            // txtbahasa
            // 
            this.txtbahasa.Location = new System.Drawing.Point(150, 170);
            this.txtbahasa.Name = "txtbahasa";
            this.txtbahasa.Size = new System.Drawing.Size(100, 23);
            this.txtbahasa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nilai Inggris";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nilai Manajemen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nilai Bahasa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hitung";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbahasa);
            this.Controls.Add(this.txtmanajemen);
            this.Controls.Add(this.txtinggris);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtnim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnim;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtinggris;
        private System.Windows.Forms.TextBox txtmanajemen;
        private System.Windows.Forms.TextBox txtbahasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

