using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Zach A. Clapper, 2019-2020
namespace CRPG
{
    class Program
    {
        private static Player _player = new Player();
        static void Main(string[] args)
        {
            Console.WriteLine("I'm Zach");
            GameEngine.Initialize();
            _player.Name = "Zach";
            while (true)
            {
                Console.Write("> ");
                string userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    continue;
                }
                string cleanedInput = userInput.ToLower();
                if(cleanedInput == "exit")
                {
                    break;
                }
                ParseInput(cleanedInput);
            } //while

            Console.ReadLine();
        } //main
        public static void ParseInput(string input)
        {
            if (input.Contains("help"))
            {
                Console.WriteLine("Help is coming later...stay tuned.");
            } else if (input.Contains("look"))
            {
                //DisplayCurrenLocation
            } else
            {
                Console.WriteLine("Don't Understand.");
            }
        }
    }
}
