using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bak
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kontoinhaber konto = new Kontoinhaber("Max Mustermann", 1000);
            Console.WriteLine("Kontoinhaber: " + konto.Name);   
            konto.Name = "Erika Mustermann";
            konto.Ausagabe();   
            Console.ReadKey();  

        }
    }
}
