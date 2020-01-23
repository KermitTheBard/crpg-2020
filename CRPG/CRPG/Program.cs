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
            _player.MoveTo(World.LocationByID(World.LOCATION_ID_HOME));





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
                DisplayCurrentLocation();
            } else if (input.Contains("north"))
            {
                _player.MoveNorth();
                DisplayCurrentLocation();
            }
            else if (input.Contains("west"))
            {
                _player.MoveWest();
                DisplayCurrentLocation();
            }
            else if (input.Contains("east"))
            {
                _player.MoveEast();
                DisplayCurrentLocation();
            }
            else if (input.Contains("south"))
            {
                _player.MoveSouth();
                DisplayCurrentLocation();
            }
            else
            {
                Console.WriteLine("Don't Understand.");
            }
        }
        private static void DisplayCurrentLocation()
        {
            Console.WriteLine("You are at: {0}", _player.CurrentLocation.Name);
            if (_player.CurrentLocation.Description != "")
            {
                Console.WriteLine("\t{0}", _player.CurrentLocation.Description);
            }
        }
    }
}
