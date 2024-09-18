namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int choosennumber = rastgele.Next(1, 100);
            int guess,attempts = 5;

            Console.WriteLine("===================================");
            Console.WriteLine("     WELCOME TO GUESS GAME!!!      ");
            Console.WriteLine("===================================");

            Console.WriteLine("Enter a number between one and one hundred");
            while (attempts > 0)
            {
                Console.WriteLine("Please Enter Your Guess");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess > choosennumber)
                {
                    Console.WriteLine("You entered a number bigger than The selected number");
                }
                else if (guess < choosennumber)
                {
                    Console.WriteLine("You entered a number smaller than The selected number");
                }
                else
                {
                    Console.WriteLine("Congratulations, You Found The Number");
                    break;
                }

                attempts--;
                if (attempts > 0)
                {
                    Console.WriteLine("Remaining chances: " + attempts);
                }
                else
                {
                    Console.WriteLine("Sorry Your Chances İs Over.: " + choosennumber);
                }

                Console.WriteLine("GAME OVER.");


            }

        }
    }
}
