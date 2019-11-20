class VTIslemleri
    {
        private SqlConnection conn;
        protected string dataSource = @"(local)\serkan";//server adı
        protected string dataBase = @"?";//veri tabani adı
        protected string userName = "";//kullanici adi
        protected string password = "";//sifre

        /// <summary>
        /// bağlantı bilgilerini kuran metot.
        /// </summary>
        private void ConnectionInfo()
        {
            this.conn = new SqlConnection
            {
                ConnectionString = @"Data Source=" + this.dataSource + ";AttachDbFilename=" + this.dataBase + "; Integrated Security=True"
                // ConnectionString = @"Data Source=" + this.dataSource + ";Initial Catalog=" + this.dataBase + "; Integrated Security=True"

            };

        }

        /// <summary>
        /// insert, update ve delete işlemlerinde kullanıcak metot.
        /// 
        /// </summary>
        /// <param name="cmd">sqlcommand</param>
        /// <returns>etkilenen satır sayısı</returns>
        protected int ExecuteQuery(SqlCommand cmd)
        {
            string yol = AppDomain.CurrentDomain.BaseDirectory;
            int donen = -1;//metotun dönecek değeri           
            this.ConnectionInfo();//connectin info ile bağlantı bilgilerini kuruyorum.
            cmd.Connection = this.conn;//gelen komutun bağlantısını conn yapıyorum.
            try
            {
                if (cmd.Connection.State == ConnectionState.Closed)
                { cmd.Connection.Open(); }//try bloğubda cmd sqlcommandına atadığım sqlconnectionu açıyorum.
                donen = cmd.ExecuteNonQuery();//gelen sqlcommandı çalıştırıp etkilenen satır sayısı bilgisini metottan dönecek dönen değere aktarıyorum.
            }
            catch (Exception ex)//hata dalgılanırsa exception nesnesi oluştur.
            {
                FileStream fs;//hatayı bir text dosyasına aktarmak için dosya akımı oluştur.
                fs = new FileStream(yol + @"\hata.txt", FileMode.Append);//dosyayı aç veya yoksa oluştur.
                StreamWriter sw = new StreamWriter(fs);//dosyaakımını akım yazmaya aktar.

                //mesajı tarihle beraber dosyaya yaz
                sw.WriteLine("----------------------------------------------------------------------------------------");
                sw.WriteLine("Hata tarihi:  " + DateTime.Now.ToString());
                sw.WriteLine(ex.Message.ToString());
                sw.WriteLine("----------------------------------------------------------------------------------------");

               
                sw.Dispose();//akımyazıcıyı kapat 
                fs.Dispose();//dosyaakımını kapat 


            }
            finally
            {
                cmd.Connection.Dispose();//sqlcommandın çalıştığı connectionu kapat.

            }
            return donen;//donen değişkenini gönder

        }

        /// <summary>
        /// select sorgusu işlemleri için kullanılır.
        /// </summary>
        /// <param name="cmd">sqlcommand</param>
        /// <returns>DataTable</returns>
        public DataTable GetDataTable(SqlCommand cmd)
        {
            string yol = AppDomain.CurrentDomain.BaseDirectory;//hata yolu
            this.ConnectionInfo();//bağlanıtı(conn) bilgilerini aktardık.
            DataTable dt = new DataTable();//dönecek datatable'ı oluşturduk
            cmd.Connection = this.conn;//gelen sqlcommandın connectionını belirledik.
            SqlDataAdapter da = new SqlDataAdapter
            {
                SelectCommand = cmd//dataadapter nesnesinin selecctcommand(seçme sorgusunu) belirledik
            };//veritabanına bağlanıp veriyi datatable aktaracak dataadapter i uluşturdu.
            try
            {
                //if (cmd.Connection.State == ConnectionState.Closed)
                // { cmd.Connection.Open(); }//sqlcommandın connectionını açtık.
                da.Fill(dt);//dataadapter üstünden gelen sqlcomman yardımı ile datatable ı doldurduk
            }
            catch (Exception ex)
            {
                dt = null;
                FileStream fs;//hatayı bir text dosyasına aktarmak için dosya akımı oluştur.
                fs = new FileStream(yol + @"\hata.txt", FileMode.Append);//dosyayı aç veya yoksa oluştur.
                StreamWriter sw = new StreamWriter(fs);//dosyaakımını akım yazmaya aktar.
                sw.WriteLine("----------------------------------------------------------------------------------------");
                sw.WriteLine("Hata tarihi:  " + DateTime.Now.ToString());
                sw.WriteLine(ex.Message.ToString());
                sw.WriteLine("----------------------------------------------------------------------------------------");

                //mesajı tarihle beraber dosyaya yaz
                sw.Dispose();//akımyazıcıyı kapat kapat
                fs.Dispose();//dosyaakımını kapat

            }
            finally
            {
                cmd.Connection.Dispose();//bağlantıyı istisna olsun ya da olmasın kapat
            }
            return dt;


        }
    }