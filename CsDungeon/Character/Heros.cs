using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDungeon
{
    class Heros : Character
    {
        #region déclaration de variable
            string m_sName;
            Protection m_Protection;
        #endregion
        public Protection ChoosenProtectionProp { get; set; }
        #region Contructeur

        /// <summary>
        /// Heros constructor
        /// </summary>
        /// <param name="p_sName"> hero's name </param>
        public Heros(string p_sName) : base(Program.PLAYER_BASE_HEALTH_POINT)
        {
            m_sName = p_sName;

            UserInterface.displayInfo(Program.DebugMode, "Naissance du hero : ", m_sName);
            UserInterface.displayInfo(Program.DebugMode, "avec : ", prop_iPvPoint.ToString(), " pv");
            HeroArsenal = new Arsenal();
            UserInterface.displayInfo(Program.DebugMode, "voici l'arsenal du hero :");
            foreach (var item in HeroArsenal)
            {
                UserInterface.displayInfo(Program.DebugMode, item.ToString());
            }
            HeroArsenal.WeaponUsed = Arsenal.get(WEAPON_TYPE.SWORD);

            UserInterface.displayInfo(Program.DebugMode, "vous êtes arme de :", HeroArsenal.WeaponUsed.WeaponTypeProp.ToString());
            m_Weapon = HeroArsenal.WeaponUsed;

        }
        #endregion

        public override void Attack(Character character)
        {
            Monster m = (Monster)character;
            UserInterface.displayInfo(Program.DebugMode, "Vous attaquez un ", m.GetMonsterType().ToString());
            m.RemoveLifePoint(m_Weapon);
        }

        public override void RemoveLifePoint(Weapon p_MonsterWeapon)
        {
            prop_iPvPoint -= p_MonsterWeapon.WeaponDamage;
            UserInterface.displayInfo(Program.DebugMode, "Le hero a ", prop_iPvPoint.ToString(), "pv");
            if (IsDead)
            {
                IsDead = true;
                UserInterface.displayInfo(Program.DebugMode, "le hero est mort");
            }
        }

        /*        public void FindWeapon(Weapon myWeapon)
                {
                    m_Weapon += myWeapon;
                }*/
    }
}
