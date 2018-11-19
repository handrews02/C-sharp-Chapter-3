using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringUserGuess;
            int userGuess;
            Console.WriteLine("Pick a number 1, 2, or 3");
            stringUserGuess = Console.ReadLine();
            userGuess = Convert.ToInt32(stringUserGuess);


            if (userGuess == 1)
            {
                Console.WriteLine("You are WRONG!");

            }
            else if (userGuess == 2)
            {
                Console.WriteLine("Yay you are correct!");
            }
            else if(userGuess == 3)
            {
                Console.WriteLine("You are WRONG!");
            }
            else
            {
                Console.WriteLine("ERROR");
            }

        }
    }
}
