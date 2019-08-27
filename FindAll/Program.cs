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
                // a.All persons with a score below 2
                // b.All persons with even score
                // c.All persons with even score and weight above 60
                // d.All persons with a weight divisible by 3

                List<Person> e1a = data1.FindAll(p => p.Score > 2);
                List<Person> e1b = data1.FindAll(p => p.Score % 2 != 1);
                List<Person> e1c = data1.FindAll(p => p.Score % 2 != 1 && p.Weight > 60);
                List<Person> e1d = data1.FindAll(p => p.Weight % 3 == 0);

                // Person.PrintList(e1d);


                // _______________  Exercise 2  _________________________
                // a.Use the FindIndex method on the List<T> class to find the index of the first person with a Score of 3.
                // b.Use FindIndex to find the index of the first person under 10 years, with a score of 3.
                // c.How many people are there under 10 years, with a score of 3?
                // d.Use FindIndex to find the index of the first person under 8 years, with a score of 3.
                // e.What does the return value mean?

                int index_a = data1.FindIndex(p => p.Score == 3);
                int index_b = data1.FindIndex(p => p.Age < 10 && p.Score == 3);
                persons = data1.FindAll(p => p.Age < 10 && p.Score == 3);
                int index_d = data1.FindIndex(p => p.Age < 8 && p.Score == 3); // No such thing
                                                                               // e: (The return value)
                                                                               // System.ArgumentOutOfRangeException: 
                                                                               // 'Index was out of range. 
                                                                               // Must be non-negative and less than the size of the collection.
                                                                               // Parameter name: index'

                //Console.WriteLine(data1[index_d]);
                // Console.WriteLine(persons.Count);
                // Person.PrintList(data1);


                // _______________  Exercise 3  _________________________
                //Write an extension method on the List <Person> class so you can make this call:
                //people.SetAccepted(p => p.Score >= 6 && p.Age <= 40);
                //(Hint: This is not a simple problem)

                //List<Person> E3 = data1.SetAccepted(p => p.Score >= 6 && p.Age <= 40);
                //Person.PrintList(E3);
                //Console.ReadKey();
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
                //Sorting with List<T>.Sort()
                //Sort persons after both Score and Age, (both ascending and descending)

                //var sortList = data1;
                ////sortList.Sort(new Sort_ScoreAge_Ascending());
                //sortList.Sort(new Sort_ScoreAge_Descending());
                //Person.PrintList(sortList);
                //Console.ReadKey();

                //public class Sort_ScoreAge_Ascending : IComparer<Person> {
                //    public int Compare(Person a, Person b) {
                //        if (a.Score > b.Score) {
                //            return 1;
                //        } else if (a.Score < b.Score) {
                //            return -1;
                //        }

                //        if (a.Age > b.Age) {
                //            return 1;
                //        } else if (a.Age < b.Age) {
                //            return -1;
                //        } else {
                //            return 0;
                //        }
                //    }
                //}

                //public class Sort_ScoreAge_Descending : IComparer<Person> {
                //    public int Compare(Person a, Person b) {
                //        if (a.Score < b.Score) {
                //            return 1;
                //        } else if (a.Score > b.Score) {
                //            return -1;
                //        }

                //        if (a.Age < b.Age) {
                //            return 1;
                //        } else if (a.Age > b.Age) {
                //            return -1;
                //        } else {
                //            return 0;
                //        }
                //    }
                //}


                // _______________  Exercise 5  _________________________
                //Create a new class EventClass. 
                //Give this class a StringToInt delegate that takes a string argument and returns an integer. 
                //Implement a method CountChars, that count chars in a string argument and returns the integer result.

                // See folder E05
                
                Console.ReadKey();
            }
        }
    }

    
    public class Sort_ScoreAge_Ascending : IComparer<Person> {
        public int Compare(Person a, Person b) {
            if (a.Score > b.Score) {
                return 1;
            } else if (a.Score < b.Score) {
                return -1;
            }

            if (a.Age > b.Age) {
                return 1;
            } else if (a.Age < b.Age) {
                return -1;
            } else {
                return 0;
            }
        }
    }
    public class Sort_ScoreAge_Descending : IComparer<Person> {
        public int Compare(Person a, Person b) {
            if (a.Score < b.Score) {
                return 1;
            } else if (a.Score > b.Score) {
                return -1;
            }

            if (a.Age < b.Age) {
                return 1;
            } else if (a.Age > b.Age) {
                return -1;
            } else {
                return 0;
            }
        }
    }
}

