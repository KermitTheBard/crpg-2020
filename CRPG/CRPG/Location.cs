using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRPG
{
    public class Location
    {
        public int ID;
        public string Name;
        public Item ItemRequiredToEnter;
        public Quest QuestAvailableHere;
        public Monster MonsterLivingHere;
        public string Description;
        public Location LocationToNorth, LocationToSouth, LocationToWest, LocationToEast;

        //constructor
        public Location(int iD, string name, string description, Item itemRequiredToEnter = null, Quest questAvailableHere = null, Monster monsterLivingHere = null)
        {
            ID = iD;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
        }
    }
}
