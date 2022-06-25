using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demo
{
    public class FunctionsDemo
    {
        public static void Run()
        {
            Console.WriteLine("-- Functions demo --");
            WriteSentence();
            WriteSentence("Truskawki są smaczne...");
            WriteSentence("Truskawki są smaczne...", 12);
            WriteSentence("truskawki", 4.00);
            int sum = AddNumbers(2, 3);
            Console.WriteLine(sum);
            string address = FormatAddress("Jasna", "12", "23");
            Console.WriteLine(address);
            Console.WriteLine(FormatAddress("Meander", "22", "11"));
            Console.WriteLine("\n------\n");
        }

        /*
         modyfikatorDostepu coZwraca Nazwa(argumenty)
         sygnatura funcji: coZwraca Nazwa(argumenty)
         */

        public static void WriteSentence() 
        {
            Console.WriteLine("Hello");
        }

        //Overload
        public static void WriteSentence(string sentence)
        {
            Console.WriteLine(sentence);
        }

        //Overload
        public static void WriteSentence(string sentence, int number)
        {
            Console.WriteLine($"sentence: {sentence}, number: {number}");
        }

        public static int WriteSentence(string sentence, double number)
        {
            return 0;
        }

        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public static string FormatAddress(string streetName, string buildingNumber, string flatNumber)
        {
            return $"Ulica {streetName} {buildingNumber}/{flatNumber}";
        }
    }
}
