using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Split
{
    class Person {
        private string Name { get; set; }
        private int Age { get; set; }
        private double Weight { get; set; }
        public Person(string personData) {
            string[] traits = personData.Split(';');
            Name = traits[0];
            int.TryParse(traits[1], out int parsedAge);
            Age = parsedAge;
            double.TryParse(traits[2], out double parsedWeight);
            Weight = parsedWeight;
        }
        public override string ToString() {
            return string.Format("{0, -8}:  {1, -1} years,  {2} kg",
                              this.Name,  this.Age,  this.Weight);
        }
        static void Main(string[] args) {
            var tom = new Person("Saul;60;63");
            Console.WriteLine(tom);
            Console.ReadKey(); 
        }
    }
}
