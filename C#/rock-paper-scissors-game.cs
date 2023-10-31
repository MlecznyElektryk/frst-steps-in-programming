using System.Reflection.Metadata.Ecma335;

namespace rock_paper_scissors_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choose = "Y";
            int temp;
            string[] choices = { "ROCK", "SCISSORS" , "PAPER" };
            string player, computer;
            Random random = new Random();

            while(choose == "Y")
            {
                temp = random.Next(0, 2);
                computer = choices[temp];

                Console.WriteLine("Rock, paper or scissors? \nType your guess: ");
                player = (Console.ReadLine()).ToUpper();

                Console.WriteLine(resultOfGame(player, computer));

                Console.WriteLine("Do you want to play again? (Y/N)");
                choose = (Console.ReadLine()).ToUpper();
            }
        }

        static string resultOfGame(string player, string computer)
        {
            string temp = "DRAW"; 
            if (player == computer) return temp;

            switch (computer)
            {
                case "ROCK":
                {
                        temp = (player == "PAPER") ? "You WIN!" : "You LOOSE!";
                        break;
                }
                case "PAPER":
                {
                        temp = (player == "SCISSORS") ? "You WIN!" : "You LOOSE!";
                        break;
                }
                case "SCISSORS":
                {
                        temp = (player == "ROCK") ? "You WIN!" : "You LOOSE!";
                        break;
                }
            }

            return temp;
        }
    }
}