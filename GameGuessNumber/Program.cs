using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Rules: you have a certain number of points. Every time before the game, \n" +
                    "you place a bet that will not exceed your number of points. The minimum bet is 10 points. \n" +
                    "If you guess the number: for the first attempt - your points x5; for the second -x4; for the third -x3; \n" +
                    "for the fourth -x2; for the fifth - return the set points; if more than five attempts your bet is lost. " +
                    "\nGoal to score 300 points. Lost if you have 0 points left");*/
            int tryGuessNumberPC = 0;
            ImplementationPoints implementationPoints = new ImplementationPoints();
            do
            {
                implementationPoints.PrintScore();
                int verifiedBet = implementationPoints.PlaceBet();
                Console.WriteLine("\nFor the game, the number must be in the range from '0' to '100'");
                string numberPlayer;
                int numberPC = ImplementationGame.NumberPC();
                Console.WriteLine(numberPC);
                do
                {

                    do
                    {
                        Console.Write("\nEnter the number: ");
                        numberPlayer = Convert.ToString(Console.ReadLine());
                    }
                    while (!ImplementationGame.CheckNumberPlayer(numberPlayer));
                    tryGuessNumberPC++;
                }
                while (!ImplementationGame.ComparisonNumbers(numberPlayer, numberPC));
                implementationPoints.Scoring(verifiedBet, tryGuessNumberPC);
            }
            while (ImplementationGame.ReplayQuestionTrigger());
            Console.WriteLine("Thanks for the game.");
            implementationPoints.PrintScore();

            Console.ReadKey();
        }
    }
}
