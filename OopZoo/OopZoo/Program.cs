using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopZoo
{
    class Program
    {
        public static void Intro()
        {
            bool loop = true;
            string ja = "ja";
            string nej = "nej";
            string okay = "Det er bare i orden";
            string forkert = "Det er ikke en mulighed";
            Zoo zoo;
            zoo = new Zoo("Zoo Mercantec");
            Console.WriteLine(zoo.Velkomst());

            try
            {
                svar = Console.ReadLine().ToLower().Trim();
            }
            catch
            {
                Console.WriteLine(forkert);
            }

            if (svar == ja)
            {
                Console.WriteLine("hej");
            }
            else if (svar == nej)
            {
                Console.WriteLine(okay);
            }
            else
            {
                Console.WriteLine(forkert);
            }
        }

        public static string svar;
        static void Main(string[] args)
        {
            Intro();
            Console.ReadKey();
        }
    }

}
