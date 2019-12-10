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




            Console.ReadLine();
        }
    }
}
