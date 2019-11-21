using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Okul.Varliklar
{
    public class Donemler
    {
        private int sinav;

        public int Sinav
        {
            get { return sinav; }
            set { sinav = value; }
        }
        public int DonemId { get; set; }
        public string Yili { get; set; }
        public short Donem { get; set; }
    }

}
