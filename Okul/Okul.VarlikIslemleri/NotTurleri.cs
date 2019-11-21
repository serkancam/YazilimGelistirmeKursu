using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Okul.VarlikIslemleri
{
    public class NotTurleri:VTIslemler
    {
        public int NotTuruEkle(Varliklar.NotTurleri notTur)
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "insert into notTurleri(notAdi) values(@adi)";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            cmd.Parameters.Add("@adi", SqlDbType.VarChar, 50).Value = notTur.NotAdi;
            return base.ExecuteQuery(cmd);
        }

        public int NotTuruSil(Varliklar.NotTurleri notTur)
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "delete from notTurleri where notId=@id";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 50).Value = notTur.NotId;
            return base.ExecuteQuery(cmd);
        }

        public int NotTuruGuncelle(Varliklar.NotTurleri notTur)
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "update notTurleri set notAdi=@adi where notId=@id";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            cmd.Parameters.Add("@adi", SqlDbType.VarChar, 50).Value = notTur.NotAdi;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = notTur.NotId;
            return base.ExecuteQuery(cmd);
        }

        public DataTable NotTurleriGetir()
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "select * from notTurleri";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            return base.GetDataTable(cmd);
        }
    }
}
