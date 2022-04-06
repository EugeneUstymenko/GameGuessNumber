using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuessNumber
{
    public class ImplementationPoints
    {
        private int score = 100;
        public void PrintScore()
        {
            Console.WriteLine($"Your score is {score}");
        }
        public int PlaceBet()
        {
            bool f;
            int verifiedBet;
            do
            {
                f = true;
                Console.Write("Place your bet: ");
                string bet = Convert.ToString(Console.ReadLine());
                if (!int.TryParse(bet, out verifiedBet))
                {
                    f = false;
                    Console.Write("Input argument data is not valid. Argument data must be whole number\n");
                }
                if (verifiedBet < 10)
                {
                    f = false;
                    Console.Write("Input argument data is not valid. Argument data must be not less '10'\n");
                }
                if (verifiedBet > score)
                {
                    f = false;
                    Console.Write($"Input argument data is not valid. Argument data cannot be more than {score}\n");
                }
            } while (!f);
            return verifiedBet;
        }
        public int Scoring(int verifiedBet, int s)
        {
            int tmpBet;
            int tmpScore = score - verifiedBet;
            if (s == 5)
            {
                tmpBet = verifiedBet;
            }
            else if (s > 5)
            {
                tmpBet = 0;
            }
            else
            {
                tmpBet = s * verifiedBet;
            }
            return score = tmpScore + tmpBet;
        }
    }
}
