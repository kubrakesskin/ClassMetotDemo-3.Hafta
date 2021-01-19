using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " isimli " + musteri.Id + " numaralı yeni kişi eklenmiştir .");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " isimli " + musteri.Id + " numaralı yeni kişi silinmiştir. ");
        }
        public void List()
        {
            //yukarıda neler yapacagımızı ifade ettik şimdi ise sıra müşteri bilgilerine geldi :)
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Kübra";
            musteri1.Soyad = "Keskin";
            musteri1.Id = 1997;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Nisa";
            musteri2.Soyad = "Keskin";
            musteri2.Id = 2013;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Taha";
            musteri3.Soyad = "İmir";
            musteri3.Id = 2015;

            Musteri musteri4 = new Musteri();
            musteri4.Ad = "Nil";
            musteri4.Soyad = "Keskin";
            musteri4.Id = 2019;

            Musteri[] musteris = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            foreach (var musteri in musteris)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + musteri.Id);

            }

        }
    }
}
