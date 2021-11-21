
namespace Lat3_4
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
            this.txtbil1 = new System.Windows.Forms.TextBox();
            this.txtbil2 = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txthasil = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilangan 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bilangan 2";
            // 
            // txtbil1
            // 
            this.txtbil1.Location = new System.Drawing.Point(105, 29);
            this.txtbil1.Name = "txtbil1";
            this.txtbil1.Size = new System.Drawing.Size(188, 23);
            this.txtbil1.TabIndex = 2;
            // 
            // txtbil2
            // 
            this.txtbil2.Location = new System.Drawing.Point(105, 67);
            this.txtbil2.Name = "txtbil2";
            this.txtbil2.Size = new System.Drawing.Size(188, 23);
            this.txtbil2.TabIndex = 3;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(37, 114);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(256, 23);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txthasil
            // 
            this.txthasil.Location = new System.Drawing.Point(37, 158);
            this.txthasil.Name = "txthasil";
            this.txthasil.Size = new System.Drawing.Size(256, 96);
            this.txthasil.TabIndex = 5;
            this.txthasil.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 291);
            this.Controls.Add(this.txthasil);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtbil2);
            this.Controls.Add(this.txtbil1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
//            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbil1;
        private System.Windows.Forms.TextBox txtbil2;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.RichTextBox txthasil;
    }
}

