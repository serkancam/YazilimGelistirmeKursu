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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            msOgrenciEkleSilGüncelle.Click += new EventHandler(msOgrenciEkleSilGüncelle_Click);
            msiDersEkleSilGuncelle.Click += new EventHandler(msiDersEkleSilGuncelle_Click);
            msiOgretmenEkleSilGuncelle.Click += new EventHandler(msiOgretmenEkleSilGuncelle_Click);
            msDonemIslemleri.Click += new EventHandler(msDonemIslemleri_Click);
            msiSiniflaraDersAta.Click += new EventHandler(msiSiniflaraDersAta_Click);
            msTopluNotGirisi.Click += new EventHandler(msTopluNotGirisi_Click);
           
            
        }

        void msTopluNotGirisi_Click(object sender, EventArgs e)
        {
            NotIslemleriEkrani ni = new NotIslemleriEkrani();
            ni.MdiParent = this;
            ni.Show();
            
        }

        void msiSiniflaraDersAta_Click(object sender, EventArgs e)
        {
            SiniflaraDersAtamaEkrani dersAta = new SiniflaraDersAtamaEkrani();
            dersAta.MdiParent = this;
            dersAta.Show();
        }

        void msDonemIslemleri_Click(object sender, EventArgs e)
        {
            DonemIslemleri donem = new DonemIslemleri();
            donem.MdiParent = this;
            donem.Show();

        }

        void msiOgretmenEkleSilGuncelle_Click(object sender, EventArgs e)
        {
            OgretmenIslemleriEkrani ogretmen = new OgretmenIslemleriEkrani();
            ogretmen.MdiParent = this;
            ogretmen.Show();
        }

        void msiDersEkleSilGuncelle_Click(object sender, EventArgs e)
        {
            DersIslemleriEkrani ders = new DersIslemleriEkrani();
            ders.MdiParent = this;
            ders.Show();
        }
        

        void msOgrenciEkleSilGüncelle_Click(object sender, EventArgs e)
        {
            OgrenciIslemEkrani ogrenci = new OgrenciIslemEkrani();
            ogrenci.MdiParent = this;
            ogrenci.Show();
        }

       
    }
}
