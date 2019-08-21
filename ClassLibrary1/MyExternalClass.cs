using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MyExternalClass : IMyExternalClass
    {
        String name = "Name: MyExternalClass";
        public MyExternalClass()
        {

        }
        public string GetMeAsText()
        {
            return this.name;
        }

        public int GetMeDoubleTheAmount(int number)
        {
            return number * 2;
        }
    }
}
