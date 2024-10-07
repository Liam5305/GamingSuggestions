using System;

namespace GamingSuggestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> gameNames = GetGames();
            GetGameReviews(gameNames);
        }

        public static List<string> GetGames()
        {
            List<string> gameNames = new List<string>();
            while (true)
            {
                Console.WriteLine("Please enter a game name of your choice");
                string gameNameStr = Console.ReadLine();

                gameNames.Add(gameNameStr);
                Console.WriteLine($"{gameNameStr} added.");

                Console.WriteLine("Do you want to add another game? Y/N");
                string shouldContinue = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(shouldContinue))
                {
                    Console.WriteLine("Invalid Input: User did not input. Will continue.");
                    break;
                }
                else if (shouldContinue == "N")
                {
                    break;
                }
                else if (shouldContinue == "No")
                {
                    Console.WriteLine("Invalid Input: User inputted 'No'. Will continue.");
                    break;
                }  
            }
            return gameNames;
        }

        private static void GetGameReviews(List<string> gameNames)
        {
            List<string> gameReviews = new List<string>();
            for (int i = 0; i < gameNames.Count; i++)
            {
                Console.WriteLine($"What is your review of {gameNames[i]}?");
                string userReview = Console.ReadLine();
                gameReviews.Add(userReview);

                if (string.IsNullOrWhiteSpace(userReview))
                {
                    Console.WriteLine("Please input a review. Blank inputs are not accepted.");
                    break;
                }
            }

            for (int i = 0; i < gameNames.Count; i++)
            {
                Console.WriteLine($"Game: {gameNames[i]}");
                Console.WriteLine($"Review: {gameReviews[i]}");
                Console.WriteLine("\n");
            }
        }
    }
}