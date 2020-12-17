using System;

namespace excercise_3
{
     class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Enter word:");
            var word = Console.ReadLine();

            char[] letters = word.ToCharArray();
            Array.Reverse(letters);

            var ResFin = new String(letters);

            Console.WriteLine(ResFin);
        }
        
    }
}