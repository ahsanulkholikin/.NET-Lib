
namespace Prak10
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.frmCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.frmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.frmPengguna = new System.Windows.Forms.ToolStripMenuItem();
            this.frmPenjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.frmKeluar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.frmPenjualan,
            this.frmKeluar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmCustomer,
            this.frmMenu,
            this.frmPengguna});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem1.Text = "Data";
            // 
            // frmCustomer
            // 
            this.frmCustomer.Name = "frmCustomer";
            this.frmCustomer.Size = new System.Drawing.Size(180, 22);
            this.frmCustomer.Text = "Customer";
            this.frmCustomer.Click += new System.EventHandler(this.frmCustomer_Click);
            // 
            // frmMenu
            // 
            this.frmMenu.Name = "frmMenu";
            this.frmMenu.Size = new System.Drawing.Size(180, 22);
            this.frmMenu.Text = "Menu";
            this.frmMenu.Click += new System.EventHandler(this.frmMenu_Click);
            // 
            // frmPengguna
            // 
            this.frmPengguna.Name = "frmPengguna";
            this.frmPengguna.Size = new System.Drawing.Size(180, 22);
            this.frmPengguna.Text = "Pengguna";
            this.frmPengguna.Click += new System.EventHandler(this.frmPengguna_Click);
            // 
            // frmPenjualan
            // 
            this.frmPenjualan.Name = "frmPenjualan";
            this.frmPenjualan.Size = new System.Drawing.Size(66, 20);
            this.frmPenjualan.Text = "Transaksi";
            this.frmPenjualan.Click += new System.EventHandler(this.frmPenjualan_Click);
            // 
            // frmKeluar
            // 
            this.frmKeluar.Name = "frmKeluar";
            this.frmKeluar.Size = new System.Drawing.Size(52, 20);
            this.frmKeluar.Text = "Keluar";
            this.frmKeluar.Click += new System.EventHandler(this.frmKeluar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem frmCustomer;
        private System.Windows.Forms.ToolStripMenuItem frmMenu;
        private System.Windows.Forms.ToolStripMenuItem frmPengguna;
        private System.Windows.Forms.ToolStripMenuItem frmPenjualan;
        private System.Windows.Forms.ToolStripMenuItem frmKeluar;
    }
}