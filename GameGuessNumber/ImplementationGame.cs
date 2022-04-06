using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGuessNumber
{
    public static class ImplementationGame
    {
        
        public static int NumberPC()
        {
            Random rnd = new Random();
            int numberPC = rnd.Next(0, 101);
            return numberPC;
        }
        public static bool CheckNumberPlayer(string numberPlayer)
        {
            if (numberPlayer == null)
            {
                throw new ArgumentNullException("Input argument data is null.");
            }

            bool flag = true;
            if (int.TryParse(numberPlayer, out int number) == false)
            {
                flag = false;
                Console.WriteLine("Input argument data is not valid. Argument data must be whole number.");
            }
            if (number < 0 || number > 100)
            {
                flag = false;
                Console.WriteLine("Input argument data is out of range exteption. Argument data cannot be negative and cannot be more than '100'.");
            }
            return flag;
        }
        public static bool ComparisonNumbers(string numberPlayer, int numberPC)
        {
            if (numberPlayer == null)
            {
                throw new ArgumentNullException("Input argument data is null.");
            }
            if (int.TryParse(numberPlayer, out int number) == false)
            {
                throw new ArgumentException("Input argument data is not valid.");
            }
            if (number < 0 || numberPC < 0 || number > 100 || numberPC > 100)
            {
                throw new ArgumentOutOfRangeException("Input argument data out of range exteption.");
            }

            bool flag = true;
            if (number > numberPC)
            {
                flag = false;
                Console.WriteLine("Your number is greater than the number of the computer. Try entering the number again.");
            }
            if (number < numberPC)
            {
                flag = false;
                Console.WriteLine("Your number is less than the number of the computer. Try entering the number again.");
            }
            if (number == numberPC)
            {
                Console.WriteLine("You guessed the number! Congratulations.");
            }
            return flag;
        }
        public static bool ReplayQuestionTrigger()
        {
            bool flag;
            string answerPlayer;
            do
            {
                flag = false;
                Console.Write("\nDo you want to play again? (Y - yes, N - no): ");
                answerPlayer = Convert.ToString(Console.ReadLine());
                if (!(answerPlayer == "Y" || answerPlayer == "N" || answerPlayer == "y" || answerPlayer == "n"))
                {
                    flag = true;
                    Console.Write("Input argument data is not valid. Argument data must be 'Y' or 'N'");
                }
            }
            while (flag);
            if (answerPlayer == "Y" || answerPlayer == "y")
            {
                flag = true;
            }
            return flag;
        }
    }
}
