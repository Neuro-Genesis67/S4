using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabulator
{
    class Person
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private double Weight { get; set; }
        public Person(string name, int age, double weight)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
        }

        public override string ToString()
        {
            return string.Format("|Name: {0}| |Age: {1}| |Weight: {2}kg.|", 
                              this.Name,      this.Age,      this.Weight);
        }

        static void Main(string[] args)
        {
            var tom = new Person("Tom", 28, 62.5);
            Console.WriteLine(tom);
            Console.ReadLine();
        }
    }
}
