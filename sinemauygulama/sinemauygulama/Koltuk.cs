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
            KoltukTanimla();
        }
        public Koltuk(int boyut)
        {
            KoltukTanimla(boyut);

        }
      void  KoltukTanimla(int size=30)//size ver verilmemisse 30
        {
            Boyut = size;
            Width = size;
            Height = size;
            Margin = new Padding(0);
            BackgroundImage =new Bitmap( Properties.Resources.koltuk1,size,size);//boyutunu 50 50 ayarladım
        }

        public int Boyut { get; set; }
        public int Numara { get; set; }
        public string Sıra { get; set; }

        public Bilet Bilet { get; set; }


        //duruma gore Degisecekya  burada ona gore yapıyorum
        private KoltukDurum koltukdurum;

        public KoltukDurum KoltukDurum
        {
            get { return koltukdurum; }
            set {//birisi deger Gonderdıgınde
                switch (value)      
                {//burda sımdı ne deger Gonderelırse ona gore koltugun boyutunu ayarlıcam
                    case KoltukDurum.Bos:
                        BackgroundImage = new Bitmap(Properties.Resources.koltuk1, Boyut, Boyut);
                        break;
                    case KoltukDurum.Satildi:
                        BackgroundImage = new Bitmap(Properties.Resources.Koltuk, Boyut, Boyut);

                        break;
                    case KoltukDurum.Rezerve:
                        BackgroundImage = new Bitmap(Properties.Resources.Koltuk2, Boyut, Boyut);

                        break;
                    case KoltukDurum.Kapali:
                        BackgroundImage = new Bitmap(Properties.Resources.koltuk3, Boyut, Boyut);

                        break;
                    default:
                        break;
                }


                koltukdurum = value; }
        }

    }

    enum KoltukDurum {
        Bos,
        Satildi,
        Rezerve,
        Kapali

    }
}