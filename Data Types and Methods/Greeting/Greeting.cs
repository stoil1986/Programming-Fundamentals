using System;


namespace Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string ageStr = Console.ReadLine();
            int age = int.Parse(ageStr); 
            Console.WriteLine($"Hello, {firstName} {lastName}.\t\nYou are {age} years old.");
        }
    }
}
