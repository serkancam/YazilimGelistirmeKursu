namespace Okul.Arayuz
{
    partial class SiniflaraDersAtamaEkrani
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDersAtaIslemleri = new System.Windows.Forms.GroupBox();
            this.gbDersler = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSiniflar = new System.Windows.Forms.ComboBox();
            this.dgvDersler = new System.Windows.Forms.DataGridView();
            this.btnDersSec = new System.Windows.Forms.Button();
            this.lbSecilenDersler = new System.Windows.Forms.ListBox();
            this.btnDersleriAktar = new System.Windows.Forms.Button();
            this.gbDersAtaIslemleri.SuspendLayout();
            this.gbDersler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDersAtaIslemleri
            // 
            this.gbDersAtaIslemleri.Controls.Add(this.btnDersleriAktar);
            this.gbDersAtaIslemleri.Controls.Add(this.lbSecilenDersler);
            this.gbDersAtaIslemleri.Controls.Add(this.btnDersSec);
            this.gbDersAtaIslemleri.Controls.Add(this.cbSiniflar);
            this.gbDersAtaIslemleri.Controls.Add(this.label1);
            this.gbDersAtaIslemleri.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbDersAtaIslemleri.Location = new System.Drawing.Point(0, 0);
            this.gbDersAtaIslemleri.Name = "gbDersAtaIslemleri";
            this.gbDersAtaIslemleri.Size = new System.Drawing.Size(226, 412);
            this.gbDersAtaIslemleri.TabIndex = 0;
            this.gbDersAtaIslemleri.TabStop = false;
            this.gbDersAtaIslemleri.Text = "Ders atama işlemleri";
            // 
            // gbDersler
            // 
            this.gbDersler.Controls.Add(this.dgvDersler);
            this.gbDersler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDersler.Location = new System.Drawing.Point(226, 0);
            this.gbDersler.Name = "gbDersler";
            this.gbDersler.Size = new System.Drawing.Size(568, 412);
            this.gbDersler.TabIndex = 1;
            this.gbDersler.TabStop = false;
            this.gbDersler.Text = "Dersler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sınıflar";
            // 
            // cbSiniflar
            // 
            this.cbSiniflar.FormattingEnabled = true;
            this.cbSiniflar.Location = new System.Drawing.Point(12, 60);
            this.cbSiniflar.Name = "cbSiniflar";
            this.cbSiniflar.Size = new System.Drawing.Size(155, 21);
            this.cbSiniflar.TabIndex = 1;
            // 
            // dgvDersler
            // 
            this.dgvDersler.AllowUserToAddRows = false;
            this.dgvDersler.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDersler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDersler.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDersler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDersler.Location = new System.Drawing.Point(3, 16);
            this.dgvDersler.Name = "dgvDersler";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDersler.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDersler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDersler.Size = new System.Drawing.Size(562, 393);
            this.dgvDersler.TabIndex = 0;
            // 
            // btnDersSec
            // 
            this.btnDersSec.Location = new System.Drawing.Point(12, 92);
            this.btnDersSec.Name = "btnDersSec";
            this.btnDersSec.Size = new System.Drawing.Size(155, 23);
            this.btnDersSec.TabIndex = 2;
            this.btnDersSec.Text = "Dersleri Seç";
            this.btnDersSec.UseVisualStyleBackColor = true;
            // 
            // lbSecilenDersler
            // 
            this.lbSecilenDersler.FormattingEnabled = true;
            this.lbSecilenDersler.Location = new System.Drawing.Point(12, 132);
            this.lbSecilenDersler.Name = "lbSecilenDersler";
            this.lbSecilenDersler.Size = new System.Drawing.Size(151, 95);
            this.lbSecilenDersler.TabIndex = 3;
            // 
            // btnDersleriAktar
            // 
            this.btnDersleriAktar.Location = new System.Drawing.Point(12, 246);
            this.btnDersleriAktar.Name = "btnDersleriAktar";
            this.btnDersleriAktar.Size = new System.Drawing.Size(151, 23);
            this.btnDersleriAktar.TabIndex = 4;
            this.btnDersleriAktar.Text = "Dersleri Aktar";
            this.btnDersleriAktar.UseVisualStyleBackColor = true;
            // 
            // SiniflaraDersAtamaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 412);
            this.Controls.Add(this.gbDersler);
            this.Controls.Add(this.gbDersAtaIslemleri);
            this.Name = "SiniflaraDersAtamaEkrani";
            this.Text = "SiniflaraDersAtamaEkrani";
            this.gbDersAtaIslemleri.ResumeLayout(false);
            this.gbDersAtaIslemleri.PerformLayout();
            this.gbDersler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDersAtaIslemleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDersler;
        private System.Windows.Forms.ComboBox cbSiniflar;
        private System.Windows.Forms.DataGridView dgvDersler;
        private System.Windows.Forms.Button btnDersleriAktar;
        private System.Windows.Forms.ListBox lbSecilenDersler;
        private System.Windows.Forms.Button btnDersSec;
    }
}