namespace Okul.Arayuz
{
    partial class OgretmenIslemleriEkrani
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
            this.gbOgretmenIslemleri = new System.Windows.Forms.GroupBox();
            this.gbOgretmenler = new System.Windows.Forms.GroupBox();
            this.dgvOgretmenler = new System.Windows.Forms.DataGridView();
            this.txtOgretmenTC = new System.Windows.Forms.MaskedTextBox();
            this.txtOgretmenSoyadi = new System.Windows.Forms.TextBox();
            this.txtOgretmenAdi = new System.Windows.Forms.TextBox();
            this.cbBranslar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.gbOgretmenIslemleri.SuspendLayout();
            this.gbOgretmenler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgretmenler)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOgretmenIslemleri
            // 
            this.gbOgretmenIslemleri.Controls.Add(this.btnGuncelle);
            this.gbOgretmenIslemleri.Controls.Add(this.btnSil);
            this.gbOgretmenIslemleri.Controls.Add(this.btnEkle);
            this.gbOgretmenIslemleri.Controls.Add(this.label4);
            this.gbOgretmenIslemleri.Controls.Add(this.label3);
            this.gbOgretmenIslemleri.Controls.Add(this.label2);
            this.gbOgretmenIslemleri.Controls.Add(this.label1);
            this.gbOgretmenIslemleri.Controls.Add(this.cbBranslar);
            this.gbOgretmenIslemleri.Controls.Add(this.txtOgretmenAdi);
            this.gbOgretmenIslemleri.Controls.Add(this.txtOgretmenSoyadi);
            this.gbOgretmenIslemleri.Controls.Add(this.txtOgretmenTC);
            this.gbOgretmenIslemleri.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbOgretmenIslemleri.Location = new System.Drawing.Point(0, 0);
            this.gbOgretmenIslemleri.Name = "gbOgretmenIslemleri";
            this.gbOgretmenIslemleri.Size = new System.Drawing.Size(176, 412);
            this.gbOgretmenIslemleri.TabIndex = 0;
            this.gbOgretmenIslemleri.TabStop = false;
            this.gbOgretmenIslemleri.Text = "Öğretmen işlemleri";
            // 
            // gbOgretmenler
            // 
            this.gbOgretmenler.Controls.Add(this.dgvOgretmenler);
            this.gbOgretmenler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOgretmenler.Location = new System.Drawing.Point(176, 0);
            this.gbOgretmenler.Name = "gbOgretmenler";
            this.gbOgretmenler.Size = new System.Drawing.Size(618, 412);
            this.gbOgretmenler.TabIndex = 1;
            this.gbOgretmenler.TabStop = false;
            this.gbOgretmenler.Text = "Öğretmenler listesi";
            // 
            // dgvOgretmenler
            // 
            this.dgvOgretmenler.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.dgvOgretmenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgretmenler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOgretmenler.Location = new System.Drawing.Point(3, 16);
            this.dgvOgretmenler.Name = "dgvOgretmenler";
            this.dgvOgretmenler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOgretmenler.Size = new System.Drawing.Size(612, 393);
            this.dgvOgretmenler.TabIndex = 0;
            // 
            // txtOgretmenTC
            // 
            this.txtOgretmenTC.Location = new System.Drawing.Point(12, 49);
            this.txtOgretmenTC.Mask = "00000000000";
            this.txtOgretmenTC.Name = "txtOgretmenTC";
            this.txtOgretmenTC.Size = new System.Drawing.Size(121, 20);
            this.txtOgretmenTC.TabIndex = 0;
            // 
            // txtOgretmenSoyadi
            // 
            this.txtOgretmenSoyadi.Location = new System.Drawing.Point(12, 169);
            this.txtOgretmenSoyadi.Name = "txtOgretmenSoyadi";
            this.txtOgretmenSoyadi.Size = new System.Drawing.Size(121, 20);
            this.txtOgretmenSoyadi.TabIndex = 2;
            // 
            // txtOgretmenAdi
            // 
            this.txtOgretmenAdi.Location = new System.Drawing.Point(12, 109);
            this.txtOgretmenAdi.Name = "txtOgretmenAdi";
            this.txtOgretmenAdi.Size = new System.Drawing.Size(121, 20);
            this.txtOgretmenAdi.TabIndex = 3;
            // 
            // cbBranslar
            // 
            this.cbBranslar.FormattingEnabled = true;
            this.cbBranslar.Location = new System.Drawing.Point(12, 229);
            this.cbBranslar.Name = "cbBranslar";
            this.cbBranslar.Size = new System.Drawing.Size(121, 21);
            this.cbBranslar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Öğretmen TC No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Öğretmen adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Öğretmen soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Branşlar";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 256);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(57, 23);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(75, 256);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(57, 23);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(41, 285);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(57, 23);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // OgretmenIslemleriEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 412);
            this.Controls.Add(this.gbOgretmenler);
            this.Controls.Add(this.gbOgretmenIslemleri);
            this.Name = "OgretmenIslemleriEkrani";
            this.Text = "OgretmenIslemleriEkrani";
            this.gbOgretmenIslemleri.ResumeLayout(false);
            this.gbOgretmenIslemleri.PerformLayout();
            this.gbOgretmenler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgretmenler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOgretmenIslemleri;
        private System.Windows.Forms.GroupBox gbOgretmenler;
        private System.Windows.Forms.DataGridView dgvOgretmenler;
        private System.Windows.Forms.ComboBox cbBranslar;
        private System.Windows.Forms.TextBox txtOgretmenAdi;
        private System.Windows.Forms.TextBox txtOgretmenSoyadi;
        private System.Windows.Forms.MaskedTextBox txtOgretmenTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
    }
}