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
    public partial class DersIslemleriEkrani : Form
    {
        public void DersleriListele()
        {
            VarlikIslemleri.Dersler ders = new Okul.VarlikIslemleri.Dersler();
            dgvDersler.DataSource = ders.DersleriGetir();
            dgvDersler.Refresh();
        }

        public void OgretmenleriGetir()
        {
            VarlikIslemleri.Ogretmenler ogretmen=new Okul.VarlikIslemleri.Ogretmenler();

            cbOgretmenler.DataSource = ogretmen.OgtretmenleriGetir();
            cbOgretmenler.DisplayMember = "adi";
            cbOgretmenler.ValueMember = "ogretmenTC";
        }

        public DersIslemleriEkrani()
        {
            InitializeComponent();
            this.Load += new EventHandler(DersIslemleriEkrani_Load);
            dgvDersler.CellDoubleClick += new DataGridViewCellEventHandler(DgvDersler_CellDoubleClick);
            btnEkle.Click += new EventHandler(BtnEkle_Click);
            btnSil.Click += new EventHandler(BtnSil_Click);
            btnGuncelle.Click += new EventHandler(BtnGuncelle_Click);

        }

        void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Varliklar.Dersler ders = new Okul.Varliklar.Dersler();
            VarlikIslemleri.Dersler dersIslem = new Okul.VarlikIslemleri.Dersler();
            ders.DersId = int.Parse(txtDersId.Text);
            ders.DersAdi = txtDersAdi.Text;
            ders.DersAciklama = txtDersAciklama.Text;
            ders.DersOgretmeni = cbOgretmenler.SelectedValue.ToString();
            
            DialogResult secim = MessageBox.Show(txtDersId.Text + " id li \"" + txtDersAdi.Text + "\" dersini Güncellemek istiyor musunuz?", "Güncelleme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                if (dersIslem.DersGuncelle(ders) > 0)
                {
                    MessageBox.Show("Ders Güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ders Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }

            }

            DersleriListele();
        }

        void BtnSil_Click(object sender, EventArgs e)
        {
            Varliklar.Dersler ders = new Okul.Varliklar.Dersler();
            VarlikIslemleri.Dersler dersIslem = new Okul.VarlikIslemleri.Dersler();
            ders.DersId = int.Parse( txtDersId.Text);
            DialogResult secim = MessageBox.Show(txtDersId.Text + " id li \"" + txtDersAdi.Text + "\" dersini silmek istiyor musunuz?", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                if (dersIslem.DersSil(ders) > 0)
                {
                    MessageBox.Show("Ders Silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ders Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);return;
                }
 
            }
            
            DersleriListele();
        }

        void BtnEkle_Click(object sender, EventArgs e)
        {
            Varliklar.Dersler ders = new Okul.Varliklar.Dersler();
            VarlikIslemleri.Dersler dersIslem = new Okul.VarlikIslemleri.Dersler();

            ders.DersAdi = txtDersAdi.Text;
            ders.DersAciklama = txtDersAciklama.Text;
            ders.DersOgretmeni = cbOgretmenler.SelectedValue.ToString();

            if (dersIslem.DersEkle(ders)>0)
            {
                MessageBox.Show("Ders eklendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ders eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            DersleriListele();

        }

        void DgvDersler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDersId.Text = dgvDersler["dersId", dgvDersler.CurrentCell.RowIndex].Value.ToString();
            txtDersAdi.Text = dgvDersler["dersAdi", dgvDersler.CurrentCell.RowIndex].Value.ToString();
            txtDersAciklama.Text = dgvDersler["dersAciklama", dgvDersler.CurrentCell.RowIndex].Value.ToString();
            cbOgretmenler.SelectedValue = dgvDersler["dersOgretmeni", dgvDersler.CurrentCell.RowIndex].Value.ToString();
        }

        void DersIslemleriEkrani_Load(object sender, EventArgs e)
        {
            DersleriListele();
            OgretmenleriGetir();
        }
    }
}
