namespace Okul.Arayuz
{
    partial class DersIslemleriEkrani
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
            this.gbDersIslemleri = new System.Windows.Forms.GroupBox();
            this.gbDersler = new System.Windows.Forms.GroupBox();
            this.dgvDersler = new System.Windows.Forms.DataGridView();
            this.txtDersId = new System.Windows.Forms.TextBox();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.txtDersAciklama = new System.Windows.Forms.TextBox();
            this.cbOgretmenler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.gbDersIslemleri.SuspendLayout();
            this.gbDersler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDersIslemleri
            // 
            this.gbDersIslemleri.Controls.Add(this.btnGuncelle);
            this.gbDersIslemleri.Controls.Add(this.btnSil);
            this.gbDersIslemleri.Controls.Add(this.btnEkle);
            this.gbDersIslemleri.Controls.Add(this.label4);
            this.gbDersIslemleri.Controls.Add(this.label3);
            this.gbDersIslemleri.Controls.Add(this.label2);
            this.gbDersIslemleri.Controls.Add(this.label1);
            this.gbDersIslemleri.Controls.Add(this.cbOgretmenler);
            this.gbDersIslemleri.Controls.Add(this.txtDersAciklama);
            this.gbDersIslemleri.Controls.Add(this.txtDersAdi);
            this.gbDersIslemleri.Controls.Add(this.txtDersId);
            this.gbDersIslemleri.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbDersIslemleri.Location = new System.Drawing.Point(0, 0);
            this.gbDersIslemleri.Name = "gbDersIslemleri";
            this.gbDersIslemleri.Size = new System.Drawing.Size(207, 412);
            this.gbDersIslemleri.TabIndex = 0;
            this.gbDersIslemleri.TabStop = false;
            this.gbDersIslemleri.Text = "Ders işlmleri";
            // 
            // gbDersler
            // 
            this.gbDersler.Controls.Add(this.dgvDersler);
            this.gbDersler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDersler.Location = new System.Drawing.Point(207, 0);
            this.gbDersler.Name = "gbDersler";
            this.gbDersler.Size = new System.Drawing.Size(587, 412);
            this.gbDersler.TabIndex = 1;
            this.gbDersler.TabStop = false;
            this.gbDersler.Text = "Ders işlemleri";
            // 
            // dgvDersler
            // 
            this.dgvDersler.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.dgvDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDersler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDersler.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDersler.Location = new System.Drawing.Point(3, 16);
            this.dgvDersler.Name = "dgvDersler";
            this.dgvDersler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDersler.Size = new System.Drawing.Size(581, 393);
            this.dgvDersler.TabIndex = 0;
            // 
            // txtDersId
            // 
            this.txtDersId.Location = new System.Drawing.Point(22, 55);
            this.txtDersId.Name = "txtDersId";
            this.txtDersId.ReadOnly = true;
            this.txtDersId.Size = new System.Drawing.Size(121, 20);
            this.txtDersId.TabIndex = 0;
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(22, 115);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(121, 20);
            this.txtDersAdi.TabIndex = 1;
            // 
            // txtDersAciklama
            // 
            this.txtDersAciklama.Location = new System.Drawing.Point(22, 175);
            this.txtDersAciklama.Name = "txtDersAciklama";
            this.txtDersAciklama.Size = new System.Drawing.Size(121, 20);
            this.txtDersAciklama.TabIndex = 2;
            // 
            // cbOgretmenler
            // 
            this.cbOgretmenler.FormattingEnabled = true;
            this.cbOgretmenler.Location = new System.Drawing.Point(22, 235);
            this.cbOgretmenler.Name = "cbOgretmenler";
            this.cbOgretmenler.Size = new System.Drawing.Size(121, 21);
            this.cbOgretmenler.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ders kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ders adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ders açıklaması";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Öğretmenler";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(22, 262);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(57, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(86, 262);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(57, 23);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(58, 291);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(57, 23);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // DersIslemleriEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 412);
            this.Controls.Add(this.gbDersler);
            this.Controls.Add(this.gbDersIslemleri);
            this.Name = "DersIslemleriEkrani";
            this.Text = "DersIslemleriEkrani";
            this.gbDersIslemleri.ResumeLayout(false);
            this.gbDersIslemleri.PerformLayout();
            this.gbDersler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDersIslemleri;
        private System.Windows.Forms.GroupBox gbDersler;
        private System.Windows.Forms.DataGridView dgvDersler;
        private System.Windows.Forms.ComboBox cbOgretmenler;
        private System.Windows.Forms.TextBox txtDersAciklama;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.TextBox txtDersId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
    }
}