using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Okul.VarlikIslemleri
{
   public class Donemler:VTIslemler
    {
       public int DonemEkle(Varliklar.Donemler donem)
       {
           SqlCommand cmd = new SqlCommand();
           string komut = "insert into donemler(yili,donem) values(@yil,@donem)";
           cmd.CommandType = CommandType.Text;
           cmd.CommandText = komut;
           cmd.Parameters.Add("@yil", SqlDbType.VarChar, 10).Value = donem.Yili;
           cmd.Parameters.Add("@donem", SqlDbType.SmallInt).Value = donem.Donem;
           return base.ExecuteQuery(cmd);
       }

       public int DonemSil(Varliklar.Donemler donem)
       {
           SqlCommand cmd = new SqlCommand();
           string komut = "delete from donemler where donemId=@id";
           cmd.CommandType = CommandType.Text;
           cmd.CommandText = komut;
           cmd.Parameters.Add("@id", SqlDbType.Int).Value = donem.DonemId;
           return base.ExecuteQuery(cmd);
       }

       public int DonemGuncelle(Varliklar.Donemler donem)
       {
           SqlCommand cmd = new SqlCommand();
           string komut = "update donemler set yili=@yil,donem=@donem where donemId=@id";
           cmd.CommandType = CommandType.Text;
           cmd.CommandText = komut;
           cmd.Parameters.Add("@yil", SqlDbType.VarChar, 10).Value = donem.Yili;
           cmd.Parameters.Add("@donem", SqlDbType.SmallInt).Value = donem.Donem;
           cmd.Parameters.Add("@id", SqlDbType.Int).Value = donem.DonemId;
           return base.ExecuteQuery(cmd);
       }

       public DataTable DonemleriGetir()
       {
           SqlCommand cmd = new SqlCommand();
           string komut = "select * from donemler";
           cmd.CommandType = CommandType.Text;
           cmd.CommandText = komut;
           return base.GetDataTable(cmd);
       }

       public DataTable DonemleriBirlestirGetir()
       {
           SqlCommand cmd = new SqlCommand();
           string komut = "select d.donemId,d.yili+' ' +CAST(d.donem as varchar)+'. Dönem' as donem from donemler as d";
           cmd.CommandType = CommandType.Text;
           cmd.CommandText = komut;
           return base.GetDataTable(cmd);
       }
    }
}
