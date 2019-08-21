using ClassLibrary1; // <-- 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyExternalClassEx = new MyExternalClass();
            Console.WriteLine(MyExternalClassEx.GetMeAsText());
            Console.WriteLine(MyExternalClassEx.GetMeDoubleTheAmount(8));
            Console.ReadLine();
        }
    }
}
