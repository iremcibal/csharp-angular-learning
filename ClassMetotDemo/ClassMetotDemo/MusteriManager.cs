using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void NewMusteri(Musteri musteri)
        {
            Console.WriteLine("Yeni müşteri eklendi.");
        }

        public void DeleteMusteri(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi.");
        }

        public void ListMusteri(String TcNo)
        {
            Console.WriteLine("Müşteri bilgileri listelendi.");

        }
    }
}
