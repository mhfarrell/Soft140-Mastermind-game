using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class MasterMind
    {


        static void Main(string[] args)
        {
            bool validation = false;
            int[] colours;
            string[] history;
            int[] guess;
            guess = new int[4];
            colours = new int[4];
            history = new string[4];

            System.Console.WriteLine("You are now about to challenge the Mastermind!!");
            System.Console.WriteLine(" The Colour Codes are: Red = 1, Blue = 2, Green = 3 & Orange = 4");

            var r = new Random();
            // print random integer >= 1 and  < 5
            colours[0] = r.Next(1, 5);
            colours[1] = r.Next(1, 5);
            colours[2] = r.Next(1, 5);
            colours[3] = r.Next(1, 5);

            System.Console.WriteLine("The Mastermind grants you the first turn!");

            do
            {
                System.Console.WriteLine("Guess the first colour?");
                guess[0] = Convert.ToInt32(System.Console.ReadLine());

                if (guess[0] == colours[0])
                {
                    System.Console.WriteLine("You got it correct !");
                    validation = true;
                }
                else
                {
                    System.Console.WriteLine("You got it wrong");
                }
            }
            while (validation == false);
        }
    }


}
