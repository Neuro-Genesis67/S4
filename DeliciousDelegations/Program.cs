using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate int StringToInt(string s);

namespace DeliciousDelegations {
    // _______________  Exercise 5  _________________________
    // Create a new class EventClass. 
    // Give this class a StringToInt delegate that takes a string argument and returns an integer. 
    // Implement a method CountChars, that count chars in a string argument and returns the integer result.

    // _______________  Exercise 6  _________________________
    // Create a StringToInt delegate from your CountChars method. 
    // Use the delegate to count the chars in 3 different strings. 

    // _______________  Exercise 7  _________________________
    // Create a method DelegateUser that takes two arguments: 
    // a StringToInt delegate and a string argument. 
    // DelegateUser must call the delegate with the string argument and return the result.
    // Demonstrate that you can use your DelegateUser on a string.

    class EventClass {
        public static void Main () {
            StringToInt sti = new StringToInt(CountChars);
            Console.WriteLine(sti.Invoke("I ate a bear. Who wins now huh?"));
            Console.WriteLine(sti.Invoke("I used to be a strong man, now I'm stronger!"));
            Console.WriteLine(sti.Invoke("I found money in my asscrack the other day. I suspect fame will reach me any moment now"));
            Console.WriteLine(DelegateUser(sti, "Yes baby, turn me into a pamphlet"));
            Console.ReadKey();
        }
        public static int CountChars(string s) {
            return s.Length;
        }
        public static int DelegateUser(StringToInt sti, string str) {
            int result = sti(str);
            return result;
        }
    }
}
