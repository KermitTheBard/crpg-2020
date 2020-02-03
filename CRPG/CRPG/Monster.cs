using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRPG
{
    public class Monster:LivingCreature
    {
        public int ID;
        public string Name;
        public int MaxDmg;
        public int RewardEXP;
        public int RewardGold;
        public List<LootItem> LootTable;

        public Monster(int iD, string name, int maxdmg, int rewardexp, int rewardgold, int currentHitPoints, int maximumHitPoints):base(currentHitPoints, maximumHitPoints)
        {
            ID = iD;
            Name = name;
            MaxDmg = maxdmg;
            RewardEXP = rewardexp;
            RewardGold = rewardgold;
            LootTable = new List<LootItem>();

        }
    }
}
