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
    public partial class DonemIslemleri : Form
    {
        public void YilDoldur()
        {
            for (int i = 2000; i < 2050; i++)
            {
              cbYili.Items.Add(i.ToString() + "-" + (i + 1).ToString());
            }
        }

        public void DonemleriGetir()
        {
            VarlikIslemleri.Donemler donem = new Okul.VarlikIslemleri.Donemler();
            dgvDonemler.DataSource = donem.DonemleriGetir();
            dgvDonemler.Refresh();

        }

        public DonemIslemleri()
        {
            InitializeComponent();
            this.Load += new EventHandler(DonemIslemleri_Load);
            dgvDonemler.CellDoubleClick += new DataGridViewCellEventHandler(dgvDonemler_CellDoubleClick);
            btnEkle.Click += new EventHandler(btnEkle_Click);
            btnSil.Click += new EventHandler(btnSil_Click);
            btnGuncelle.Click += new EventHandler(btnGuncelle_Click);
            
        }

        void btnGuncelle_Click(object sender, EventArgs e)
        {
            Varliklar.Donemler donem = new Varliklar.Donemler();
            VarlikIslemleri.Donemler donemIslem = new VarlikIslemleri.Donemler();
            donem.DonemId = int.Parse(txtDonemId.Text);
            donem.Yili = cbYili.SelectedItem.ToString();
            donem.Donem = short.Parse(cbDonem.SelectedItem.ToString());
            DialogResult result = MessageBox.Show(cbYili.SelectedItem.ToString() + " yili " + cbDonem.SelectedItem.ToString() + ". dönemini Güncellemek istiyor musunuz?", "Silme işlmei", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                if (donemIslem.DonemGuncelle(donem) > 0)
                {
                    MessageBox.Show("Dönem Güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Dönem Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                DonemleriGetir();
            }
        }

        void btnSil_Click(object sender, EventArgs e)
        {
            Varliklar.Donemler donem = new Varliklar.Donemler();
            VarlikIslemleri.Donemler donemIslem = new VarlikIslemleri.Donemler();
            donem.DonemId = int.Parse(txtDonemId.Text);
            DialogResult result = MessageBox.Show(cbYili.SelectedItem.ToString() + " yili " + cbDonem.SelectedItem.ToString() + ". dönemini silmek istiyor musunuz?", "Silme işlmei", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                if (donemIslem.DonemSil(donem) > 0)
                {
                    MessageBox.Show("Dönem Silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Dönem Silinmedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                DonemleriGetir();
            }


        }

        void btnEkle_Click(object sender, EventArgs e)
        {
            Varliklar.Donemler donem = new Varliklar.Donemler();
            VarlikIslemleri.Donemler donemIslem = new VarlikIslemleri.Donemler();

            donem.Yili = cbYili.SelectedItem.ToString();
            donem.Donem = short.Parse(cbDonem.SelectedItem.ToString());
            if (donemIslem.DonemEkle(donem)>0)
            {
                MessageBox.Show("Dönem Eklendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dönem Eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            DonemleriGetir();
        }

        void dgvDonemler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDonemId.Text = dgvDonemler["donemId", dgvDonemler.CurrentCell.RowIndex].Value.ToString();
            cbYili.SelectedItem = dgvDonemler["yili", dgvDonemler.CurrentCell.RowIndex].Value.ToString();
            cbDonem.SelectedItem=  dgvDonemler["donem", dgvDonemler.CurrentCell.RowIndex].Value.ToString();

        }

        void DonemIslemleri_Load(object sender, EventArgs e)
        {
            DonemleriGetir();
            YilDoldur();
            cbYili.SelectedIndex = 0;
            cbDonem.SelectedIndex = 0;
        }


    }
}
