using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_____WriteLine__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //WriteLine printer tekst og skifter linje
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!");

            Console.WriteLine(3 + 3); //"" indikere tekst. Uden "" betragtes indholdet i () som matematik

            Console.Write("Hello World!"); //Write fortsatter tekst på samme linje.
            Console.Write("I will print on the same line");

            Console.ReadLine();
        }
    }
}
