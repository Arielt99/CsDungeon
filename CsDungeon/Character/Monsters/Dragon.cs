using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDungeon
{
    class Dragon : Monster
    {
        public Dragon()
        {
            m_Weapon = new Weapon(WEAPON_TYPE.SWORD);
            monster_type = MONSTER_TYPE.DRAGON;
        }

        public override void Attack(Character character)
        {
            UserInterface.displayInfo(Program.DebugMode, "coup de queue");
            base.Attack(character);
        }

        public override void RemoveLifePoint(Weapon weapon)
        {
            UserInterface.displayInfo(Program.DebugMode, "Il pleure des larmes de sang");
            base.RemoveLifePoint(weapon);

        }
    }
}
