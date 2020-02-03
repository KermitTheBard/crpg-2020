using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRPG
{
    public class LootItem
    {
        public Item Details;
        public float DropChance;
        public bool IsDefaultItem;

        public LootItem(Item details, float dropChance, bool isDefaultItem)
        {
            Details = details;
            DropChance = dropChance;
            IsDefaultItem = isDefaultItem;
        }
    }
}
