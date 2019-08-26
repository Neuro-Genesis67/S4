using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAll {

    public static class ExtensionMethods {
        public static List<Person> SetAccepted(this List<Person> persons, Func<Person, bool> logicAppliesTo) {
            List<Person> newList = new List<Person>();
            foreach (var p in persons) {
                if (logicAppliesTo(p))
                    newList.Add(p);
            }
            return newList;
        }
    }
    public class Person {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public int Score { get; set; }
        public Person(string personData) {
            string[] traits = personData.Split(';');
            Name = traits[0];
            int.TryParse(traits[1], out int parsedAge);
            Age = parsedAge;
            double.TryParse(traits[2], out double parsedWeight);
            Weight = parsedWeight;
            int.TryParse(traits[3], out int parsedScore);
            Score = parsedScore;
        }
        public override string ToString() {
            return string.Format(
                "Name: {0, -15} " +
                "Age: {1, -10}" +
                "Weight: {2, -10}" +
                "Score: {3, -10}",
                this.Name, 
                this.Age, 
                this.Weight, 
                this.Score);
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

        class Program {

            static void Main(string[] args) {
                Person person;
                List<Person> persons;

                string dataLocation1 = @"C:\Program Files (x86)\Eclipse\Github\S4\Lektion03_data\data1.csv";
                string dataLocation2 = @"C:\Program Files (x86)\Eclipse\Github\S4\Lektion03_data\data2.csv";
                List<Person> data1 = Person.ReadCSVFile(dataLocation1);
                List<Person> data2 = Person.ReadCSVFile(dataLocation2);

                // _______________  Exercise 1  _________________________
                List<Person> e1a = data1.FindAll(p => p.Score > 2);
                List<Person> e1b = data1.FindAll(p => p.Score % 2 != 1);
                List<Person> e1c = data1.FindAll(p => p.Score % 2 != 1 && p.Weight > 60);
                List<Person> e1d = data1.FindAll(p => p.Weight % 3 == 0);

                // Person.PrintList(e1d);
                   
                // a.All persons with a score below 2
                // b.All persons with even score
                // c.All persons with even score and weight above 60
                // d.All persons with a weight divisible by 3


                // _______________  Exercise 2  _________________________
                int index_a = data1.FindIndex(p => p.Score == 3);
                int index_b = data1.FindIndex(p => p.Age < 10 && p.Score == 3);
                persons     = data1.FindAll(  p => p.Age < 10 && p.Score == 3);
                int index_d = data1.FindIndex(p => p.Age < 8  && p.Score == 3); // No such thing
                // e: (The return value)
                // System.ArgumentOutOfRangeException: 
                // 'Index was out of range. 
                // Must be non-negative and less than the size of the collection.
                // Parameter name: index'

                //Console.WriteLine(data1[index_d]);
                // Console.WriteLine(persons.Count);
                // Person.PrintList(data1);

                // a.Use the FindIndex method on the List<T> class to find the index of the first person with a Score of 3.
                // b.Use FindIndex to find the index of the first person under 10 years, with a score of 3.
                // c.How many people are there under 10 years, with a score of 3?
                // d.Use FindIndex to find the index of the first person under 8 years, with a score of 3.
                // e.What does the return value mean?


                // _______________  Exercise 3  _________________________
                List<Person> E3 = data1.SetAccepted(p => p.Score >= 6 && p.Age <= 40);
                Person.PrintList(E3);

                //public static class ExtensionMethods {
                //    public static List<Person> SetAccepted(this List<Person> persons, Func<Person, bool> logicAppliesTo) {
                //        List<Person> newList = new List<Person>();
                //        foreach (var p in persons) {
                //            if (logicAppliesTo(p))
                //                newList.Add(p);
                //        }
                //        return newList;
                //    }
                //}


                // _______________  Exercise 4  _________________________









                Console.ReadKey();
            }
        }
    }
}
