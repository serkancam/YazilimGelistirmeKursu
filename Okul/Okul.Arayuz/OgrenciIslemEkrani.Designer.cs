namespace Okul.Arayuz
{
    partial class OgrenciIslemEkrani
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbOgrenciIslemleri = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.cbSiniflar = new System.Windows.Forms.ComboBox();
            this.lblTc = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.MaskedTextBox();
            this.txtTC = new System.Windows.Forms.MaskedTextBox();
            this.gbOgrenciler = new System.Windows.Forms.GroupBox();
            this.dgvOgrenciler = new System.Windows.Forms.DataGridView();
            this.gbOgrenciIslemleri.SuspendLayout();
            this.gbOgrenciler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOgrenciIslemleri
            // 
            this.gbOgrenciIslemleri.Controls.Add(this.btnGuncelle);
            this.gbOgrenciIslemleri.Controls.Add(this.btnSil);
            this.gbOgrenciIslemleri.Controls.Add(this.btnEkle);
            this.gbOgrenciIslemleri.Controls.Add(this.label5);
            this.gbOgrenciIslemleri.Controls.Add(this.label4);
            this.gbOgrenciIslemleri.Controls.Add(this.label3);
            this.gbOgrenciIslemleri.Controls.Add(this.lbl2);
            this.gbOgrenciIslemleri.Controls.Add(this.cbSiniflar);
            this.gbOgrenciIslemleri.Controls.Add(this.lblTc);
            this.gbOgrenciIslemleri.Controls.Add(this.txtSoyadi);
            this.gbOgrenciIslemleri.Controls.Add(this.txtAdi);
            this.gbOgrenciIslemleri.Controls.Add(this.txtNo);
            this.gbOgrenciIslemleri.Controls.Add(this.txtTC);
            this.gbOgrenciIslemleri.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbOgrenciIslemleri.Location = new System.Drawing.Point(0, 0);
            this.gbOgrenciIslemleri.Name = "gbOgrenciIslemleri";
            this.gbOgrenciIslemleri.Size = new System.Drawing.Size(200, 412);
            this.gbOgrenciIslemleri.TabIndex = 0;
            this.gbOgrenciIslemleri.TabStop = false;
            this.gbOgrenciIslemleri.Text = "Öğrenci işlemleri";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(50, 316);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(58, 23);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.Control;
            this.btnSil.Location = new System.Drawing.Point(80, 287);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(58, 23);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(16, 287);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(58, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Öğrenci sınıfı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Öğrenci soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Öğrenci adı";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(16, 84);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(61, 13);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "Öğrenci No";
            // 
            // cbSiniflar
            // 
            this.cbSiniflar.FormattingEnabled = true;
            this.cbSiniflar.Location = new System.Drawing.Point(16, 259);
            this.cbSiniflar.Name = "cbSiniflar";
            this.cbSiniflar.Size = new System.Drawing.Size(121, 21);
            this.cbSiniflar.TabIndex = 4;
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(16, 33);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(61, 13);
            this.lblTc.TabIndex = 4;
            this.lblTc.Text = "Öğrenci TC";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(16, 208);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(121, 20);
            this.txtSoyadi.TabIndex = 3;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(16, 157);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(121, 20);
            this.txtAdi.TabIndex = 2;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(16, 106);
            this.txtNo.Mask = "0000";
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(121, 20);
            this.txtNo.TabIndex = 1;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(16, 55);
            this.txtTC.Mask = "00000000000";
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(121, 20);
            this.txtTC.TabIndex = 0;
            // 
            // gbOgrenciler
            // 
            this.gbOgrenciler.Controls.Add(this.dgvOgrenciler);
            this.gbOgrenciler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOgrenciler.Location = new System.Drawing.Point(200, 0);
            this.gbOgrenciler.Name = "gbOgrenciler";
            this.gbOgrenciler.Size = new System.Drawing.Size(594, 412);
            this.gbOgrenciler.TabIndex = 1;
            this.gbOgrenciler.TabStop = false;
            this.gbOgrenciler.Text = "Öğrenci Listesi";
            // 
            // dgvOgrenciler
            // 
            this.dgvOgrenciler.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOgrenciler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOgrenciler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOgrenciler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOgrenciler.Location = new System.Drawing.Point(3, 16);
            this.dgvOgrenciler.Name = "dgvOgrenciler";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOgrenciler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOgrenciler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOgrenciler.Size = new System.Drawing.Size(588, 393);
            this.dgvOgrenciler.TabIndex = 0;
            // 
            // OgrenciIslemEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 412);
            this.Controls.Add(this.gbOgrenciler);
            this.Controls.Add(this.gbOgrenciIslemleri);
            this.Name = "OgrenciIslemEkrani";
            this.Text = "OgrenciIslemEkrani";
            this.gbOgrenciIslemleri.ResumeLayout(false);
            this.gbOgrenciIslemleri.PerformLayout();
            this.gbOgrenciler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOgrenciIslemleri;
        private System.Windows.Forms.GroupBox gbOgrenciler;
        private System.Windows.Forms.DataGridView dgvOgrenciler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ComboBox cbSiniflar;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.MaskedTextBox txtNo;
        private System.Windows.Forms.MaskedTextBox txtTC;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
    }
}