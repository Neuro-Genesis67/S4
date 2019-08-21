using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        public static void Main()
        {
            List<double> list = new List<double>();
            Random random = new Random();
            Console.WriteLine(random);
            for (int i = 0; i < 20; i++)
            {
                list.Add(random.NextDouble());
            }
            list.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
