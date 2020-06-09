using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDungeon
{
    public enum WEAPON_TYPE
    {
        BOW,
        WATER_FLASK,
        SWORD,
        DAGGER,
        ICE_ARROW,
        LIGHTNING,
        SPIKE,
        CLAWS,
        FLAME
    }

    public class Weapon
    {
        public WEAPON_TYPE WeaponTypeProp { get; set; }
        public PROTECTION_TYPE EffectiveProtectionProp { get; set; }
        public int WeaponDamage { get; set; }

        public Weapon(WEAPON_TYPE p_WT)
        {
            WeaponTypeProp = p_WT;
            Random random = new Random();
            switch (WeaponTypeProp)
            {
                case WEAPON_TYPE.LIGHTNING:
                    WeaponDamage = random.Next(30, 40);
                    EffectiveProtectionProp = PROTECTION_TYPE.PENDANT;
                    break;
                case WEAPON_TYPE.WATER_FLASK:
                    WeaponDamage = random.Next(10, 20);
                    break;
                case WEAPON_TYPE.BOW:
                    WeaponDamage = random.Next(20, 30);
                    EffectiveProtectionProp = PROTECTION_TYPE.MAGIC_HOOD;
                    break;
                case WEAPON_TYPE.DAGGER:
                    WeaponDamage = random.Next(10, 20);
                    break;
                case WEAPON_TYPE.SWORD:
                    WeaponDamage = random.Next(10, 20);
                    EffectiveProtectionProp = PROTECTION_TYPE.SHIELD;
                    break;
                case WEAPON_TYPE.FLAME:
                    WeaponDamage = random.Next(30, 40);
                    EffectiveProtectionProp = PROTECTION_TYPE.PENDANT;
                    break;
                case WEAPON_TYPE.CLAWS:
                    WeaponDamage = random.Next(30, 40);
                    EffectiveProtectionProp = PROTECTION_TYPE.SHIELD;
                    break;
                case WEAPON_TYPE.SPIKE:
                    WeaponDamage = random.Next(30, 40);
                    EffectiveProtectionProp = PROTECTION_TYPE.MAGIC_HOOD;
                    break;
                case WEAPON_TYPE.ICE_ARROW:
                    WeaponDamage = random.Next(10, 20);
                    break;
                default:
                    break;
            }
        }
    }
}
