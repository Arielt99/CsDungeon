using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDungeon
{
    class Thief : Monster
    {

        public Thief()
        {
            m_Weapon = new Weapon(WEAPON_TYPE.BOW);
            monster_type = MONSTER_TYPE.THIEF;
        }

        public override void Attack(Character character)
        {
            AttackBow();
            base.Attack(character);
        }
        public override void RemoveLifePoint(Weapon weapon)
        {
            base.RemoveLifePoint(weapon);
        }
        private void AttackBow()
        {
            UserInterface.displayInfo(Program.DebugMode, "fleche dans ton fion");
        }


    }
}
