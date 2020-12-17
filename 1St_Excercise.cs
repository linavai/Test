// ---> 1

using System;

namespace excercise_1
{
     class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Test Data:");
            var testD = Console.ReadLine();
            var letter1 = testD[0];

            Console.WriteLine("Expected Output:"+"\n"+letter1+testD+letter1);
        }
        
    }
}