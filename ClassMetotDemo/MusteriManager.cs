using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + "  " + " " + musteri.Ad + " " + " " + musteri.Soyad+ " " + "eklendi");

        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + "  " + " " + musteri.Ad + " " + " " + musteri.Soyad +" " +  "silindi");
        }

        public void Update(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + "  " + " " + musteri.Ad + " " + " " + musteri.Soyad + " " + "güncellendi");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + "  " + " " + musteri.Ad + " " + " " + musteri.Soyad  );
        }


    }


}
