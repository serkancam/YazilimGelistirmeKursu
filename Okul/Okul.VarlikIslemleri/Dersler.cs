using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Okul.VarlikIslemleri
{
    public class Dersler:VTIslemler
    {
        public int DersEkle(Varliklar.Dersler ders)
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "insert into dersler(dersAdi,dersOgretmeni,dersAciklama) values(@adi,@ogretmen,@aciklama)";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            cmd.Parameters.Add("@adi", SqlDbType.VarChar, 50).Value = ders.DersAdi;
            cmd.Parameters.Add("@ogretmen", SqlDbType.Char, 11).Value = ders.DersOgretmeni;
            cmd.Parameters.Add("@aciklama", SqlDbType.VarChar, 50).Value = ders.DersAciklama;
            return base.ExecuteQuery(cmd); 
                

        }

        public int DersSil(Varliklar.Dersler ders)
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "delete from dersler where dersId=@id";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ders.DersId;
            return base.ExecuteQuery(cmd);
        }

        public int DersGuncelle(Varliklar.Dersler ders)
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "update dersler set dersAdi=@adi,dersOgretmeni=@ogretmen,dersAciklama=@aciklama where dersId=@id";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            cmd.Parameters.Add("@adi", SqlDbType.VarChar, 50).Value = ders.DersAdi;
            cmd.Parameters.Add("@ogretmen", SqlDbType.Char, 11).Value = ders.DersOgretmeni;
            cmd.Parameters.Add("@aciklama", SqlDbType.VarChar, 50).Value = ders.DersAciklama;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ders.DersId;
            return base.ExecuteQuery(cmd);
        }

        public DataTable DersleriGetir()
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "select * from dersler";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            return base.GetDataTable(cmd);
        }
        
    }
}
