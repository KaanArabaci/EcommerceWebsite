using ETicaret;
using System;

namespace ETicaret
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.City = "izmir";

            Uretici uretici = new Uretici();
            uretici.City = "denizli";
            
            var yon = uretici.KargoyaVer(uretici.City , musteri.City);
            Console.WriteLine(yon);

            SepeteEkle(0);
            
            
            Console.ReadLine();

        }

        
    }
}
