using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CheckTriangle
{
    class Program
    {
       static string GetTriangleType(decimal a,decimal b, decimal c)
        {
            if (a == b && b == c) //Liksidig om alla sidor är lika långa, a==b==c
                return "equilateral";
            else
            if (a == b || a == c || b == c)// Likbent om två sidor är lika långa
                return "equilateral";
            else
            return "scalene";//en triangel som inte har två sidor som är lika långa 


        }
        static void Main(string[] args)
        {
            //Write a program that determines the type of a triangle.
            //    It should take the lengths of the triangle's three sides as input, and return
            //    whether the triangle is equilateral, isosceles or scalene.
            //    Also consider tests, documentation and/ or errors.

            // input values 3 sides.
            decimal decside1, decside2, decside3;// declaration of the length of the 3 sides in the triangle

            try
            {


                Start:
                Console.Clear();
                Console.WriteLine("Triangle check program");
                Console.WriteLine();
                Console.WriteLine("A Triangle has 3 sides");
                Side1:
                Console.WriteLine("Write the lenght of first side");
                var side1 = Console.ReadLine();

                if (!decimal.TryParse(side1, out decside1))
                {
                    Console.WriteLine(side1 + " " + "was not a number");
                    Console.WriteLine("try again");
                    goto Side1;
                }
                Side2:
                Console.WriteLine("Write the lenght of second side");
                var side2 = Console.ReadLine();
                if (!decimal.TryParse(side2, out decside2))
                {
                    Console.WriteLine(side2 + " " + "was not a number");
                    Console.WriteLine("try again");
                    goto Side2;
                }



                Side3:
                Console.WriteLine("Write the lenght of third side");
                var side3 = Console.ReadLine();

                if (!decimal.TryParse(side3, out decside3))
                {
                    Console.WriteLine(side3 + " " + "was not a number");
                    Console.WriteLine("try again");
                    goto Side3;
                }

                Console.WriteLine("The triangle is a " + GetTriangleType(decside1, decside2, decside3));
                Console.WriteLine();


                Console.WriteLine("Press key y to run again, otherwise press another key to end program");
                var ch = Console.ReadKey();
                if (ch.KeyChar.Equals('y') || ch.KeyChar.Equals('Y'))
                    goto Start;
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong see error message:" + e.ToString());
                Console.ReadKey();

            }

            }


    }
}

