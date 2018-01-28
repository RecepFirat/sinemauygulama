using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sinemauygulama
{//35.dakıkadayım
    class Koltuk:Button//sen bi buttonsun dıyorum senın ıcıne buttonlar olucak
    {//bir nevi kendim user control yaptım
        public Koltuk()
        {
            Width = 50;
            Height = 50;
            BackgroundImage =new Bitmap( Properties.Resources.koltuk1,50,50);//boyutunu 50 50 ayarladım
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