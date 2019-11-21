namespace Okul.Arayuz
{
    partial class DonemIslemleri
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
            this.gbDonemIslemleri = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDonem = new System.Windows.Forms.ComboBox();
            this.cbYili = new System.Windows.Forms.ComboBox();
            this.txtDonemId = new System.Windows.Forms.TextBox();
            this.gbDonemler = new System.Windows.Forms.GroupBox();
            this.dgvDonemler = new System.Windows.Forms.DataGridView();
            this.gbDonemIslemleri.SuspendLayout();
            this.gbDonemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonemler)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDonemIslemleri
            // 
            this.gbDonemIslemleri.Controls.Add(this.btnGuncelle);
            this.gbDonemIslemleri.Controls.Add(this.btnSil);
            this.gbDonemIslemleri.Controls.Add(this.btnEkle);
            this.gbDonemIslemleri.Controls.Add(this.label3);
            this.gbDonemIslemleri.Controls.Add(this.label2);
            this.gbDonemIslemleri.Controls.Add(this.label1);
            this.gbDonemIslemleri.Controls.Add(this.cbDonem);
            this.gbDonemIslemleri.Controls.Add(this.cbYili);
            this.gbDonemIslemleri.Controls.Add(this.txtDonemId);
            this.gbDonemIslemleri.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbDonemIslemleri.Location = new System.Drawing.Point(0, 0);
            this.gbDonemIslemleri.Name = "gbDonemIslemleri";
            this.gbDonemIslemleri.Size = new System.Drawing.Size(200, 412);
            this.gbDonemIslemleri.TabIndex = 0;
            this.gbDonemIslemleri.TabStop = false;
            this.gbDonemIslemleri.Text = "Dönem işlemleri";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(54, 220);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(58, 23);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(88, 191);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(58, 23);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(25, 191);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(58, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Eğitim Dönemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Eğitim Yılı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dönem Kodu";
            // 
            // cbDonem
            // 
            this.cbDonem.FormattingEnabled = true;
            this.cbDonem.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbDonem.Location = new System.Drawing.Point(25, 164);
            this.cbDonem.Name = "cbDonem";
            this.cbDonem.Size = new System.Drawing.Size(121, 21);
            this.cbDonem.TabIndex = 2;
            // 
            // cbYili
            // 
            this.cbYili.FormattingEnabled = true;
            this.cbYili.Location = new System.Drawing.Point(25, 111);
            this.cbYili.Name = "cbYili";
            this.cbYili.Size = new System.Drawing.Size(121, 21);
            this.cbYili.TabIndex = 1;
            // 
            // txtDonemId
            // 
            this.txtDonemId.Location = new System.Drawing.Point(25, 59);
            this.txtDonemId.Name = "txtDonemId";
            this.txtDonemId.ReadOnly = true;
            this.txtDonemId.Size = new System.Drawing.Size(121, 20);
            this.txtDonemId.TabIndex = 0;
            // 
            // gbDonemler
            // 
            this.gbDonemler.Controls.Add(this.dgvDonemler);
            this.gbDonemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDonemler.Location = new System.Drawing.Point(200, 0);
            this.gbDonemler.Name = "gbDonemler";
            this.gbDonemler.Size = new System.Drawing.Size(594, 412);
            this.gbDonemler.TabIndex = 1;
            this.gbDonemler.TabStop = false;
            this.gbDonemler.Text = "Dönemler";
            // 
            // dgvDonemler
            // 
            this.dgvDonemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonemler.Location = new System.Drawing.Point(3, 16);
            this.dgvDonemler.Name = "dgvDonemler";
            this.dgvDonemler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonemler.Size = new System.Drawing.Size(588, 393);
            this.dgvDonemler.TabIndex = 0;
            // 
            // DonemIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 412);
            this.Controls.Add(this.gbDonemler);
            this.Controls.Add(this.gbDonemIslemleri);
            this.Name = "DonemIslemleri";
            this.Text = "DonemIslemleri";
            this.gbDonemIslemleri.ResumeLayout(false);
            this.gbDonemIslemleri.PerformLayout();
            this.gbDonemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonemler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDonemIslemleri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDonem;
        private System.Windows.Forms.ComboBox cbYili;
        private System.Windows.Forms.TextBox txtDonemId;
        private System.Windows.Forms.GroupBox gbDonemler;
        private System.Windows.Forms.DataGridView dgvDonemler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
    }
}