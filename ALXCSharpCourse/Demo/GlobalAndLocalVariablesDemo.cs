using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demo
{
    public class GlobalAndLocalVariablesDemo
    {
        //global - properties and constants
        public int PropertyValue;
        public const int ConstValue = 2;
        public static void Run()
        {
            //local for Run()
            int x = 5 + ConstValue;
            MultiplyNumbers(2, 3);
        }

        private static void MultiplyNumbers(int v1, int v2)
        {
            //local for MultiplyNumbers
            var product = v1 * v2 + ConstValue;
            Console.WriteLine($"Product: {product}");
        }

        public void MultiplyValue(int exterlValue)
        {
            PropertyValue = PropertyValue * exterlValue;
            Console.WriteLine(PropertyValue);
        }
    }
}
