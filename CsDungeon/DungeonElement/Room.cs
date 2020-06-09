using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CsDungeon
{
    class Room
    {
        Monster m_Monster;
        Chest m_Chest;
        int m_iRoomId;

        public Room(int p_iRoomId, Random rand ,Dungeon p_Dungeon)
        {
            Dungeon m_curentDungeon = p_Dungeon;

            m_iRoomId = p_iRoomId;

            m_Chest = new Chest();

            int random = rand.Next(1, 4);

            switch (random)
            {
                case 1:
                    this.m_Monster = new Barbarian();
                    break;
                case 2:
                    this.m_Monster = new Wizard();
                    break;
                case 3:
                    this.m_Monster = new Thief();
                    break;
                default:
                    break;
            }
        }
        protected Room(Monster p_Monster)
        {
            m_Monster = p_Monster;
        }

        internal void Enter(Heros p_CurrentHero)
        {
            while (!p_CurrentHero.IsDead && !m_Monster.IsDead)
            {
                if (!m_Monster.IsDead)
                {
                    m_Monster.Attack(p_CurrentHero);
                }
                if (!p_CurrentHero.IsDead)
                {
                    p_CurrentHero.Attack(m_Monster);
                }
            }
            if(!p_CurrentHero.IsDead && m_Monster.GetMonsterType() != MONSTER_TYPE.DRAGON)
                {
                UserInterface.displayInfo(Program.DebugMode, "vous trouvez un coffre qui contient :");
                m_Chest.ItemsEnum();

                while (m_Chest.ChoosedItems.Count < 5)
                {
                    UserInterface.displayInfo(Program.DebugMode, "choisissez un item dans la liste ci dessus en donnant son numero");
                    m_Chest.TakeItem(Convert.ToInt32(Console.ReadLine()));
                }
            }
        }
    }
}
