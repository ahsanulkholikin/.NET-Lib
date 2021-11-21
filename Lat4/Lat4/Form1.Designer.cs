
namespace Lat4
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
            this.txtplat = new System.Windows.Forms.TextBox();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.txtmanufaktur = new System.Windows.Forms.TextBox();
            this.txtspeedmax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txttahun = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtplat
            // 
            this.txtplat.Location = new System.Drawing.Point(151, 39);
            this.txtplat.Name = "txtplat";
            this.txtplat.Size = new System.Drawing.Size(100, 23);
            this.txtplat.TabIndex = 0;
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(151, 74);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(100, 23);
            this.txtmodel.TabIndex = 1;
            // 
            // txtmanufaktur
            // 
            this.txtmanufaktur.Location = new System.Drawing.Point(151, 109);
            this.txtmanufaktur.Name = "txtmanufaktur";
            this.txtmanufaktur.Size = new System.Drawing.Size(100, 23);
            this.txtmanufaktur.TabIndex = 2;
            // 
            // txtspeedmax
            // 
            this.txtspeedmax.Location = new System.Drawing.Point(151, 144);
            this.txtspeedmax.Name = "txtspeedmax";
            this.txtspeedmax.Size = new System.Drawing.Size(100, 23);
            this.txtspeedmax.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Manufaktur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "SpeedMax";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plat No.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "TAMPIL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tahun Produksi";
            // 
            // txttahun
            // 
            this.txttahun.Location = new System.Drawing.Point(151, 182);
            this.txttahun.Name = "txttahun";
            this.txttahun.Size = new System.Drawing.Size(100, 23);
            this.txttahun.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 306);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttahun);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtspeedmax);
            this.Controls.Add(this.txtmanufaktur);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.txtplat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtplat;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.TextBox txtmanufaktur;
        private System.Windows.Forms.TextBox txtspeedmax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttahun;
    }
}

