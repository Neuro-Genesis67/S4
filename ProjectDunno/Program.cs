using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDunno
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mainList = new List<int>() { 58, 23, 2, 15, 7, 11, 52, 42, 86, 91 };
            MySortingClass ms = new MySortingClass(mainList);
            Console.WriteLine("Unsorted list: ");
            ms.printMyList();
            ms.SortMyList(ms.GetList);
            Console.WriteLine("\nSorted list: ");
            ms.printMyList();
            Console.ReadLine();
        }
    }
}
