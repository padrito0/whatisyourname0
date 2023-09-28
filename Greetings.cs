using System;

namespace Greetings 
{
    class Program 
    {

        static void Main(string[] args)
        {
            // Asking for user's name
            Console.WriteLine("Hello! What is your name?");
            
            // User inputs name
            string? name = Console.ReadLine(); 

            // Greet the user
            Console.WriteLine("It is nice to meet you, " + name + "!");

            // Stop program
            Console.ReadKey(); 

        }
    }
}