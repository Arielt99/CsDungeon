using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDungeon
{
    abstract class Character
    {
        private int m_iPvPoint;
        public int prop_iPvPoint 
        {
            get { return m_iPvPoint; }
            set { 
                m_iPvPoint = value; 
                if (value <= 0)
                {
                    m_iPvPoint = 0;
                    IsDead = true;
                }
            } 
        }

        public Arsenal HeroArsenal { get; set; }

        public bool IsDead{ get; set; }

        protected Weapon m_Weapon;

        public Character(int p_iPvPoint)
        {
            prop_iPvPoint = p_iPvPoint;
        }

        public abstract void Attack(Character character);
        public abstract void RemoveLifePoint(Weapon weapon);
    }
}