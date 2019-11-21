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
    public partial class OgrenciIslemEkrani : Form
    {
       

        public OgrenciIslemEkrani()
        {
            InitializeComponent();
            this.Load += new EventHandler(OgrenciIslemEkrani_Load);
            btnEkle.Click += new EventHandler(btnEkle_Click);
            btnSil.Click += new EventHandler(btnSil_Click);
            btnGuncelle.Click += new EventHandler(btnGuncelle_Click);
            dgvOgrenciler.CellDoubleClick += new DataGridViewCellEventHandler(dgvOgrenciler_CellDoubleClick);
            
        }

        void dgvOgrenciler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtTC.Text = dgvOgrenciler["ogrenciTc", dgvOgrenciler.CurrentCell.RowIndex].Value.ToString();
            txtNo.Text = dgvOgrenciler["ogrenciNo", dgvOgrenciler.CurrentCell.RowIndex].Value.ToString();
            txtAdi.Text = dgvOgrenciler["ogrenciAdi", dgvOgrenciler.CurrentCell.RowIndex].Value.ToString();
            txtSoyadi.Text = dgvOgrenciler["ogrenciSoyadi", dgvOgrenciler.CurrentCell.RowIndex].Value.ToString();
            cbSiniflar.SelectedValue = dgvOgrenciler["sinif", dgvOgrenciler.CurrentCell.RowIndex].Value.ToString();

        }

        void btnGuncelle_Click(object sender, EventArgs e)
        {
          
            Varliklar.Ogrenci ogrenci = new Okul.Varliklar.Ogrenci();
            VarlikIslemleri.Ogrenci islem = new Okul.VarlikIslemleri.Ogrenci();
            ogrenci.OgrenciTC = txtTC.Text;
            ogrenci.OgrenciNo = txtNo.Text;
            ogrenci.OgrenciAdi = txtAdi.Text.ToUpper();
            ogrenci.OgrenciSoyadi = txtSoyadi.Text.ToUpper();
            ogrenci.Sinif = int.Parse(cbSiniflar.SelectedValue.ToString());
            if (islem.OgrenciGuncelle(ogrenci) > 0)
            {
                MessageBox.Show("Öğrenci Güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Öğrenci güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            OgrenciListesiCek();
        }

        void btnSil_Click(object sender, EventArgs e)
        {
           
            Varliklar.Ogrenci ogrenci = new Okul.Varliklar.Ogrenci();         
            VarlikIslemleri.Ogrenci islem = new Okul.VarlikIslemleri.Ogrenci();          
            ogrenci.OgrenciTC = txtTC.Text;                
            if (islem.OgrenciSil(ogrenci) > 0)
            {
                MessageBox.Show("Öğrenci silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Öğrenci silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            OgrenciListesiCek();
        }

        void btnEkle_Click(object sender, EventArgs e)
        {
            //varlıklar projesindeki Ogrenci sınıfından bir nesne türettim
            //bu nesne varlıkişlemleri sınıfındak ekleme işlemine 
            //parametre olarak aktarılacak
            Varliklar.Ogrenci ogrenci = new Okul.Varliklar.Ogrenci();
            
            //varlık işlemleri Ogrenci sınıfından ekleme methodunu kullanacağım
            //bir nesne türettim. bu metot ogrenci varlığını parametre olarak alacak
            VarlikIslemleri.Ogrenci islem = new Okul.VarlikIslemleri.Ogrenci();
           
            //varlıklar projesindeki Ogrenci sınıfından   türettiğim ogrenci nesnesinin
            //özelliklerine(properties) textbox,combobox vb kontrollerden kullanıcının
            //girdiği değerleri aktardım
            ogrenci.OgrenciTC = txtTC.Text;
            ogrenci.OgrenciNo = txtNo.Text;
            ogrenci.OgrenciAdi = txtAdi.Text.ToUpper();
            ogrenci.OgrenciSoyadi = txtSoyadi.Text.ToUpper();
            ogrenci.Sinif = int.Parse(cbSiniflar.SelectedValue.ToString());

            
            if (islem.OgrenciEkle(ogrenci) > 0)
            {
                MessageBox.Show("Öğrenci eklendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Öğrenci eklenemedidi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
 
            }
            OgrenciListesiCek();



        }

        public void SiniflariDoldur()
        {
            VarlikIslemleri.Siniflar sinif = new Okul.VarlikIslemleri.Siniflar();
            cbSiniflar.DataSource = sinif.SiniflariGetir();
            cbSiniflar.DisplayMember = "sinif";
            cbSiniflar.ValueMember = "sinifId";        
        }

        public void OgrenciListesiCek()
        {
            VarlikIslemleri.Ogrenci ogrenci = new Okul.VarlikIslemleri.Ogrenci();
            dgvOgrenciler.DataSource = ogrenci.OgrencleriGetir();
            dgvOgrenciler.Columns["sinif"].Visible = false;
            dgvOgrenciler.Refresh();
        }

        void OgrenciIslemEkrani_Load(object sender, EventArgs e)
        {
            SiniflariDoldur();
            OgrenciListesiCek();
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {

        }
    }
}
