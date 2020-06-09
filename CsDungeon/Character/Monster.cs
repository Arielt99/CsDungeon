using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDungeon
{     
    enum MONSTER_TYPE
        {
            BARBARIAN,
            THIEF,
            WIZARD, 
            DRAGON
        }
    abstract class Monster : Character
    {
        protected MONSTER_TYPE monster_type;
        public Monster() : base(Program.ENNEMI_HEALTH_POINT)
        {
        }
        internal MONSTER_TYPE GetMonsterType()
        {
            return monster_type;
        }
        public override void Attack(Character character)
        {
            Heros h = (Heros)character;
            UserInterface.displayInfo(Program.DebugMode,monster_type.ToString(), " vous attaque avec : ", m_Weapon.WeaponTypeProp.ToString());
            h.RemoveLifePoint(m_Weapon);
        }

        public override void RemoveLifePoint(Weapon p_HeroWeapon)
        {
            prop_iPvPoint -= p_HeroWeapon.WeaponDamage;
            UserInterface.displayInfo(Program.DebugMode, monster_type.ToString(), " a ", prop_iPvPoint.ToString(), "pv");
            if (IsDead)
            {
                UserInterface.displayInfo(Program.DebugMode, "le monstre est mort");
            }
        }
    }
}
