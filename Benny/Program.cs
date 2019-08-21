using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benny
{
    class Benny
    {
        public void printBenny()
        {
            Console.WriteLine("I'm the Benny!");
            Console.ReadLine();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Benny benny = new Benny();
            benny.printBenny();
        }
    }
}
