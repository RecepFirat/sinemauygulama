using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinemauygulama
{
    class Film
    {
        public Film()
        {
            Seanslar = new List<Seans>();
        }
        private static List<Film> filmler;//eger static yaparsam bi instance uretmeme gerekmıyo
        public static List<Film> Filmler
        {
            get
            {
                return filmler;
            }
            set
            {
                filmler = value;


            }
        }


        public string Adi { get; set; }
        public string Tur { get; set; }
        public TimeSpan Sure { get; set; }
        public string Acıklama { get; set; }
        public List<Seans> Seanslar { get; set; }
    }
}
