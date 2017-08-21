using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean run = true;

            while (run)

            {
                Console.WriteLine("Please enter a value for length");
                int length = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Please neter a value for width");
                int width = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Let's Calculate!");

                int area = length * width;
                Console.WriteLine("The area of your classroom is: " + area);

                int perimeter = 2 * area;

                Console.WriteLine("The perimeter of your classroom is: " + perimeter);

                Console.WriteLine("What is the height of the room? ");
                int height = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int volume = length * width * height;

                Console.WriteLine("The volume of the classroom is: " + volume);

                Console.WriteLine();

                run = Continue();
             
            }

        }

        /*Static classes and class members are used to create data and functions that can be accessed without creating an instance of the class
         */

        public static Boolean Continue()
        {
            Boolean run = true;

            Console.WriteLine("Would you like to continue? Yes or No? ");
            string userInput = Console.ReadLine().ToLower().Trim();

            if (userInput == "yes")
            {
                run = true;

            }
            if (userInput == "no")
            {
                Console.WriteLine("We hope to see you next time!");
                run = false;
            }

            if (userInput != "yes" && userInput != "no")
            {
                Console.WriteLine("You entered an invalid input. Please try again. ");
                run = Continue();
            }

            return run; 

        }

    }
}
