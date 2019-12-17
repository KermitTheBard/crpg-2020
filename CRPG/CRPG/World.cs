using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRPG
{
    public class World
    {
        public static readonly string WorldName = "Lyos";
        public static readonly List<Location> Locations = new List<Location>();

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_VILLAGE_SQUARE = 2;
        public const int LOCATION_ID_VILLAGE_OUTSKIRTS = 3;
        public const int LOCATION_ID_FOREST_ENTRANCE = 4;
        public const int LOCATION_ID_FOREST_1 = 5;
        public const int LOCATION_ID_FOREST_2 = 6;
        public const int LOCATION_ID_FOREST_3 = 7;
        public const int LOCATION_ID_FOREST_4 = 8;
        public const int LOCATION_ID_FOREST_5 = 9;
        public const int LOCATION_ID_FOREST_DEPTHS = 10;

    static World()
        {
            PopulateLocations();
        }
        private static void PopulateLocations()
        {
            Location home = new Location(LOCATION_ID_HOME, "Home", "You and your parents reside here. Very cozy.");
            Location villageSquare = new Location(LOCATION_ID_VILLAGE_SQUARE, "Village Square", "This is the center of the village, savvy to lots of business");
            Location villageOutskirts = new Location(LOCATION_ID_VILLAGE_OUTSKIRTS, "Outskirts of Village", "This area is along the edges of the village. Still safe though");
            Location forestEntrance = new Location(LOCATION_ID_FOREST_ENTRANCE, "Forest Entrance", "Here you can enter the forest!");
            Location forest1 = new Location(LOCATION_ID_FOREST_1, "Forest R1", "You are within the forest...");
            Location forest2 = new Location(LOCATION_ID_FOREST_2, "Forest R2", "You are within the forest...");
            Location forest3 = new Location(LOCATION_ID_FOREST_3, "Forest R3", "You are within the forest...");
            Location forest4 = new Location(LOCATION_ID_FOREST_4, "Forest R4", "You are within the forest...");
            Location forest5 = new Location(LOCATION_ID_FOREST_5, "Forest R5", "You are within the forest...");
            Location forestDepths = new Location(LOCATION_ID_FOREST_DEPTHS, "Forest Depths", "Something powerful is rumored to lurk here....");
            
            //location links
            home.LocationToEast = villageOutskirts;
            villageOutskirts.LocationToWest = home;
            home.LocationToSouth = villageSquare;
            villageSquare.LocationToNorth = home;
            villageOutskirts.LocationToNorth = forestEntrance;
            forestEntrance.LocationToSouth = villageOutskirts;
            forestEntrance.LocationToNorth = forest1;
            forest1.LocationToNorth = forest2;
            forest2.LocationToNorth = forest3;
            forest4.LocationToNorth = forest5;
            forest5.LocationToNorth = forestDepths;
            forestDepths.LocationToNorth = forestEntrance;
            

            //location list
            Locations.Add(home);
            Locations.Add(villageSquare);
            Locations.Add(villageOutskirts);
            Locations.Add(forestEntrance);
            Locations.Add(forest1);
            Locations.Add(forest2);
            Locations.Add(forest3);
            Locations.Add(forest4);
            Locations.Add(forest5);
            Locations.Add(forestDepths);
        }
        public static Location LocationByID(int id)
        {
            foreach (Location loc in Locations)
            {
                if(loc.ID == id)
                {
                    return loc;
                }
            }
            return null;
        }
        public static void ListLocations()
        {
            Console.WriteLine("You open your map, and in it reveals these locations:");
            foreach(Location loc in Locations)
            {
                Console.WriteLine("\t{0}", loc.Name);
            }
        }
    }
}
