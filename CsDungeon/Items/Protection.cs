using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDungeon
{
    public enum PROTECTION_TYPE
    {
        PENDANT,
        MAGIC_HOOD,
        SHIELD
    }
    public class Protection
    {
        public PROTECTION_TYPE ProtectionTypeProp { get; set; }
        public int AbsorbingDamage { get; set; }


        public Protection(PROTECTION_TYPE p_PT)
        {
            ProtectionTypeProp = p_PT;
            Random random = new Random();
            switch (ProtectionTypeProp)
            {
                case PROTECTION_TYPE.PENDANT:
                    AbsorbingDamage = random.Next(40, 60);
                    break;
                case PROTECTION_TYPE.MAGIC_HOOD:
                    AbsorbingDamage = random.Next(60, 80);
                    break;
                case PROTECTION_TYPE.SHIELD:
                    AbsorbingDamage = random.Next(20, 40);
                    break;
                default:
                    break;
            }
        }

        static public string GetProtectionChoice()
        {
            string protection = "Choose your Protection : ";
            //we parse each of the protection type enum and display them to the player to let
            //him choose its protection
            foreach (var item in Enum.GetValues(typeof(PROTECTION_TYPE)) as int[])
            {
                var text = Enum.GetName(typeof(PROTECTION_TYPE), item).ToLowerInvariant();
                var letter = text[0].ToString().ToUpper();
                text = text.Replace(text[0], letter[0]);
                var underscore = text.IndexOf('_');
                //Check the underscore is within range of text array
                letter = text[underscore + 1].ToString().ToUpper();
                text = text.Replace(text[underscore + 1], letter[0]);
                protection += $"the {text}({item + 1}) , ";
            }
            return protection.Remove(protection.Length - 2);
        }
    }
}
