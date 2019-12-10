using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRPG
{
    public static class GameEngine
    {
        public static string Version = "0.0.1";

        public static void Initialize()
        { //tells us the standard info on game, such as version
            Console.WriteLine("Initializing Game Engine...");  
            Console.WriteLine("This is verion {0}", Version);

        }
    }
}
