using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sinemauygulama
{//35.dakıkadayım
    class Koltuk:Button//sen bi buttonsun dıyorum senın ıcıne buttonlar olucak
    {
        public Koltuk()
        {
            Width = 50;
            Height = 50;
        }

        public int Numara { get; set; }
        public string Sıra { get; set; }

        public Bilet Bilet { get; set; }

        public KoltukDurum Durum { get; set; }
    }

    enum KoltukDurum {
        Bos,
        Satildi,
        Rezerve,
        Kapali

    }
}