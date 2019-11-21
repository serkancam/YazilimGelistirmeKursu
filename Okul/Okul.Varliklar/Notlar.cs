using System;

namespace Okul.Varliklar
{
    public class Notlar
    {
        public int NotlarId { get; set; }
        public string Ogrenci { get; set; }
        public int DersId { get; set; }
        public int TurId { get; set; }
        public int Donem { get; set; }
        public int Puani { get; set; }
        public DateTime Tarih { get; set; }
    }
}
