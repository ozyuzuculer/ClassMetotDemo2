using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine(musteri.Name + (" ") + musteri.Surname + " isimli müşterimize ait iban numarası: " + musteri.IBAN + "'dır.");            
        }
        public void Cikar(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + (" ") +  musteri.Surname + " isimli müşterimize ait iban numarası: " + musteri.IBAN + " CIKARILMIŞTIR.");
        }
        public void listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + (" ") + musteri.Name + (" ") + musteri.Surname +(" ") +  musteri.IBAN);
        }



    }
}
