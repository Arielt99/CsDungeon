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
        public override bool IsDead
        {
            get => base.IsDead;
            set
            {
                base.IsDead = value;
                if (value == true)
                {
                    HerosDeath?.Invoke(this, new DeathEventArgs()
                    {
                        DeathCause = "le hero s'est fait poutrer par un monstre",
                        MessageImportantType = MESSAGE_TYPE.DEAD
                    });
                }
            }
        }
        #endregion
        public event EventHandler<DeathEventArgs> HerosDeath;
        public Protection ChoosenProtectionProp { get; set; }
        #region Contructeur

        /// <summary>
        /// Heros constructor
        /// </summary>
        /// <param name="p_sName"> hero's name </param>
        public Heros(string p_sName) : base(Program.PLAYER_BASE_HEALTH_POINT)
        {
            m_sName = p_sName;

            informePlayer(this, "Naissance du hero : " + m_sName, MESSAGE_TYPE.INFO);
            informePlayer(this, "avec : " + prop_iPvPoint.ToString() + " pv", MESSAGE_TYPE.INFO);
            HeroArsenal = new Arsenal();
            informePlayer(this, "voici l'arsenal du hero :", MESSAGE_TYPE.INFO);
            foreach (var item in HeroArsenal)
            {
                informePlayer(this, item.ToString(), MESSAGE_TYPE.INFO);
            }
            HeroArsenal.WeaponUsed = Arsenal.get(WEAPON_TYPE.SWORD);

            informePlayer(this, "vous êtes arme de :" + HeroArsenal.WeaponUsed.WeaponTypeProp.ToString(), MESSAGE_TYPE.INFO);
            m_Weapon = HeroArsenal.WeaponUsed;

        }
        #endregion

        public override void Attack(Character character)
        {
            Monster m = (Monster)character;
            informePlayer(this, "Vous attaquez un " + m.GetMonsterType().ToString(), MESSAGE_TYPE.WINNING_FIGHT);
            m.RemoveLifePoint(m_Weapon);
        }

        public override void RemoveLifePoint(Weapon p_MonsterWeapon)
        {
            prop_iPvPoint -= p_MonsterWeapon.WeaponDamage;
            informePlayer(this, "Le hero a " + prop_iPvPoint.ToString() + "pv", MESSAGE_TYPE.HIT_RECEIVED);
            if (IsDead)
            {
                IsDead = true;
            }
        }


        /*        public void FindWeapon(Weapon myWeapon)
                {
                    m_Weapon += myWeapon;
                }*/
    }
}
