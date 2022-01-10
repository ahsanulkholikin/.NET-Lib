
namespace Prak9_2
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtno = new System.Windows.Forms.TextBox();
            this.txttgl = new System.Windows.Forms.TextBox();
            this.txtidcus = new System.Windows.Forms.TextBox();
            this.txtidmenu = new System.Windows.Forms.TextBox();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.cbomenu = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Transaksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "namaMenu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga";
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(104, 25);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(100, 23);
            this.txtno.TabIndex = 5;
            // 
            // txttgl
            // 
            this.txttgl.Location = new System.Drawing.Point(104, 67);
            this.txttgl.Name = "txttgl";
            this.txttgl.Size = new System.Drawing.Size(228, 23);
            this.txttgl.TabIndex = 6;
            // 
            // txtidcus
            // 
            this.txtidcus.Location = new System.Drawing.Point(104, 106);
            this.txtidcus.Name = "txtidcus";
            this.txtidcus.Size = new System.Drawing.Size(100, 23);
            this.txtidcus.TabIndex = 7;
            // 
            // txtidmenu
            // 
            this.txtidmenu.Location = new System.Drawing.Point(272, 184);
            this.txtidmenu.Name = "txtidmenu";
            this.txtidmenu.Size = new System.Drawing.Size(60, 23);
            this.txtidmenu.TabIndex = 8;
            this.txtidmenu.Visible = false;
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(104, 223);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(100, 23);
            this.txtharga.TabIndex = 9;
            // 
            // cbomenu
            // 
            this.cbomenu.FormattingEnabled = true;
            this.cbomenu.Location = new System.Drawing.Point(104, 184);
            this.cbomenu.Name = "cbomenu";
            this.cbomenu.Size = new System.Drawing.Size(162, 23);
            this.cbomenu.TabIndex = 10;
            this.cbomenu.SelectedIndexChanged += new System.EventHandler(this.cbomenu_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbomenu);
            this.Controls.Add(this.txtharga);
            this.Controls.Add(this.txtidmenu);
            this.Controls.Add(this.txtidcus);
            this.Controls.Add(this.txttgl);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.TextBox txttgl;
        private System.Windows.Forms.TextBox txtidcus;
        private System.Windows.Forms.TextBox txtidmenu;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.ComboBox cbomenu;
        private System.Windows.Forms.Button button1;
    }
}

