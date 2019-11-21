using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Okul.VarlikIslemleri
{
    public class Siniflar:VTIslemler
    {
        public int SinifEkle(Varliklar.Siniflar sinif)
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "insert into siniflar(sinif,sube) values(@sinif,@sube)";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            cmd.Parameters.Add("@sinif", SqlDbType.TinyInt).Value = sinif.Sinif;
            cmd.Parameters.Add("@sube", SqlDbType.Char, 2).Value = sinif.Sube;
            cmd.Parameters.Add("@soyadi", SqlDbType.VarChar, 50).Value = sinif.Sube;
            return base.ExecuteQuery(cmd);
        }

        public int SinifSil(Varliklar.Siniflar sinif)
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "delete from siniflar where sinifId=@id";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = sinif.SinifId;
            return base.ExecuteQuery(cmd);
        }

        public int SinifGuncelle(Varliklar.Siniflar sinif)
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "update siniflar set sinif=@sinif,sube=@sube where sinifId=@id";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            cmd.Parameters.Add("@sinif", SqlDbType.TinyInt).Value = sinif.Sinif;
            cmd.Parameters.Add("@sube", SqlDbType.Char,2).Value = sinif.Sube;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = sinif.SinifId;
            return base.ExecuteQuery(cmd);
        }

        public DataTable SiniflariGetir()
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "select s.sinifId, CAST(s.sinif as varchar)+'-'+s.sube as sinif from siniflar as s";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            return base.GetDataTable(cmd);
        }

        public DataTable SinifaAitDersleriGetir(Varliklar.Siniflar sinif)
        {

            SqlCommand cmd = new SqlCommand();
            string komut = "select sd.dersId,d.dersAdi from sinifDersleri as sd inner join dersler as d on sd.dersId=d.dersId where sd.sinifId=@sinifId";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            cmd.Parameters.Add("@sinifId", SqlDbType.Int).Value = sinif.SinifId;
            return base.GetDataTable(cmd);
        }

    }
}
