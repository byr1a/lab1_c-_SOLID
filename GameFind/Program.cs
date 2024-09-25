using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace GameFind
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IUserInput input = new ConsoleInput();
            IOutput output = new ConsoleOutput();
            IRandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();

            output.Print("Введите минимальное число диапазона:");
            int min = input.GetInput();
            output.Print("Введите максимальное число диапазона:");
            int max = input.GetInput();

            GameSettings settings = new GameSettings(min, max);
            User user = new User(input, output);
            Game game = new Game(user, output, randomNumberGenerator, settings);

            while (true)
            {
                game.Play();
                if (input.GetInput() != 1)
                {
                    break;
                }
                
            }

        }
    }
}
