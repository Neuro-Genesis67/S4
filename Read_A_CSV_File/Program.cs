using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Read_A_CSV_File {

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
            return string.Format("Name: {0, -15}Age: {1, -10}Weight: {2}kg.",
                              this.Name, this.Age, this.Weight);
        }

        public static void print() {
            Console.WriteLine("print()");
        }

        public static List<Person> ReadCSVFile(string filename) {
            List<Person> personsFromFile = new List<Person>();
            var file = new StreamReader(filename);
            string csvData;
            while ((csvData = file.ReadLine()) != null) {
                personsFromFile.Add(new Person(csvData));
            }
            return personsFromFile;
        }

        static void Main(string[] args) {
            string dataLocation = @"C:\Program Files (x86)\Eclipse\Github\S4\Read_A_CSV_File\data.csv";
            var people = Person.ReadCSVFile(dataLocation);
            //var people = Person.ReadCSVFile(filename);
            Console.WriteLine("Number of people in data.csv: " + people.Count + "\n");

            foreach(var person in people) {
                Console.WriteLine(person);
            }
            Console.ReadKey();
        }
    }
}
