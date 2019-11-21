using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Okul.VarlikIslemleri
{
    public class Ogretmenler:VTIslemler
    {
        public int OgretmenEkle(Varliklar.Ogretmenler ogretmen)
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "insert into ogretmenler(ogretmenTc,ogretmenAdi,ogretmenSoyadi,bransi) values(@tc,@adi,@soyadi,@bransi)";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            cmd.Parameters.Add("@tc", SqlDbType.Char, 11).Value = ogretmen.OgretmenTc;
            cmd.Parameters.Add("@adi", SqlDbType.VarChar, 50).Value = ogretmen.OgretmenAdi;
            cmd.Parameters.Add("@soyadi", SqlDbType.VarChar, 50).Value = ogretmen.OgretmenSoyadi;
            cmd.Parameters.Add("@bransi", SqlDbType.Int).Value = ogretmen.Bransi;
            return base.ExecuteQuery(cmd);
        }

        public int OgretmenSil(Varliklar.Ogretmenler ogretmen)
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "delete from ogretmenler where ogretmenTc=@tc";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            cmd.Parameters.Add("@tc", SqlDbType.Char, 11).Value = ogretmen.OgretmenTc;
            return base.ExecuteQuery(cmd);
        }

        public int OgretmenGuncelle(Varliklar.Ogretmenler ogretmen)
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "update ogretmenler set ogretmenAdi=@adi,ogretmenSoyadi=@soyadi,bransi=@bransi where ogretmenTC=@tc";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            
            cmd.Parameters.Add("@adi", SqlDbType.VarChar, 50).Value = ogretmen.OgretmenAdi;
            cmd.Parameters.Add("@soyadi", SqlDbType.VarChar, 50).Value = ogretmen.OgretmenSoyadi;
            cmd.Parameters.Add("@bransi", SqlDbType.Int).Value = ogretmen.Bransi;
            cmd.Parameters.Add("@tc", SqlDbType.Char, 11).Value = ogretmen.OgretmenTc;

            return base.ExecuteQuery(cmd);
        }

        public DataTable OgtretmenleriGetir()
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "select ogretmenTC,ogretmenAdi+' '+ogretmenSoyadi as adi,ogretmenAdi,ogretmenSoyadi, bransi from ogretmenler";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            return base.GetDataTable(cmd);
        }

    }
}
