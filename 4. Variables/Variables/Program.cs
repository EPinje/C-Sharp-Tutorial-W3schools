using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            
            Typer af variabler:
             
            int     -       hele tal
            double  -       decimaltal
            char    -       bogstaver omgivet af apostroffer
            string  -       Tekst omgivet af anførelsestegn
            bool    -       værdier der skal skælne mellem: true or false

            */

            string mitnavn = "Jonas Christian Larsen";
            Console.WriteLine(mitnavn);

            int mitnummer = 33;
            Console.WriteLine(mitnummer);

            int mitnummer2;
            mitnummer2 = 8;

            Console.WriteLine(mitnummer2);

            mitnummer2 = 338;
            Console.WriteLine(mitnummer2);

            string forlovede = "Desirée (brumbassen) Guldhammer";
                Console.WriteLine(forlovede);

            //teksten efter variable typen, er hvad variablen kan genkaldes med.
            //genkandelsesnavnet efterfulgt af = giver mulighed for at fastsætte en værddi, så længe at værdien passer til rammerne for typen

            Console.ReadLine();
        }
    }
}
