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

                Console.WriteLine($"Computer: {computer} \nYou: {player}");
                Console.WriteLine(resultOfGame(player, computer));

                Console.WriteLine("Do you want to play again? (Y/N)");
                choose = (Console.ReadLine()).ToUpper();
            }
        }

        static string resultOfGame(string player, string computer)
        {
            string temp = "DRAW"; 
            if (player == computer) return temp;

            switch (player)
            {
                case "ROCK":
                {       
                        temp = (computer == "PAPER") ? "You LOOSE" : "You WIN!";
                        break;
                }
                case "PAPER":
                {
                        temp = (computer == "SCISSORS") ? "You LOOSE!" : "You WIN!";
                        break;
                }
                case "SCISSORS":
                {
                        temp = (computer == "ROCK") ? "You LOOSE!" : "You WIN!";
                        break;
                }
                default:
                {
                        temp = "Not a valid option!";
                        break;
                }
            }

            return temp;
        }
    }
}