using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Kübra";
            musteri1.Soyad = "Keskin";
            musteri1.Id = 1997;

            Musteri musteri4 = new Musteri();
            musteri4.Ad = "Nil";
            musteri4.Soyad = "Keskin";
            musteri4.Id = 2019;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri4);

            Console.WriteLine("----------------");


            Console.WriteLine("MÜŞTERİLER ŞU ŞEKİLDE : ");

            musteriManager.List();
        }
    }
}
