//Matt Farrell
//10404470
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class MasterMind
    {
        public void RunProgram()
        {
            //Declare all Varibles & arrays needed
            bool validation = false;
            int[] colours;
            int[] history;
            int[] guess;
            int x = 0;
            int i = 0;
            int j = 0;

            //Welcome player
            Console.WriteLine("You are now about to challenge the Mastermind!!");
            //Ask player for user input
            Console.WriteLine("How long do you want the code? (enter a number between 4 & 9)");
            i = Convert.ToInt32(Console.ReadLine());

            //I now check to see if the number the user has put is within range
            if (i > 9 | i < 4)
            {
                Console.WriteLine("Please Enter a number within range!");
                Console.WriteLine("How long do you want the code? (enter a number between 4 & 9)");
                i = Convert.ToInt32(Console.ReadLine());
            }

            //i now set all my arrays
            guess = new int[i];
            colours = new int[i];
            history = new int[i];         
            j = i + 1;
           
            //This is the start of the game
            Console.WriteLine("\n\nThe Mastermind grants you the first turn!");
            //i made sure x was 0 as if the game was replayed it could carry over a value
            x = 0;

            //This loop is my main loop, it loops based on what number the user inputted
            do
            {
                Console.WriteLine("\n\nYour Guess:");
                // My number generator has a value between >= 1 and  < j
                var r = new Random();
                //i could not find a good number generator that did not use a c special.
                colours[x] = r.Next(1, j);

                //My second loop checks to see if the answer is right or wrong
                do
                {
                    Console.WriteLine("\nGuess the colour code?");
                    guess[x] = Convert.ToInt32(Console.ReadLine());
                    if (guess[x] == colours[x])
                    {
                        //if right it displays a message, adds the loop exit claus and add the answer to the history array
                        Console.WriteLine("You got it correct !");
                        validation = true;
                        history[x] = guess[x];
                    }
                    else
                    {
                        //it is it wrong it loops until you guess the right answer
                        Console.WriteLine("You got it wrong");
                    }
                }
                while (validation == false);
                //after exiting the loop i reset the validation back to false for later use
                validation = false;
                //i increment x for the next cycle, the cycles start at 0
                x++;
            }
            while (x <= i-1);

            x = 0;            
            Console.WriteLine("\nYour Final Code was:");

            //i use a short loop to display the final code
            do
            {
                Console.WriteLine(Convert.ToString(history[x]));
                x++;
            }
            while (x < i);
        }


        static void Main(string[] args)
        {
            //This loads first when the program is started using this i can in essence loop the program
            int replay = 0;
            MasterMind myMastermindprogram = new MasterMind();
            myMastermindprogram.RunProgram();

            //Checks to see if the player wants to play again
            Console.WriteLine("\n\nWould you like to play again? (1 to reply & 0 to exit)");
            replay = Convert.ToInt32(Console.ReadLine());
            if (replay == 1)
            {
                //if they do it reloads the program from the start
                Console.WriteLine("\n\n\n");
                MasterMind replayMasterMind = new MasterMind();
                replayMasterMind.RunProgram();
            }
            else
            {
                //if not it gives the user the option to exit with a keypress
                Console.WriteLine("\n\n===============================");
                Console.WriteLine("MasterMind: Press any key to finish");
                Console.ReadKey();
            }
            //i am aware of the bug that exits the program after it has been replayed again i was not able to fix it in time

        }
    }
}

