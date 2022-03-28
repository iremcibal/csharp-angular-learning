using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "İrem";
            musteri1.Surname = "Balcı";
            musteri1.TCnumber = "12345678901";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "Engin";
            musteri2.Surname = "Demiroğ";
            musteri2.TCnumber = "00000000000";


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.NewMusteri(musteri1);
            musteriManager.NewMusteri(musteri2);
            musteriManager.DeleteMusteri(musteri2);
            musteriManager.ListMusteri("12345678901");

            Console.ReadLine();
        }
    }
}
