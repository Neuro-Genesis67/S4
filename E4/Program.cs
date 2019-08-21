using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4
{
    class MyClass
    {
        private int apes;
        public MyClass(int howManyApes)
        {
            this.apes = howManyApes;
        }
        public override string ToString()
        {
            return "I have " + this.apes + " apes.";
        }

        public int Accessor
        {
            get { return this.apes;  }
            set { this.apes = value; }
        }
        static void Main(string[] args)
        {
            var mc = new MyClass(2);
            Console.WriteLine(mc);
            mc.Accessor += 10;
            Console.WriteLine(mc.ToString());
            mc.Accessor = 3;
            Console.WriteLine(mc);
            Console.ReadLine();
        }
    }
}
