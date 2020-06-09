using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDungeon
{
    class Dungeon
    {
        private Room[] m_ArrayRoom = new Room[Program.ROOM_COUNT];

        DragonsLair m_DragonsLair;

        public Dungeon()
        {
            Random rand = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < m_ArrayRoom.Length; i++)
            {
                m_ArrayRoom[i] = new Room(i, rand, this); 
            }
            m_DragonsLair = new DragonsLair();
        }

        internal void EnterDungeon(Heros currentHero)
        {
            UserInterface.displayInfo(Program.DebugMode, "Il entre dans le dongeon");

            for (int i = 0; i < m_ArrayRoom.Length; i++){
                if (!currentHero.IsDead)
                {
                    UserInterface.displayInfo(Program.DebugMode, "Il entre dans la salle n°", (i+1).ToString());
                    m_ArrayRoom[i].Enter(currentHero);
                }
                else
                {
                    break;
                }

            };
            if (!currentHero.IsDead)
            {
                UserInterface.displayInfo(Program.DebugMode, "Maisonette du dragon");
                m_DragonsLair.Enter(currentHero);
            }
            else
            {
                UserInterface.displayInfo(Program.DebugMode, "Rééssayez une prochaine fois");
            }
        }


    }
}
