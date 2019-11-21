using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Okul.VarlikIslemleri
{
    public class Notlar:VTIslemler
    {
        public int NotEkle(Varliklar.Notlar not)
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "insert into notlar(ogrenci,dersId,turId,donem,puani,tarih) values(@ogrenci,@ders,@tur,@donem,@puan,@tarih)";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            cmd.Parameters.Add("@ogrenci", SqlDbType.Char, 11).Value = not.Ogrenci;
            cmd.Parameters.Add("@ders", SqlDbType.Int).Value = not.DersId;
            cmd.Parameters.Add("@tur", SqlDbType.Int).Value = not.TurId;
            cmd.Parameters.Add("@donem", SqlDbType.Int).Value = not.Donem;
            cmd.Parameters.Add("@puan", SqlDbType.Int).Value = not.Puani;
            cmd.Parameters.Add("@tarih", SqlDbType.Date).Value = not.Tarih;
            return base.ExecuteQuery(cmd);
        }

        public int NotSil(Varliklar.Notlar not)
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "delete from notlar where notlarId=@id";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;          
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = not.NotlarId;

            return base.ExecuteQuery(cmd);
        }

        public int NotGuncelle(Varliklar.Notlar not)
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "uppadte notlar set ogrenci=@ogrenci,dersId=@ders,turId=@tur,donem=@donem,puani=@puan,tarih=@tarih where notlarId=@id";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            cmd.Parameters.Add("@ogrenci", SqlDbType.Char, 11).Value = not.Ogrenci;
            cmd.Parameters.Add("@ders", SqlDbType.Int).Value = not.DersId;
            cmd.Parameters.Add("@tur", SqlDbType.Int).Value = not.TurId;
            cmd.Parameters.Add("@donem", SqlDbType.Int).Value = not.Donem;
            cmd.Parameters.Add("@puan", SqlDbType.Int).Value = not.Puani;
            cmd.Parameters.Add("@tarih", SqlDbType.Date).Value = not.Tarih;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = not.NotlarId;
            return base.ExecuteQuery(cmd);
        }

        public DataTable NotlariGetir()
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "select * from notlar";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            return base.GetDataTable(cmd);
        }

        public DataTable OgrencininDonemeAitDersNotlariniGetir(Varliklar.Notlar not)
        {
            SqlCommand cmd = new SqlCommand();
            string komut = "select n.turId,n.puani from notlar as n where n.ogrenci=@ogrenci and n.donem=@donem and n.dersId=@ders";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            cmd.Parameters.Add("@ogrenci", SqlDbType.Char, 11).Value = not.Ogrenci;
            cmd.Parameters.Add("@donem", SqlDbType.Int).Value = not.Donem;
            cmd.Parameters.Add("@ders", SqlDbType.Int).Value = not.DersId;
            return base.GetDataTable(cmd);
        }
        public DataTable SinifinDerseAitNotlariniGetir(Varliklar.Notlar not,Varliklar.Siniflar sinif)
        {

            SqlCommand cmd = new SqlCommand();
            string komut = "select p.* from(select o.ogrenciAdi,o.ogrenciSoyadi,n.* from notlar as n inner join ogrenci as o on n.ogrenci=o.ogrenciTc )piv pivot( max(puani)for turId in ([1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12])) as p where dersId=@ders AND donem=@donem AND ogrenci in(select o.ogrenciTc from ogrenci as o where o.sinif=@sinif)";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            cmd.Parameters.Add("@ders", SqlDbType.Int).Value = not.DersId;           
            cmd.Parameters.Add("@donem", SqlDbType.Int).Value = not.Donem;
            cmd.Parameters.Add("@sinif", SqlDbType.Char, 11).Value = sinif.SinifId;
           
            return base.GetDataTable(cmd);
        }
    }
}
