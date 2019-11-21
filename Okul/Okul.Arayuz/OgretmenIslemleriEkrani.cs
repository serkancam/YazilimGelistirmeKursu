using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Okul.Arayuz
{
    public partial class OgretmenIslemleriEkrani : Form
    {
        public void OgretmenListele()
        {
            VarlikIslemleri.Ogretmenler ogretmen = new Okul.VarlikIslemleri.Ogretmenler();
            dgvOgretmenler.DataSource = ogretmen.OgtretmenleriGetir();
            dgvOgretmenler.Columns["ogretmenAdi"].Visible = false;
            dgvOgretmenler.Columns["ogretmenSoyadi"].Visible = false;
            dgvOgretmenler.Refresh();
        }

        public void BranslariGetir()
        {
            VarlikIslemleri.Branslar brans = new Okul.VarlikIslemleri.Branslar();
            cbBranslar.DataSource = brans.BranslariGetir();
            cbBranslar.DisplayMember = "adi";
            cbBranslar.ValueMember = "id";
        }

        public OgretmenIslemleriEkrani()
        {
            InitializeComponent();
            this.Load += new EventHandler(OgretmenIslemleriEkrani_Load);
            dgvOgretmenler.CellDoubleClick += new DataGridViewCellEventHandler(dgvOgretmenler_CellDoubleClick);
            btnEkle.Click += new EventHandler(btnEkle_Click);
            btnSil.Click += new EventHandler(btnSil_Click);
            btnGuncelle.Click += new EventHandler(btnGuncelle_Click);
        }

        void btnGuncelle_Click(object sender, EventArgs e)
        {
            Varliklar.Ogretmenler ogretmen = new Okul.Varliklar.Ogretmenler();
            VarlikIslemleri.Ogretmenler ogretmenIslem = new Okul.VarlikIslemleri.Ogretmenler();

            ogretmen.OgretmenTc = txtOgretmenTC.Text;
            ogretmen.OgretmenAdi = txtOgretmenAdi.Text.ToUpper();
            ogretmen.OgretmenSoyadi = txtOgretmenSoyadi.Text.ToUpper();
            ogretmen.Bransi = int.Parse(cbBranslar.SelectedValue.ToString());

            if (ogretmenIslem.OgretmenGuncelle(ogretmen) > 0)
            {
                MessageBox.Show("Öğretmen Güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Öğretmen Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            OgretmenListele();
        }

        void btnSil_Click(object sender, EventArgs e)
        {
            Varliklar.Ogretmenler ogretmen = new Okul.Varliklar.Ogretmenler();
            VarlikIslemleri.Ogretmenler ogretmenIslem = new Okul.VarlikIslemleri.Ogretmenler();

            ogretmen.OgretmenTc = txtOgretmenTC.Text;
            ogretmen.OgretmenAdi = txtOgretmenAdi.Text;
            ogretmen.OgretmenSoyadi = txtOgretmenSoyadi.Text;
            ogretmen.Bransi = int.Parse(cbBranslar.SelectedValue.ToString());

            if (ogretmenIslem.OgretmenSil(ogretmen) > 0)
            {
                MessageBox.Show("Öğretmen Silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Öğretmen Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            OgretmenListele();
        }

        void btnEkle_Click(object sender, EventArgs e)
        {
            Varliklar.Ogretmenler ogretmen = new Okul.Varliklar.Ogretmenler();
            VarlikIslemleri.Ogretmenler ogretmenIslem = new Okul.VarlikIslemleri.Ogretmenler();

            ogretmen.OgretmenTc = txtOgretmenTC.Text;
            ogretmen.OgretmenAdi = txtOgretmenAdi.Text.ToUpper();
            ogretmen.OgretmenSoyadi = txtOgretmenSoyadi.Text.ToUpper();
            ogretmen.Bransi =int.Parse(cbBranslar.SelectedValue.ToString());

            if (ogretmenIslem.OgretmenEkle(ogretmen) > 0)
            {
                MessageBox.Show("Öğretmen eklendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Öğretmen eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            OgretmenListele();



        }

        void dgvOgretmenler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOgretmenTC.Text = dgvOgretmenler["ogretmenTC", dgvOgretmenler.CurrentCell.RowIndex].Value.ToString();
            txtOgretmenAdi.Text = dgvOgretmenler["ogretmenAdi", dgvOgretmenler.CurrentCell.RowIndex].Value.ToString();
            txtOgretmenSoyadi.Text = dgvOgretmenler["ogretmenSoyadi", dgvOgretmenler.CurrentCell.RowIndex].Value.ToString();
            cbBranslar.SelectedValue = dgvOgretmenler["bransi", dgvOgretmenler.CurrentCell.RowIndex].Value.ToString();
        }

        void OgretmenIslemleriEkrani_Load(object sender, EventArgs e)
        {
            OgretmenListele();
            BranslariGetir();
        }
    }
}
