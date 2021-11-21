
namespace Lat3
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
            this.Panjang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPanjang = new System.Windows.Forms.TextBox();
            this.txtLebar = new System.Windows.Forms.TextBox();
            this.txtVoid = new System.Windows.Forms.TextBox();
            this.txtFungsi = new System.Windows.Forms.TextBox();
            this.btnVoid = new System.Windows.Forms.Button();
            this.btnFungsi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Panjang
            // 
            this.Panjang.AutoSize = true;
            this.Panjang.Location = new System.Drawing.Point(34, 38);
            this.Panjang.Name = "Panjang";
            this.Panjang.Size = new System.Drawing.Size(50, 15);
            this.Panjang.TabIndex = 0;
            this.Panjang.Text = "Panjang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lebar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasil";
            // 
            // txtPanjang
            // 
            this.txtPanjang.Location = new System.Drawing.Point(34, 67);
            this.txtPanjang.Name = "txtPanjang";
            this.txtPanjang.Size = new System.Drawing.Size(100, 23);
            this.txtPanjang.TabIndex = 4;
            // 
            // txtLebar
            // 
            this.txtLebar.Location = new System.Drawing.Point(189, 67);
            this.txtLebar.Name = "txtLebar";
            this.txtLebar.Size = new System.Drawing.Size(100, 23);
            this.txtLebar.TabIndex = 5;
            // 
            // txtVoid
            // 
            this.txtVoid.Location = new System.Drawing.Point(34, 205);
            this.txtVoid.Name = "txtVoid";
            this.txtVoid.Size = new System.Drawing.Size(100, 23);
            this.txtVoid.TabIndex = 6;
            // 
            // txtFungsi
            // 
            this.txtFungsi.Location = new System.Drawing.Point(192, 205);
            this.txtFungsi.Name = "txtFungsi";
            this.txtFungsi.Size = new System.Drawing.Size(100, 23);
            this.txtFungsi.TabIndex = 7;
            // 
            // btnVoid
            // 
            this.btnVoid.Location = new System.Drawing.Point(34, 126);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(100, 23);
            this.btnVoid.TabIndex = 8;
            this.btnVoid.Text = "Luas(Void)";
            this.btnVoid.UseVisualStyleBackColor = true;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            // 
            // btnFungsi
            // 
            this.btnFungsi.Location = new System.Drawing.Point(189, 126);
            this.btnFungsi.Name = "btnFungsi";
            this.btnFungsi.Size = new System.Drawing.Size(103, 23);
            this.btnFungsi.TabIndex = 9;
            this.btnFungsi.Text = "Luas(Fungsi)";
            this.btnFungsi.UseVisualStyleBackColor = true;
            this.btnFungsi.Click += new System.EventHandler(this.btnFungsi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 297);
            this.Controls.Add(this.btnFungsi);
            this.Controls.Add(this.btnVoid);
            this.Controls.Add(this.txtFungsi);
            this.Controls.Add(this.txtVoid);
            this.Controls.Add(this.txtLebar);
            this.Controls.Add(this.txtPanjang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Panjang);
            this.Name = "Form1";
            this.Text = "Pan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Panjang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPanjang;
        private System.Windows.Forms.TextBox txtLebar;
        private System.Windows.Forms.TextBox txtVoid;
        private System.Windows.Forms.TextBox txtFungsi;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.Button btnFungsi;
    }
}

