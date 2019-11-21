using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdamAsmaca
{
    class Program
    {


        static void Main(string[] args)
        {


            List<string> sorular = new List<string>();// bu satırda stirn tipinde bir liste tanımlandı
            List<char> tahminler = new List<char>();
            List<char> bilinenler = new List<char>();
            Random r = new Random();//rastgele seçim için Randam sınıfından r nesnesi tanımlandı.

            string satir;//dosyadan okunan her satır için
            string secilenSoru;//rastgele seçilen soru deeğerini tutmak için
            string yazi = "";//ekrana yazdıracak _ _ _ şeklindeki yazıyı oluşturmak için
            char tahmin;//kullanıcıdan alınan tahmin değerini tutmak için

            /***** Bu çok sağlıklı bir yöntem değil yöntem ******/
            //var sr = new StreamReader("sorular.txt");
            //while ((satir = sr.ReadLine())!=null)
            //{
            //    sorular.Add(satir);
            //}
            //sr.Close();
            /******Bu daha sağlıklı bir yöntem******/

            using (var sr = new StreamReader("sorular.txt"))//dosyamızla aynı dizninde film isimleri olan bir dosya olsun
            {//StreamReader dan türettiğimiz sr ile txt dosyasına bir akım oluşturuyoruz
                while ((satir = sr.ReadLine()) != null)//dosya da son satıra kadar geliyoruz ve her
                {
                    sorular.Add(satir);//satir değişkenine aktardığımız her satırı sorular listesine ekliyoruz.
                }
                sr.Close();//Sr nesnresini kapatıyoruz.(bunu yapmaz isek sıkıntılar doğabilir)
            }
            secilenSoru = sorular.ElementAt(r.Next(0, sorular.Count));//her adımda listeden rastgele bir değer seçiyoruz
            while (true)//sonsuz döngü kullanıcadan tahmin almak için
            {
                yazi = "";//ekrana yazan yazı her adımda boşaltılıyor.
                foreach (var item in secilenSoru)
                {
                    if (bilinenler.Contains(item))//
                        yazi += item;
                    else if (item == ' ')
                        yazi += "  ";
                    else
                        yazi += " _";
                }

                Console.Clear();
                Console.WriteLine(yazi);
                Console.Write("Söylenen Harfler:");
                foreach (var item in tahminler)
                {
                    Console.Write("{0}-", item);
                }
                Console.WriteLine();
                Console.WriteLine("Bir harf tahmini giriniz:");
                if (!Char.TryParse(Console.ReadLine(), out tahmin) || !Char.IsLetter(tahmin))
                {
                    continue;
                }

                if (tahminler.Contains(tahmin))
                {
                    Console.WriteLine("Bu harf söylendi");
                    Thread.Sleep(1300);
                    continue;
                }
                else if (secilenSoru.Contains(tahmin))
                {
                    tahminler.Add(tahmin);
                    bilinenler.Add(tahmin);
                }
                else
                {
                    tahminler.Add(tahmin);
                }
                if (tahminler.Count > 7)
                {
                    Console.WriteLine("Tahmin sayınız doldu, Kaybettiniz.");
                    Thread.Sleep(1200);
                    break;

                }
                if (!yazi.Contains('_'))
                {
                    Console.WriteLine("Tebrikler bildiniz");
                    Thread.Sleep(1000);
                    break;
                }
            }

        }
    }
}
