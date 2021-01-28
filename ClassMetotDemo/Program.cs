using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri { Id = 1, Ad = "seda", Soyad = "akın" };

            Musteri musteri2 = new Musteri { Id = 2, Ad = "mirem", Soyad="ışıldak" };

            Musteri musteri3 = new Musteri { Id = 3, Ad = "melda", Soyad = "köse" };


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.Update(musteri3);

            Console.WriteLine("------LİSTELEME------");
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);





        }
    }
}
