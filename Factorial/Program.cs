using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial {

    // The extension method resides in a static class.
    // The extension method has to be static.
    // The keyword 'this' is placed in front of the type (this int n).
    public static class ExtInt {
        public static int Factorial(this int n) {
            if (n == 0) {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }

    class Program {

        static void Main(string[] args) {
            // Regular method:
            Console.WriteLine("Factorial(4): " + Factorial(4));

            // Using extension method:
            Console.WriteLine("4.ExtFactorial(): " + 4.Factorial());
            Console.ReadKey();
        }

        public static int Factorial(int n) {
            if (n == 0) {
                return 1;
            } 
            return n * Factorial(n - 1);
        }

        
    }
}
