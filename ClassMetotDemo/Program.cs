using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.Id = 003456;
            musteri1.Name = ("Yunus Emre");
            musteri1.Surname = ("ÖZYÜZÜCÜLER");
            musteri1.IBAN = ("TR123456789");

            Musteri musteri2 = new Musteri();
            musteri2.Id = 003457;
            musteri2.Name = ("Tuğçe");
            musteri2.Surname = ("PAK");
            musteri2.IBAN = ("TR123456788");

            Musteri musteri3 = new Musteri();
            musteri3.Id = 003458;
            musteri3.Name = ("Enes");
            musteri3.Surname = ("AYGÜN");
            musteri3.IBAN = ("TR123456787");

            Musteri musteri4 = new Musteri();
            musteri4.Id = 003459;
            musteri4.Name = ("Esra");
            musteri4.Surname = ("UĞUR");
            musteri4.IBAN = ("TR123456786");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            Console.WriteLine("-----------------------------PANEL------------------------------");

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Name);
                Console.WriteLine(musteri.Surname);
                Console.WriteLine(musteri.IBAN);
                Console.WriteLine("--------------------------------------");
            }

            Console.WriteLine("-----------------EKLEME---------------");
            musteriManager.Ekle(musteri1);
            Console.WriteLine(" ");
            musteriManager.Ekle(musteri2);
            Console.WriteLine(" ");
            musteriManager.Ekle(musteri3);
            Console.WriteLine(" ");
            musteriManager.Ekle(musteri4);
            Console.WriteLine(" ");

            Console.WriteLine("-----------------ÇIKARMA---------------");
            musteriManager.Cikar(musteri1);
            Console.WriteLine(" ");
            musteriManager.Cikar(musteri2);
            Console.WriteLine(" ");
            musteriManager.Cikar(musteri3);
            Console.WriteLine(" ");
            musteriManager.Cikar(musteri4);
            Console.WriteLine(" ");

            Console.WriteLine("-----------------LISTELE---------------");
            musteriManager.listele(musteri1);
            Console.WriteLine(" ");
            musteriManager.listele(musteri2);
            Console.WriteLine(" ");
            musteriManager.listele(musteri3);
            Console.WriteLine(" ");
            musteriManager.listele(musteri4);


        }

    }
}
