using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDungeon
{
    class Wizard : Monster
    {
        public Wizard()
        {
            m_Weapon = new Weapon(WEAPON_TYPE.LIGHTNING);
            monster_type = MONSTER_TYPE.WIZARD;
        }

        public override void Attack(Character character)
        {
            AttackLightning();
            base.Attack(character);
        }
        public override void RemoveLifePoint(Weapon weapon)
        {
            base.RemoveLifePoint(weapon);
        }
        private void AttackLightning()
        {
            UserInterface.displayInfo(Program.DebugMode, "bzzzz coup de taser");
        }
    }
}
