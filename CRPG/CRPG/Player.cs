using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRPG
{
    class Player:LivingCreature
    {
        public string Name;
        public int Gold;
        public int Exp;
        public int Level;
        public List<InventoryItem> Inventory;
        public List<PlayerQuest> Quests;
        public Location CurrentLocation;

        public Player(string name, int currentHitPoints, int maximumHitPoints, int gold, int exp, int level):base(currentHitPoints, maximumHitPoints)
        {
            Name = name;
            Gold = gold;
            Exp = exp;
            Level = level;
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }

        public Player() { }
        public void MoveTo(Location loc)
        {
            //Check if item is needed to go
            if (loc.ItemRequiredToEnter != null)
            {
                bool playerHasItem = false;
                foreach(InventoryItem ii in this.Inventory)
                {
                    if (ii.Details.ID == loc.ItemRequiredToEnter.ID)
                    {
                        playerHasItem = true;
                        break;
                    }
                }
                if (!playerHasItem)
                {
                    Console.WriteLine("You must have a {0} to enter this location.", loc.ItemRequiredToEnter.Name);
                    return;
                }
                

            }
            CurrentLocation = loc;
        }
        public void MoveNorth()
        {
            if(CurrentLocation.LocationToNorth != null)
            {
                MoveTo(CurrentLocation.LocationToNorth);
            } else
            {
                Console.WriteLine("There is nothing north...");
            }
        }
        public void MoveWest()
        {
            if (CurrentLocation.LocationToWest != null)
            {
                MoveTo(CurrentLocation.LocationToWest);
            }
            else
            {
                Console.WriteLine("There is nothing west...");
            }
        }
        public void MoveSouth()
        {
            if (CurrentLocation.LocationToSouth != null)
            {
                MoveTo(CurrentLocation.LocationToSouth);
            }
            else
            {
                Console.WriteLine("There is nothing south...");
            }
        }
        public void MoveEast()
        {
            if (CurrentLocation.LocationToEast != null)
            {
                MoveTo(CurrentLocation.LocationToEast);
            }
            else
            {
                Console.WriteLine("There is nothing east...");
            }
        }
    } //player class

}
