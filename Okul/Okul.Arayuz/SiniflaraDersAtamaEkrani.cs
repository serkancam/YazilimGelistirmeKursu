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
    public partial class SiniflaraDersAtamaEkrani : Form
    {
        public void SiniflariGetir()
        {
            VarlikIslemleri.Siniflar sinifIslem = new VarlikIslemleri.Siniflar();
            cbSiniflar.DataSource = sinifIslem.SiniflariGetir();
            cbSiniflar.DisplayMember = "sinif";
            cbSiniflar.ValueMember = "sinifId";
        }
        public void DersleriGetir()
        {
            
            VarlikIslemleri.Dersler dersIslem = new VarlikIslemleri.Dersler();            
            dgvDersler.DataSource = dersIslem.DersleriGetir();       
            
            
            dgvDersler.Refresh();
        }

        public SiniflaraDersAtamaEkrani()
        {
            InitializeComponent();
            this.Load += new EventHandler(SiniflaraDersAtamaEkrani_Load);
            btnDersSec.Click += new EventHandler(btnDersSec_Click);
            btnDersleriAktar.Click += new EventHandler(btnDersleriAktar_Click);
        }

        void btnDersleriAktar_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lbSecilenDersler.Items.Count; i++)
            {
                Varliklar.SinifDersleri dersler = new Varliklar.SinifDersleri();
                VarlikIslemleri.SinifDersleri islem = new VarlikIslemleri.SinifDersleri();
                dersler.SinifId = int.Parse(cbSiniflar.SelectedValue.ToString());
                dersler.DersId = ((Varliklar.Dersler)lbSecilenDersler.Items[i]).DersId;

                if (islem.SiniflaraDersEkle(dersler) > 0)
                {
                    MessageBox.Show(dersler.SinifId.ToString() + " sınıfına " + dersler.DersId.ToString() + " dersi eklendi");
                }


              
            }
        }

        void btnDersSec_Click(object sender, EventArgs e)
        {            
            List<Varliklar.Dersler> secilen = new List<Varliklar.Dersler>();
            for (int i = 0; i < dgvDersler.SelectedRows.Count; i++)
            {
               Varliklar.Dersler ders = new Varliklar.Dersler();                
               ders.DersId =int.Parse( dgvDersler.SelectedRows[i].Cells["dersId"].Value.ToString());
               ders.DersAdi = dgvDersler.SelectedRows[i].Cells["dersAdi"].Value.ToString();
               secilen.Add(ders);               
            }
            lbSecilenDersler.DataSource = secilen;
            lbSecilenDersler.DisplayMember = "DersAdi";
            lbSecilenDersler.ValueMember = "DersId";
            
        }

        void SiniflaraDersAtamaEkrani_Load(object sender, EventArgs e)
        {
            SiniflariGetir();
            DersleriGetir();
        }

        
    }
}
