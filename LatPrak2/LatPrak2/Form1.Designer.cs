
namespace LatPrak2
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
            this.components = new System.ComponentModel.Container();
            this.jk = new System.Windows.Forms.ComboBox();
            this.mnk = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tun = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.janak = new System.Windows.Forms.NumericUpDown();
            this.gj = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.janak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gj)).BeginInit();
            this.SuspendLayout();
            // 
            // jk
            // 
            this.jk.FormattingEnabled = true;
            this.jk.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.jk.Location = new System.Drawing.Point(140, 43);
            this.jk.Name = "jk";
            this.jk.Size = new System.Drawing.Size(156, 23);
            this.jk.TabIndex = 0;
            // 
            // mnk
            // 
            this.mnk.AutoSize = true;
            this.mnk.Location = new System.Drawing.Point(140, 83);
            this.mnk.Name = "mnk";
            this.mnk.Size = new System.Drawing.Size(71, 19);
            this.mnk.TabIndex = 1;
            this.mnk.TabStop = true;
            this.mnk.Text = "Menikah";
            this.mnk.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(217, 81);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 19);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Belum";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tun
            // 
            this.tun.Location = new System.Drawing.Point(140, 251);
            this.tun.Name = "tun";
            this.tun.Size = new System.Drawing.Size(156, 23);
            this.tun.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hitung Tunjangan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Staus Menikah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Jumlah Anak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gaji Pokok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tunjangan";
            // 
            // janak
            // 
            this.janak.Location = new System.Drawing.Point(140, 123);
            this.janak.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.janak.Name = "janak";
            this.janak.Size = new System.Drawing.Size(156, 23);
            this.janak.TabIndex = 13;
            // 
            // gj
            // 
            this.gj.Location = new System.Drawing.Point(140, 154);
            this.gj.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.gj.Name = "gj";
            this.gj.Size = new System.Drawing.Size(156, 23);
            this.gj.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 333);
            this.Controls.Add(this.gj);
            this.Controls.Add(this.janak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tun);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.mnk);
            this.Controls.Add(this.jk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.janak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox jk;
        private System.Windows.Forms.RadioButton mnk;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox tun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown janak;
        private System.Windows.Forms.NumericUpDown gj;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

