using System;

namespace CTutorial {
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello my name is {0}", name);

            try
            {
                string readNumber = Console.ReadLine();
                int convertedString = Convert.ToInt32(readNumber);
                Console.WriteLine("The number was able to be converted");
            } catch (Exception)
            {
                Console.WriteLine("The number was not able to be converted");
            }
        }
    }  
}
