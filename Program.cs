using System;

namespace StringReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Takes user input, reverses it and prints the result to the console.
             */ 
            string line;
            Console.WriteLine("Enter xx to exit or any key to continue.");
            while ((line = Console.ReadLine()) != "xx")
            {
                Console.WriteLine("Enter whatever you want reversed:");
                string reverseMe = Console.ReadLine();

                if (!string.IsNullOrEmpty(reverseMe))
                {
                    string reversed = Reverse(reverseMe);
                    Console.WriteLine(reversed);
                    Console.WriteLine("Enter xx to exit or any key to continue.");
                }
                else
                {
                    Console.WriteLine("You didn't enter anything!");
                }
            }
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
