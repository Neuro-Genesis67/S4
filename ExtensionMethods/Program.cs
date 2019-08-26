using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods {

    public static class ExtPower {
        public static int PowerExt(this int n, int p) {
            if (p == 0) {
                return 1;
            }
            if (p == 1) {
                return n;
            }
            return n * PowerExt(n, p - 1);
        }
    }
    class Program {

        
        public static int Power(int n, int p) {
            if (p == 0) {
                return 1;
            }
            if (p == 1) {
                return n;
            }
            return n * Power(n, p - 1);
        }

        static void Main(string[] args) {
            Console.WriteLine("Power(2, 4): " + Power(2, 4));
            Console.WriteLine("2.PowerExt(4): " + 2.PowerExt(4));
            Console.ReadKey();
        }


    }
}
