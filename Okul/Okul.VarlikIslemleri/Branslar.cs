using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Okul.VarlikIslemleri
{
   public class Branslar:VTIslemler
    {
        public int BransEkle(Varliklar.Branslar brans)
        {
            SqlCommand cmd = new SqlCommand();//sqlcommand nesnesi tanımlandı
            string komut = "insert into branslar(bransId,bransAdi,bransAciklama) values(@id,@adi,@aciklama)";//komut parametreli olarak oluşturuldu
            cmd.CommandType = CommandType.Text;//komut tipi text seçidl
            cmd.CommandText = komut;//sqlcommand nesnesine komut olratk atandı
            //parametreler eklendi
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = brans.BransId;
            cmd.Parameters.Add("@adi", SqlDbType.VarChar, 50).Value = brans.BransAdi;
            cmd.Parameters.Add("@aciklama", SqlDbType.VarChar, 50).Value = brans.BransAciklama;
            return base.ExecuteQuery(cmd);          
 
        }

        public int BransSil(Varliklar.Branslar brans)
        {
            SqlCommand cmd = new SqlCommand();//sqlcommand nesnesi tanımlandı
            string komut = "delete from branslar where bransId=@id";//komut parametreli olarak oluşturuldu
            cmd.CommandType = CommandType.Text;//komut tipi text seçidl
            cmd.CommandText = komut;//sqlcommand nesnesine komut olratk atandı
            //parametreler eklendi
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = brans.BransId;
            return base.ExecuteQuery(cmd);
        }

        public int BransGuncelle(Varliklar.Branslar brans)
        {
            SqlCommand cmd = new SqlCommand();//sqlcommand nesnesi tanımlandı
            string komut = "update branslar set bransAdi=@adi,bransAciklama=@aciklama where bransId=@id";//komut parametreli olarak oluşturuldu
            cmd.CommandType = CommandType.Text;//komut tipi text seçidl
            cmd.CommandText = komut;//sqlcommand nesnesine komut olratk atandı
            //parametreler eklendi
           
            cmd.Parameters.Add("@adi", SqlDbType.VarChar, 50).Value = brans.BransAdi;
            cmd.Parameters.Add("@aciklama", SqlDbType.VarChar, 50).Value = brans.BransAciklama;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = brans.BransId;
            return base.ExecuteQuery(cmd);

        }

        public DataTable BranslariGetir()
        {            
            SqlCommand cmd = new SqlCommand();
            string komut = "select bransId as id,bransAdi as adi from branslar";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = komut;
            return base.GetDataTable(cmd);
        }

    }
}
