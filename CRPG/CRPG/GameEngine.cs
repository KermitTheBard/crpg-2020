using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRPG
{
    public static class GameEngine
    {
        public static string Version = "0.0.2";

        public static void Initialize()
        { //tells us the standard info on game, such as version
            Console.WriteLine("Initializing Game Engine...");  
            Console.WriteLine("This is verion {0}", Version);
            Console.WriteLine("Welcome to the World of {0}", World.WorldName);
            Console.WriteLine();
            World.ListLocations();
            World.ListItems();
            World.ListMonsters();
            World.ListQuests();

        }
    }
}
