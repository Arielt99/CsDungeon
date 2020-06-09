using System;
using System.Collections.Generic;
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
    }
}
