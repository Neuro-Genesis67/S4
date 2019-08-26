using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LambdaSort_Or_InterfaceSort {
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

        public static void PrintList(List<Person> persons) {
            foreach (var person in persons) {
                Console.WriteLine(person);
            }
            Console.WriteLine("\n");
        }

        public static void Print10Youngest10Oldest(List<Person> persons) {
            List<Person> newList = new List<Person>();
            persons.Reverse(10, persons.Count-10);
            persons.Reverse(10, 10);
            
            for (int i = 0; i < 20; i++) {
                newList.Add(persons[i]);
            }

            Person.PrintList(newList);
        }

        static void Main(string[] args) {
            string dataLocation = @"C:\Program Files (x86)\Eclipse\Github\S4\Read_A_CSV_File\data.csv";
            var peopleLambdaName   = Person.ReadCSVFile(dataLocation);
            var peopleLambdaAge    = Person.ReadCSVFile(dataLocation);
            var peopleLambdaWeight = Person.ReadCSVFile(dataLocation);
            var peopleName         = Person.ReadCSVFile(dataLocation);
            var peopleAge          = Person.ReadCSVFile(dataLocation);
            var peopleWeight       = Person.ReadCSVFile(dataLocation);

            //peopleName.Sort(new SortByName());
            //Person.PrintList(peopleName);
            //peopleLambdaName.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
            //Person.PrintList(peopleLambdaName);

            //peopleAge.Sort(new SortByAge());
            //Person.PrintList(peopleAge);
            //peopleLambdaAge.Sort((p1, p2) => p1.Age.CompareTo(p2.Age));
            //Person.PrintList(peopleLambdaAge);

            //peopleWeight.Sort(new SortByWeight());
            //Person.PrintList(peopleWeight);
            //peopleLambdaWeight.Sort((p1, p2) => p1.Weight.CompareTo(p2.Weight));
            //Person.PrintList(peopleLambdaWeight);

            peopleLambdaAge.Sort((p1, p2) => p1.Age.CompareTo(p2.Age));
            Person.Print10Youngest10Oldest(peopleLambdaAge);

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
            return a.Weight.CompareTo(b.Weight);
        }
    }
}
