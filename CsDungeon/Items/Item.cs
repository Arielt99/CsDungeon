using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDungeon
{
        enum ITEM_TYPE
        {
            DAGGER_SET,
            WATER_FLASK_SET,
            ICE_ARROW_SET,

            SHIELD_RESTORE,
            MAGICAL_RESTORE,
            PENDENT_RESTORE,

            HEALTH_POTION,

            ICE_ARROW_DAMAGE,
            FLASK_DAMAGE,
            DAGGER_DAMAGE,
            SWORD_DAMAGE
        }
        enum ITEM_CLASS
        {
            POTION,
            DAMAGE,
            RESTORE,
            SET
        }
    class Item
    {

        public ITEM_TYPE prop_item_type { get; set; }

        public ITEM_CLASS prop_item_class { get; set; }

        public int prop_iItem_value { get; set; }

        public string prop_item_message { get; set; }


        public Item()
        {

        }
        public Item(ITEM_TYPE type)
        {
            Random random = new Random();
            string m_sModifiateElement;
            prop_item_type = type;
            if (prop_item_type.ToString().Contains(ITEM_CLASS.POTION.ToString()))
            {
                prop_item_class = ITEM_CLASS.POTION;
                prop_iItem_value = random.Next(10, 30);
                m_sModifiateElement = prop_item_type.ToString().Replace(prop_item_class.ToString(),"");
                prop_item_message = "Vous avez ajouté "+prop_iItem_value+" a "+m_sModifiateElement;
            }
            else if (prop_item_type.ToString().Contains(ITEM_CLASS.DAMAGE.ToString()))
            {
                prop_item_class = ITEM_CLASS.DAMAGE;
                prop_iItem_value = random.Next(2, 10);
                m_sModifiateElement = prop_item_type.ToString().Replace(prop_item_class.ToString(), "");
                prop_item_message = "Vous avez ameliore votre  " + m_sModifiateElement + " de " + prop_iItem_value ;
            }
            else if (prop_item_type.ToString().Contains(ITEM_CLASS.RESTORE.ToString()))
            {
                prop_item_class = ITEM_CLASS.RESTORE;
                prop_iItem_value = random.Next(10, 20);
                m_sModifiateElement = prop_item_type.ToString().Replace(prop_item_class.ToString(), "");
                prop_item_message = "Vous avez restore votre  " + m_sModifiateElement + " de " + prop_iItem_value;
            }
            else if (prop_item_type.ToString().Contains(ITEM_CLASS.SET.ToString()))
            {
                prop_item_class = ITEM_CLASS.SET;
                prop_iItem_value = random.Next(4, 8);
                m_sModifiateElement = prop_item_type.ToString().Replace(prop_item_class.ToString(), "");
                prop_item_message = "Vous avez ajouté "+ prop_iItem_value +" "+ m_sModifiateElement + " a votre inventaire ";
            }

        }

    }
}
