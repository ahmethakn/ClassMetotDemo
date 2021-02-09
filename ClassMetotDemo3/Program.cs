using System;

namespace ClassMetotDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Müşteri Kayıt Programı**********");
            Console.WriteLine();

            Musteri musteri1 = new Musteri();
            Console.Write("Müşteri Adı: ");
            musteri1.Ad = Console.ReadLine();
            Console.Write("Müşteri Soyadı: ");
            musteri1.Soyad = Console.ReadLine();
            Console.WriteLine("Devam etmek için ENTER tuşuna, kaydolmaktan vazgeçtiyseniz DELETE tuşuna basınız.");

            ConsoleKeyInfo tus = new ConsoleKeyInfo();
            tus = Console.ReadKey();
            MusteriManager musteriManager = new MusteriManager();
            if (tus.Key == ConsoleKey.Delete)
            {
                musteriManager.MusteriSilme(musteri1);
            }
            else
            {
                musteriManager.MusteriEkleme(musteri1);
            }
            Console.WriteLine();

            Musteri musteri2 = new Musteri();
            Console.Write("Müşteri Adı: ");
            musteri2.Ad = Console.ReadLine();
            Console.Write("Müşteri Soyadı: ");
            musteri2.Soyad = Console.ReadLine();

            Console.WriteLine("Devam etmek için ENTER tuşuna, kaydolmaktan vazgeçtiyseniz DELETE tuşuna basınız.");

            ConsoleKeyInfo tus2 = new ConsoleKeyInfo();
            tus2 = Console.ReadKey();
            if (tus2.Key == ConsoleKey.Delete)
            {
                musteriManager.MusteriSilme(musteri2);
            }
            else
            {
                musteriManager.MusteriEkleme(musteri2);
            }
        }
    }
}
