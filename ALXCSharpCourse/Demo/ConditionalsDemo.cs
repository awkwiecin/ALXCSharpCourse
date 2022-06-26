using ALXCSharpCourse.Enums;
using System;

namespace ALXCSharpCourse.Demo
{
    public class ConditionalsDemo
    {
        public static void Run()
        {
            int number = 3;

            if (number > 15)
            {
                Console.WriteLine($"The numer {number} is greater than 15");
            }
            else if (number == 15)
            {
                Console.WriteLine($"The number {number} is equal to 15");
            }
            else if (number == 3)
            {
                Console.WriteLine("I am a potato!");    
            }
            else
            {
                Console.WriteLine($"The numer {number} is smaller than 15");
            }
        }

        public static void RunNumberApp()
        {
            Console.WriteLine("Number app");
            Console.Write("Enter a number: ");
            int x;
            bool succeeded = Int32.TryParse(Console.ReadLine(), out x);
            //int x = Convert.ToInt32(Console.ReadLine());

            if (succeeded)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine($"The number {x} is eaven");
                }
                else
                {
                    Console.WriteLine($"The number {x} is odd");
                }
            }
            else
            {
                Console.WriteLine("The given input is not a number!");
            }

            /*
             * if (nipIsValid)
             *      invoiceService.ProcessRequest();
             * else
             *      invoiceService.Reject();
             */
        }

        public static void RunSwitch()
        {
            var sex = Sex.FEMALE;
            switch (sex)
            {
                case Sex.MALE:
                    Console.WriteLine("The sex is male");
                    Console.WriteLine("Hello");
                    break;

                case Sex.CUSTOM:
                    Console.WriteLine("The sex is custom");
                    break;

                default:
                    Console.WriteLine("default");
                    break;
            }

            Console.WriteLine("Switch end...");

            var number = 5;

            switch (number)
            {
                case 0:
                    Console.WriteLine("Hello");
                    break;

                case 1:
                    Console.WriteLine("I am a potato");
                    break;

                case 126:
                    Console.WriteLine("C# RULEZ");
                    break;

                default:
                    Console.WriteLine("default");
                    break;
            }

            Console.WriteLine("Switch end...");
        }
    }
}
