using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleProject
{
    class TriangleProgram
    {
        public void RunProgram()
        {
            int sideA;
            int sideB;
            int sideC;

            Console.Write("Please enter the first side of the triangle ");
            sideA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the second side of the triangle ");
            sideB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the third side of the triangle ");
            sideC = Convert.ToInt32(Console.ReadLine());

            if ((sideA == sideB) && (sideB == sideC))
            {
                Console.WriteLine("\n The triangle is an equilateral  ");
            }
            else if ((sideA == sideB) || (sideA == sideC) || (sideB == sideC))
            {
                Console.WriteLine("\n The triangle is an isosceles  ");
            }
            else
            {
                Console.WriteLine("\n The triangle is a  scalene ");
            }  // end if

        }

        static void Main(string[] args)
        {

            TriangleProgram myTriangleProgram = new TriangleProgram();
            myTriangleProgram.RunProgram();


            Console.WriteLine("\n\n===============================");
            Console.WriteLine("TriangleProgram: Press any key to finish");
            Console.ReadKey();

        }
    }
}
