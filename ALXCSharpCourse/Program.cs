using ALXCSharpCourse.Demo;
using System;

namespace ALXCSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //mlotekDoDrewna -> camel case -> Variables
            //MlotekDoDrewna -> pascal case -> Classes , Methods, Properties
            Console.WriteLine("Hello World!");
            //VariablesDemo.Run();
            //VariablesDemo.RunCalculator();
            //VariablesDemo.RunLogicalCalculator();
            //FunctionsDemo.Run();
            //ClassesDemo.Run();
            //EnumsDemo.Run();
            //ConditionalsDemo.RunNumberApp();
            //ArraysAndListsDemo.RunLists();
            //LoopsDemo.Run();
            //ConditionalsDemo.RunSwitch();
            GlobalAndLocalVariablesDemo.Run();
            Console.WriteLine("Bye!");
            var demoClass = new GlobalAndLocalVariablesDemo();
            demoClass.PropertyValue = 21;
            demoClass.MultiplyValue(23);
        }
    }
}
