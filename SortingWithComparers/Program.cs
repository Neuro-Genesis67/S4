using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingWithComparers {
    public class Person {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
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
            var peopleName = Person.ReadCSVFile(dataLocation);
            var peopleAge = Person.ReadCSVFile(dataLocation);
            var peopleWeight = Person.ReadCSVFile(dataLocation);

            Console.WriteLine("\nSorting by name: ");
            peopleName.Sort(new SortByName());
            foreach (var person in peopleName) {
                Console.WriteLine(person);
            }

            Console.WriteLine("\nSorting by age: ");
            peopleAge.Sort(new SortByAge());
            foreach (var person in peopleAge) {
                Console.WriteLine(person);
            }

            Console.WriteLine("\nSorting by weight: ");
            peopleWeight.Sort(new SortByWeight());
            foreach (var person in peopleWeight) {
                Console.WriteLine(person);
            }

            Console.ReadKey();
        }
    }

    public class SortByName : IComparer<Person> {
        public int Compare(Person a, Person b) {
            return string.Compare(a.Name, b.Name);
        }
    }
    public class SortByAge : IComparer<Person> {
        public int Compare(Person a, Person b) {
            return a.Age.CompareTo(b.Age);
        }
    }
    public class SortByWeight : IComparer<Person> {
        public int Compare(Person a, Person b) {
            if (a.Weight > b.Weight) {
                return 1;
            } else if (a.Weight < b.Weight) {
                return -1;
            } else {
                return 0;
            }
        }
    }
}
