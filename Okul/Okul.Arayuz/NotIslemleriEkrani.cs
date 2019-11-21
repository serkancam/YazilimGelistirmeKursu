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
    public partial class NotIslemleriEkrani : Form
    {
        public NotIslemleriEkrani()
        {
            InitializeComponent();
            this.Load += new EventHandler(NotIslemleriEkrani_Load);
            cbSiniflar.SelectionChangeCommitted += new EventHandler(cbSiniflar_SelectionChangeCommitted);
            btnSec.Click += new EventHandler(btnSec_Click);
            dgvOgrenciler.CellClick += new DataGridViewCellEventHandler(dgvOgrenciler_CellClick);
           
        }


        public void DonemleriGetir()
        {
            VarlikIslemleri.Donemler di = new VarlikIslemleri.Donemler();
            cbDonemler.DataSource = di.DonemleriBirlestirGetir();
            cbDonemler.DisplayMember = "donem";
            cbDonemler.ValueMember = "donemId";
        }

        public void SiniflariGetir()
        {
            VarlikIslemleri.Siniflar si = new VarlikIslemleri.Siniflar();
            cbSiniflar.DataSource = si.SiniflariGetir();
            cbSiniflar.DisplayMember = "sinif";
            cbSiniflar.ValueMember = "sinifId";
 
        }

        public void SinifaAitDersleriGetir(int id)
        {
            Varliklar.Siniflar s = new Varliklar.Siniflar();
            VarlikIslemleri.Siniflar si = new VarlikIslemleri.Siniflar();
            s.SinifId = id;
            cbDersler.DataSource = si.SinifaAitDersleriGetir(s);
            cbDersler.DisplayMember = "dersAdi";
            cbDersler.ValueMember = "dersId";


 
        }

        public void NotlariYerlestir(DataTable dt)
        {

            foreach (DataRow item in dt.Rows)
            {
                if (int.Parse(item["turId"].ToString()) == 1)
                {
                    txtSinav1.Text = item["puani"].ToString();
                }
                else if (int.Parse(item["turId"].ToString()) == 2)
                {
                    txtSinav2.Text = item["puani"].ToString();
                }
                else if (int.Parse(item["turId"].ToString()) == 3)
                {
                    txtSinav3.Text = item["puani"].ToString();
                }
                else if (int.Parse(item["turId"].ToString()) == 6)
                {
                    txtSozlu1.Text = item["puani"].ToString();
                }
                else if (int.Parse(item["turId"].ToString()) == 7)
                {
                    txtSozlu2.Text = item["puani"].ToString();
                }
                else if (int.Parse(item["turId"].ToString()) == 8)
                {
                    txtSozlu3.Text = item["puani"].ToString();
                }
                else { ; }


            }
        }

        public void OrtalamaHesapla()
        {
            double toplam = 0;
            int adet = 0;
            foreach (Control c in gbNotlar.Controls)
            {
                if((c is TextBox) && c.Name!="txtOrtalama")
                {
                    if(c.Text!="")
                    {
                        adet++;
                        toplam += double.Parse(c.Text);
                    }
                }
                
            }
            if (adet == 0)
            { txtOrtalama.Text = "0"; }
            else
            { txtOrtalama.Text = (toplam / adet).ToString(); }
        }

        public void NotlariSifirla()
        {
            foreach (Control c in gbNotlar.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }        

        void dgvOgrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NotlariSifirla();

            Varliklar.Notlar not = new Varliklar.Notlar();
            VarlikIslemleri.Notlar notIslem = new VarlikIslemleri.Notlar();

            not.Donem = int.Parse( cbDonemler.SelectedValue.ToString());
            not.DersId = int.Parse(cbDersler.SelectedValue.ToString());
            not.Ogrenci = dgvOgrenciler["ogrenciTc", dgvOgrenciler.CurrentCell.RowIndex].Value.ToString();
            DataTable dt = notIslem.OgrencininDonemeAitDersNotlariniGetir(not);
            NotlariYerlestir(dt);
            OrtalamaHesapla();
           


            

        }

        void btnSec_Click(object sender, EventArgs e)
        {
            Varliklar.Ogrenci o=new Okul.Varliklar.Ogrenci();
            VarlikIslemleri.Ogrenci oi=new Okul.VarlikIslemleri.Ogrenci();

            o.Sinif =int.Parse( cbSiniflar.SelectedValue.ToString());

            dgvOgrenciler.DataSource = oi.SinifinOgrencileriniGetir(o);

            dgvOgrenciler.Refresh();

            

        }

        void cbSiniflar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SinifaAitDersleriGetir(int.Parse(cbSiniflar.SelectedValue.ToString()));
        }

        void NotIslemleriEkrani_Load(object sender, EventArgs e)
        {
            DonemleriGetir();
            SiniflariGetir();
        }
    }
}
