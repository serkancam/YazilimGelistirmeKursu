using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Okul.VarlikIslemleri
{
   public class SinifDersleri:VTIslemler
    {
       public int SiniflaraDersEkle(Varliklar.SinifDersleri ders)
       {
           SqlCommand cmd = new SqlCommand();
           string komut = "insert into sinifDersleri(dersId,sinifId) values(@did,@sid)";
           cmd.CommandType = CommandType.Text;
           cmd.CommandText = komut;
           cmd.Parameters.Add("@did", SqlDbType.Int).Value = ders.DersId;
           cmd.Parameters.Add("@sid", SqlDbType.Int).Value = ders.SinifId;           
           return this.ExecuteQuery(cmd);

       }
    }
}
