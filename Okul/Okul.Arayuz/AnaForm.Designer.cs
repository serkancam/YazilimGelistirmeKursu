namespace Okul.Arayuz
{
    partial class AnaForm
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
            this.msMenum = new System.Windows.Forms.MenuStrip();
            this.msiOgrenciIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.msOgrenciEkleSilGüncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDersIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDersEkleSilGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSiniflaraDersAta = new System.Windows.Forms.ToolStripMenuItem();
            this.msiOgretmenIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.msiOgretmenEkleSilGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.msDonemler = new System.Windows.Forms.ToolStripMenuItem();
            this.msDonemIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.msNotIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.msTopluNotGirisi = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenum.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenum
            // 
            this.msMenum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiOgrenciIslemleri,
            this.msiDersIslemleri,
            this.msiOgretmenIslemleri,
            this.msDonemler,
            this.msNotIslemleri});
            this.msMenum.Location = new System.Drawing.Point(0, 0);
            this.msMenum.Name = "msMenum";
            this.msMenum.Size = new System.Drawing.Size(659, 24);
            this.msMenum.TabIndex = 1;
            this.msMenum.Text = "menuStrip1";
            // 
            // msiOgrenciIslemleri
            // 
            this.msiOgrenciIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msOgrenciEkleSilGüncelle});
            this.msiOgrenciIslemleri.Name = "msiOgrenciIslemleri";
            this.msiOgrenciIslemleri.Size = new System.Drawing.Size(108, 20);
            this.msiOgrenciIslemleri.Text = "Öğrenci işlemleri";
            // 
            // msOgrenciEkleSilGüncelle
            // 
            this.msOgrenciEkleSilGüncelle.Name = "msOgrenciEkleSilGüncelle";
            this.msOgrenciEkleSilGüncelle.Size = new System.Drawing.Size(208, 22);
            this.msOgrenciEkleSilGüncelle.Text = "Öğrenci Ekle-Sil-Güncelle";
            // 
            // msiDersIslemleri
            // 
            this.msiDersIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiDersEkleSilGuncelle,
            this.msiSiniflaraDersAta});
            this.msiDersIslemleri.Name = "msiDersIslemleri";
            this.msiDersIslemleri.Size = new System.Drawing.Size(89, 20);
            this.msiDersIslemleri.Text = "Ders işlemleri";
            // 
            // msiDersEkleSilGuncelle
            // 
            this.msiDersEkleSilGuncelle.Name = "msiDersEkleSilGuncelle";
            this.msiDersEkleSilGuncelle.Size = new System.Drawing.Size(189, 22);
            this.msiDersEkleSilGuncelle.Text = "Ders Ekle-Sil-Güncelle";
            // 
            // msiSiniflaraDersAta
            // 
            this.msiSiniflaraDersAta.Name = "msiSiniflaraDersAta";
            this.msiSiniflaraDersAta.Size = new System.Drawing.Size(189, 22);
            this.msiSiniflaraDersAta.Text = "Sınıflara Ders Ata";
            // 
            // msiOgretmenIslemleri
            // 
            this.msiOgretmenIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiOgretmenEkleSilGuncelle});
            this.msiOgretmenIslemleri.Name = "msiOgretmenIslemleri";
            this.msiOgretmenIslemleri.Size = new System.Drawing.Size(120, 20);
            this.msiOgretmenIslemleri.Text = "Öğretmen işlemleri";
            // 
            // msiOgretmenEkleSilGuncelle
            // 
            this.msiOgretmenEkleSilGuncelle.Name = "msiOgretmenEkleSilGuncelle";
            this.msiOgretmenEkleSilGuncelle.Size = new System.Drawing.Size(220, 22);
            this.msiOgretmenEkleSilGuncelle.Text = "Öğretmen Ekle-Sil-Güncelle";
            // 
            // msDonemler
            // 
            this.msDonemler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msDonemIslemleri});
            this.msDonemler.Name = "msDonemler";
            this.msDonemler.Size = new System.Drawing.Size(71, 20);
            this.msDonemler.Text = "Dönemler";
            // 
            // msDonemIslemleri
            // 
            this.msDonemIslemleri.Name = "msDonemIslemleri";
            this.msDonemIslemleri.Size = new System.Drawing.Size(160, 22);
            this.msDonemIslemleri.Text = "Dönem işlemleri";
            // 
            // msNotIslemleri
            // 
            this.msNotIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msTopluNotGirisi});
            this.msNotIslemleri.Name = "msNotIslemleri";
            this.msNotIslemleri.Size = new System.Drawing.Size(86, 20);
            this.msNotIslemleri.Text = "Not işlemleri";
            // 
            // msTopluNotGirisi
            // 
            this.msTopluNotGirisi.Name = "msTopluNotGirisi";
            this.msTopluNotGirisi.Size = new System.Drawing.Size(156, 22);
            this.msTopluNotGirisi.Text = "Toplu Not girişi";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 479);
            this.Controls.Add(this.msMenum);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenum;
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMenum.ResumeLayout(false);
            this.msMenum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenum;
        private System.Windows.Forms.ToolStripMenuItem msiOgrenciIslemleri;
        private System.Windows.Forms.ToolStripMenuItem msOgrenciEkleSilGüncelle;
        private System.Windows.Forms.ToolStripMenuItem msiDersIslemleri;
        private System.Windows.Forms.ToolStripMenuItem msiDersEkleSilGuncelle;
        private System.Windows.Forms.ToolStripMenuItem msiOgretmenIslemleri;
        private System.Windows.Forms.ToolStripMenuItem msiOgretmenEkleSilGuncelle;
        private System.Windows.Forms.ToolStripMenuItem msDonemler;
        private System.Windows.Forms.ToolStripMenuItem msDonemIslemleri;
        private System.Windows.Forms.ToolStripMenuItem msiSiniflaraDersAta;
        private System.Windows.Forms.ToolStripMenuItem msNotIslemleri;
        private System.Windows.Forms.ToolStripMenuItem msTopluNotGirisi;
    }
}