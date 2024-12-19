namespace number_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool tezeden = true;
            
            Console.WriteLine("************************************************************************************");
            Console.WriteLine("Number Guessing Game");




            
            Random random = new Random();
            int r= random.Next(1,101);
            while (tezeden)
            {
                int guesses = 0;
                int number = 0;
                string cavab = "";
               
                while (number != r)
                {
                    Console.Write("Please guess a number between 1 and 100 (you have 5 chances) : ");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number > r)
                    {
                        Console.WriteLine($"{number} is too high");
                    }
                    else if (number < r)
                    {
                        Console.WriteLine($"{number} is too low");
                    }
                    guesses++;
                    if (guesses > 5)
                    {
                       
                        Console.WriteLine("Game Over");
                        break;
                    }
                }
                Console.WriteLine("Number: " + r);
                
                Console.WriteLine("Guesses: " + guesses);
                Console.WriteLine("Would you like to play again?(Y/N):");
                cavab = Console.ReadLine();
                cavab = cavab.ToUpper();
                if (cavab == "Y")
                {
                    tezeden = true;
                }
                else
                {
                    tezeden= false;
                }
               
                Console.WriteLine("Thanks for playing");

            }
          
            





















            while (Console.ReadKey().Key != ConsoleKey.Escape);


        }
    }
}
