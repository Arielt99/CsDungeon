using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDungeon
{
    enum MESSAGE_TYPE
    {
        INFO,
        WARNINGS,
        HIT_RECEIVED,
        HIT_DEALT,
        DEAD,
        HIT_BLOCKED,
        QUERY,
        COMBAT_INFO,
        WINNING_FIGHT,
        ERROR
    }
    class CommunicatingClass
    {
        public CommunicatingClass()
        {
            Program.linkToInterface(this);
        }
        public delegate String getPlayerActionDelegate(Heros CurrentHero, String Message);
        public delegate void informePlayerDelegate(Heros CurrentHero, String Message, MESSAGE_TYPE messageType);

        public getPlayerActionDelegate getPlayerAction;
        public informePlayerDelegate informePlayer;
    
    }


}
