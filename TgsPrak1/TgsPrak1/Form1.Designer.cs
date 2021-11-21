
namespace TgsPrak1
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
            this.suhu = new System.Windows.Forms.TextBox();
            this.cbpar1 = new System.Windows.Forms.ComboBox();
            this.rbc = new System.Windows.Forms.RadioButton();
            this.rbf = new System.Windows.Forms.RadioButton();
            this.rbr = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "KONVERSI SUHU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "SUHU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "KE :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "HASIL";
            // 
            // suhu
            // 
            this.suhu.Location = new System.Drawing.Point(94, 71);
            this.suhu.Name = "suhu";
            this.suhu.Size = new System.Drawing.Size(121, 23);
            this.suhu.TabIndex = 4;
            // 
            // cbpar1
            // 
            this.cbpar1.FormattingEnabled = true;
            this.cbpar1.Location = new System.Drawing.Point(221, 71);
            this.cbpar1.Name = "cbpar1";
            this.cbpar1.Size = new System.Drawing.Size(118, 23);
            this.cbpar1.TabIndex = 5;
            // 
            // rbc
            // 
            this.rbc.AutoSize = true;
            this.rbc.Location = new System.Drawing.Point(94, 119);
            this.rbc.Name = "rbc";
            this.rbc.Size = new System.Drawing.Size(63, 19);
            this.rbc.TabIndex = 6;
            this.rbc.TabStop = true;
            this.rbc.Text = "Celcius";
            this.rbc.UseVisualStyleBackColor = true;
            // 
            // rbf
            // 
            this.rbf.AutoSize = true;
            this.rbf.Location = new System.Drawing.Point(94, 144);
            this.rbf.Name = "rbf";
            this.rbf.Size = new System.Drawing.Size(84, 19);
            this.rbf.TabIndex = 7;
            this.rbf.TabStop = true;
            this.rbf.Text = "Fahreinheit";
            this.rbf.UseVisualStyleBackColor = true;
            // 
            // rbr
            // 
            this.rbr.AutoSize = true;
            this.rbr.Location = new System.Drawing.Point(94, 169);
            this.rbr.Name = "rbr";
            this.rbr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbr.Size = new System.Drawing.Size(66, 19);
            this.rbr.TabIndex = 8;
            this.rbr.TabStop = true;
            this.rbr.Text = "Reamur";
            this.rbr.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "KONVERSI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tot
            // 
            this.tot.Location = new System.Drawing.Point(239, 275);
            this.tot.Name = "tot";
            this.tot.Size = new System.Drawing.Size(100, 23);
            this.tot.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 363);
            this.Controls.Add(this.tot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbr);
            this.Controls.Add(this.rbf);
            this.Controls.Add(this.rbc);
            this.Controls.Add(this.cbpar1);
            this.Controls.Add(this.suhu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tugas Praktikum (19SA1295)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox suhu;
        private System.Windows.Forms.ComboBox cbpar1;
        private System.Windows.Forms.RadioButton rbc;
        private System.Windows.Forms.RadioButton rbf;
        private System.Windows.Forms.RadioButton rbr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tot;
    }
}

