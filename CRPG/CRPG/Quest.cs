using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRPG
{
    public class Quest
    {
        public int ID;
        public string Name;
        public string Description;
        public int RewardlExperiencePoints;
        public int RewardGold;
        public Item RewardItem;
        public List<QuestCompletionItem> QuestCompletionItems;

        public Quest(int iD, string name, string description, int rewardExperiencePoints, int rewardGold, Item rewardItem = null, List<QuestCompletionItem> questCompletionItems = null)
        {
            ID = iD;
            Name = name;
            Description = description;
            RewardlExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            RewardItem = rewardItem;
            QuestCompletionItems = new List<QuestCompletionItem>();
        }
    }
}
