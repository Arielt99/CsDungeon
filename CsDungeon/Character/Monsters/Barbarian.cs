using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDungeon
{
    class Barbarian : Monster
    {
        public Barbarian()
        {
            m_Weapon = new Weapon(WEAPON_TYPE.SWORD);
            monster_type = MONSTER_TYPE.BARBARIAN;
        }

        public override void Attack(Character character)
        {
            AttackSword();
            base.Attack(character);
        }
        public override void RemoveLifePoint(Weapon weapon)
        {
            base.RemoveLifePoint(weapon);
        }

        private  void AttackSword()
        {
            UserInterface.displayInfo(Program.DebugMode, "wsh coup de batoooon");
        }
    }
}
