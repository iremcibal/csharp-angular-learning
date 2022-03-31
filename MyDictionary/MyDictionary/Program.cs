using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int , string> myDictionary = new MyDictionary<int , string>();

            myDictionary.Add(1, "iREM BALCI");
            myDictionary.Add(2, "ENGİN DEMiROG");

            Console.WriteLine(myDictionary.Count);
            


            Console.ReadLine();

        }
    }
}
