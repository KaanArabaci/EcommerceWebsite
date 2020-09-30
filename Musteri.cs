using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret
{
    class Musteri
    {
        public int TcNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string City { get; set; }


        private static void SepeteEkle()
        {
            string[] urun = {"kalem","kitap","defter" };
            foreach (var item in urun)
            {
                Console.WriteLine(item);
            }
        }

        public  void SatinAl()
        {

        }

        public void  GeriGonder()
        {

        }

        public void Odeme()
        {

        }


    }
}
