
namespace OOP_Hamburgerci
{
    partial class AnaSayfa
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
            this.siparisYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraMalzemeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparisYönetimiToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparisYönetimiToolStripMenuItem
            // 
            this.siparisYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparisOlusturToolStripMenuItem,
            this.siparisRaporToolStripMenuItem});
            this.siparisYönetimiToolStripMenuItem.Name = "siparisYönetimiToolStripMenuItem";
            this.siparisYönetimiToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.siparisYönetimiToolStripMenuItem.Text = "Siparis Yönetimi";
            // 
            // siparisOlusturToolStripMenuItem
            // 
            this.siparisOlusturToolStripMenuItem.Name = "siparisOlusturToolStripMenuItem";
            this.siparisOlusturToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparisOlusturToolStripMenuItem.Text = "Siparis Olustur";
            this.siparisOlusturToolStripMenuItem.Click += new System.EventHandler(this.siparisOlusturToolStripMenuItem_Click);
            // 
            // siparisRaporToolStripMenuItem
            // 
            this.siparisRaporToolStripMenuItem.Name = "siparisRaporToolStripMenuItem";
            this.siparisRaporToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparisRaporToolStripMenuItem.Text = "Siparis Rapor";
            this.siparisRaporToolStripMenuItem.Click += new System.EventHandler(this.siparisRaporToolStripMenuItem_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEkleToolStripMenuItem,
            this.extraMalzemeEkleToolStripMenuItem});
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // menuEkleToolStripMenuItem
            // 
            this.menuEkleToolStripMenuItem.Name = "menuEkleToolStripMenuItem";
            this.menuEkleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.menuEkleToolStripMenuItem.Text = "Menu Ekle";
            this.menuEkleToolStripMenuItem.Click += new System.EventHandler(this.menuEkleToolStripMenuItem_Click);
            // 
            // extraMalzemeEkleToolStripMenuItem
            // 
            this.extraMalzemeEkleToolStripMenuItem.Name = "extraMalzemeEkleToolStripMenuItem";
            this.extraMalzemeEkleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.extraMalzemeEkleToolStripMenuItem.Text = "Extra Malzeme Ekle";
            this.extraMalzemeEkleToolStripMenuItem.Click += new System.EventHandler(this.extraMalzemeEkleToolStripMenuItem_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 585);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparisYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisOlusturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraMalzemeEkleToolStripMenuItem;
    }
}