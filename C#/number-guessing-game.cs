namespace number_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int drawnNum, guessedNum, attempts;

            Random r = new Random();

            Console.WriteLine("Hello! This is a game where you have to guess which number " +
               "has been drawn.\nI will tell you how many attempts you have made! " +
               "The number is an integer less than 10 and greater than -10. Good luck!" +
               "\nPlease type the guessed number: ");

            guessedNum = Convert.ToInt32(Console.ReadLine());
            drawnNum = r.Next(-10, 10);
            attempts = 1;
            while(drawnNum != guessedNum)
            {
                if (drawnNum < guessedNum)
                {
                    Console.WriteLine("Too much! Please try again: ");
                    guessedNum = Convert.ToInt32(Console.ReadLine());
                    attempts++;
                }

                else
                {
                    Console.WriteLine("Too little! Please try again: ");
                    guessedNum = Convert.ToInt32(Console.ReadLine());
                    attempts++;
                }
            }

            Console.WriteLine("Congratulations! You have guessed the right number on the " +
                + attempts + ". attempt.");
        }
    }
}