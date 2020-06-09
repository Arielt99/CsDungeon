using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDungeon
{
    public class Arsenal : IEnumerable
    {
        static Weapon sword = new Weapon( WEAPON_TYPE.SWORD);
        static Weapon water = new Weapon(WEAPON_TYPE.WATER_FLASK);
        static Weapon dagger = new Weapon(WEAPON_TYPE.DAGGER);
        static Weapon ice_arrow = new Weapon(WEAPON_TYPE.ICE_ARROW);


        CurrentWeapon mySelectedWeapon;

        public Arsenal()
        {
            mySelectedWeapon = new CurrentWeapon();
        }
        public Weapon WeaponUsed
        {
            get; set;
        }

        public IEnumerator GetEnumerator()
        {
            bool hasElement = true;
            while (true)
            {
                if (!hasElement)
                {
                    mySelectedWeapon.Reset();
                    yield break;
                }
                yield return mySelectedWeapon;
                hasElement = mySelectedWeapon.MoveNext();
            }
        }

        public static Weapon get(WEAPON_TYPE wt)
        {
            switch (wt)
            {
/*                case WEAPON_STYLE.BOW:
                    break;*/
                case WEAPON_TYPE.WATER_FLASK:
                    return water;
                case WEAPON_TYPE.SWORD:
                    return sword;
                case WEAPON_TYPE.DAGGER:
                    return dagger;
                case WEAPON_TYPE.ICE_ARROW:
                    return ice_arrow;
/*                case WEAPON_STYLE.LIGHTNING:
                    break;
                case WEAPON_STYLE.SPIKE:
                    break;
                case WEAPON_STYLE.CLAWS:
                    break;
                case WEAPON_STYLE.FLAME:
                    break;*/
            }
            return null;
        }
        

        class CurrentWeapon : IEnumerator
        {
            public WEAPON_TYPE curWT { get; set; } = 0;
            public object Current {get {return Arsenal.get(curWT);} }

            public bool MoveNext()
            {
                curWT++;
                if((int)curWT > Enum.GetValues(typeof(WEAPON_TYPE)).Length)
                {
                    return false;
                }
                return true;
            }

            public void Reset()
            {
                curWT = 0;
            }

            public override string ToString() {
            
                if(Current == null)
                {
                    return "";
                }
                //return Current.ToString();
                return (((Weapon)Current).WeaponTypeProp.ToString());
            }
        }
    }
}
