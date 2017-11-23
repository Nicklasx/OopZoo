using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo;
            zoo = new Zoo("Zoo Mercantec");
            Console.WriteLine(zoo.Describe());
            Console.ReadKey();
        }
    }
}
