using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Okul.VarlikIslemleri
{
    public class Ogrenci:VTIslemler
    {
        public int OgrenciEkle(Varliklar.Ogrenci ogrenci)
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "insert into ogrenci(ogrenciTc,ogrenciNo,ogrenciAdi,ogrenciSoyadi,sinif) values(@tc,@no,@adi,@soyadi,@sinifi)";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            cmd.Parameters.Add("@tc", SqlDbType.Char, 11).Value = ogrenci.OgrenciTC;
            cmd.Parameters.Add("@no", SqlDbType.Char,4).Value = ogrenci.OgrenciNo;
            cmd.Parameters.Add("@adi", SqlDbType.VarChar,50).Value = ogrenci.OgrenciAdi;
            cmd.Parameters.Add("@soyadi", SqlDbType.VarChar,50).Value = ogrenci.OgrenciSoyadi;
            cmd.Parameters.Add("@sinifi", SqlDbType.Int).Value = ogrenci.Sinif;
            return base.ExecuteQuery(cmd);
        }

        public int OgrenciSil(Varliklar.Ogrenci ogrenci)
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "delete from ogrenci where ogrenciTc=@tc";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            cmd.Parameters.Add("@tc", SqlDbType.Char, 11).Value = ogrenci.OgrenciTC;
            return base.ExecuteQuery(cmd);
        }

        public int OgrenciGuncelle(Varliklar.Ogrenci ogrenci)
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "update ogrenci set ogrenciNo=@no,ogrenciAdi=@adi,ogrenciSoyadi=@soyadi,sinif=@sinifi where ogrenciTc=@tc";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            cmd.Parameters.Add("@no", SqlDbType.Char, 4).Value = ogrenci.OgrenciNo;
            cmd.Parameters.Add("@adi", SqlDbType.VarChar, 50).Value = ogrenci.OgrenciAdi;
            cmd.Parameters.Add("@soyadi", SqlDbType.VarChar, 50).Value = ogrenci.OgrenciSoyadi;
            cmd.Parameters.Add("@sinifi", SqlDbType.Int).Value = ogrenci.Sinif;
            cmd.Parameters.Add("@tc", SqlDbType.Char, 11).Value = ogrenci.OgrenciTC;
            return base.ExecuteQuery(cmd);
        }

        public DataTable OgrencleriGetir()
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "select o.ogrenciTc,o.ogrenciNo,o.ogrenciAdi,o.ogrenciSoyadi,o.sinif,CAST(s.sinif as varchar) +'-'+ s.sube as sinifi from  ogrenci as o,siniflar as s where o.sinif=s.sinifId";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            return base.GetDataTable(cmd);
        }

        public DataTable SinifinOgrencileriniGetir(Varliklar.Ogrenci ogr)
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "select ogrenciNo,ogrenciAdi +' '+ogrenciSoyadi as adi,ogrenciTc from ogrenci where sinif=@id";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ogr.Sinif;

            return base.GetDataTable(cmd);


        }


    }
}
