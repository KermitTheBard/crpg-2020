using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRPG
{
    public class Weapon : Item
    {
        public int MaxDmg;
        public int MinDmg;

        public Weapon(int id, string name, string namePlural, int maxdmg, int mindmg):base(id, name, namePlural)
        {
            MaxDmg = maxdmg;
            MinDmg = mindmg;
        }
    }
}
