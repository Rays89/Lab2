using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number_2
{
    class Program
    {
        static void Main(string[] args)

        {
            //input

            string Length;
            string Width;
            string input = "y";
            double x, y, area, perimeter;

            bool user = true;

            Console.WriteLine("\n Welcome to Grand Circus' Room Detail Generator! \n ");

            while (user) // you can also say while (true) 
            {
                Console.WriteLine("\n Enter the length \n ");
                Length = Console.ReadLine();   //  you can either say x = int.parse(console.readline());
                x = int.Parse(Length);

                Console.WriteLine("\n Enter the width \n  ");

                Width = Console.ReadLine();
                y = int.Parse(Width);


                //process
                area = x * y;
                perimeter = 2 * (x + y);
                Console.WriteLine(" The area is: " + area);
                Console.WriteLine("The perimeter is: " + perimeter);


                Console.WriteLine("Do you want to Continue? (y/n)");
                input = Console.ReadLine();

                if (input.ToLower() == "y")
                {
                    continue;
                }

                else
                {
                    user = false;
                    Console.WriteLine("Thank you and bye.");

                }
            }

        }
    }
}
