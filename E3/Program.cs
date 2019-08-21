using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3
{
    class MyClass
    {
        int number;
        public MyClass(int number)
        {
            this.number = number;
        }

        public override string ToString()
        {
            return "Number: " + this.number;
        }

        static void Main(string[] args)
        {
            MyClass mc = new MyClass(5);
            Console.WriteLine(mc.ToString());
            Console.ReadLine();
        }
    }
}
