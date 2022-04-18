
namespace OOP_Hamburgerci
{
    partial class SatisRaporu
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
            this.listTumSatislar = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCiro = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblToplamSatis = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblExtraGelir = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblMenuSatis = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listTumSatislar
            // 
            this.listTumSatislar.FormattingEnabled = true;
            this.listTumSatislar.ItemHeight = 15;
            this.listTumSatislar.Location = new System.Drawing.Point(13, 13);
            this.listTumSatislar.Name = "listTumSatislar";
            this.listTumSatislar.Size = new System.Drawing.Size(402, 364);
            this.listTumSatislar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCiro);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(440, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ciro";
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.Location = new System.Drawing.Point(20, 33);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(13, 15);
            this.lblCiro.TabIndex = 0;
            this.lblCiro.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblToplamSatis);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(440, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 81);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toplam Satis";
            // 
            // lblToplamSatis
            // 
            this.lblToplamSatis.AutoSize = true;
            this.lblToplamSatis.Location = new System.Drawing.Point(20, 33);
            this.lblToplamSatis.Name = "lblToplamSatis";
            this.lblToplamSatis.Size = new System.Drawing.Size(13, 15);
            this.lblToplamSatis.TabIndex = 0;
            this.lblToplamSatis.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblExtraGelir);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox3.Location = new System.Drawing.Point(440, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 81);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extra Malzeme Gelirleri";
            // 
            // lblExtraGelir
            // 
            this.lblExtraGelir.AutoSize = true;
            this.lblExtraGelir.Location = new System.Drawing.Point(20, 33);
            this.lblExtraGelir.Name = "lblExtraGelir";
            this.lblExtraGelir.Size = new System.Drawing.Size(13, 15);
            this.lblExtraGelir.TabIndex = 0;
            this.lblExtraGelir.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblMenuSatis);
            this.groupBox4.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox4.Location = new System.Drawing.Point(440, 292);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 81);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Menu Satiş Adedi";
            // 
            // lblMenuSatis
            // 
            this.lblMenuSatis.AutoSize = true;
            this.lblMenuSatis.Location = new System.Drawing.Point(20, 33);
            this.lblMenuSatis.Name = "lblMenuSatis";
            this.lblMenuSatis.Size = new System.Drawing.Size(13, 15);
            this.lblMenuSatis.TabIndex = 0;
            this.lblMenuSatis.Text = "0";
            // 
            // SatisRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 383);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listTumSatislar);
            this.Name = "SatisRaporu";
            this.Text = "SatisRaporu";
            this.Load += new System.EventHandler(this.SatisRaporu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listTumSatislar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCiro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblToplamSatis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblExtraGelir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblMenuSatis;
    }
}