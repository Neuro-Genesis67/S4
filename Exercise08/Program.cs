using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.MyNormalMethod();
            Console.ReadLine();
        }

        private void MyMethodWithError(int num = 0)
        {
            throw new Exception();
        }

        public void MyNormalMethod(int num = 0)
        {
            try
            {
                Console.WriteLine("\n||try||");
                MyMethodWithError();
            } catch (Exception e)
            {
                Console.WriteLine("\n||catch||");
                Console.WriteLine(e);
            } finally
            {
                Console.WriteLine("\n||finally||");
            }
        }


    }
}
