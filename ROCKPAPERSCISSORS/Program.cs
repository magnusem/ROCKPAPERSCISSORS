using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputplayer, inputcpu;
            int randomInt;

            Console.WriteLine("Choose between ROCK, PAPER and SCISSORS:");
            inputplayer = Console.ReadLine();

            Random random = new Random();

            randomInt = random.Next(1,4);

            switch (randomInt)
            {
                case 1:
                    inputcpu = "ROCK";
                    break;
                case 2:
                    inputcpu = "PAPER";
                    break;
                case 3:
                    inputcpu = "SCISSORS";
                    break;
            }
        }
    }
}
