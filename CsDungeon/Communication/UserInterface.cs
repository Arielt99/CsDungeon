using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDungeon
{
    class UserInterface
    {
        static public void displayInfo(bool debug, params string[] infos)
        {
            if((Program.DebugMode && debug) || !debug)
            {
                foreach (var item in infos)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
        }
        public UserInterface()
        {

        }

        public void givePlayerFeedBack(Heros currentHero, String text, MESSAGE_TYPE messageType)
        {
            Console.WriteLine(text);
            displayInfo(Program.DebugMode, text, messageType.ToString());
        }
        public String getPlayerInput( Heros currentHero, String text)
        {
            displayInfo(Program.DebugMode, text);

            String getText = Console.ReadLine();

            return getText;
        }
        public void CurrentHero_HerosDeath(object sender, DeathEventArgs e)
        {
            displayInfo(Program.DebugMode, "le hero devrait s'entrainer plus", e.DeathCause, e.MessageImportantType.ToString());
        }
    }
}
