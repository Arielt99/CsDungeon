using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDungeon
{
    class Program
    {
        #region Variable de jeu
        public const bool DebugMode = true;//mode debug

        public const int ROOM_COUNT = 2; //nombre de pièces
        public const int STARTING_WEAPON_COUNT = 10; //nombre d'arme au début

        public const int ENNEMI_HEALTH_POINT = 1;//point de vie des ennemis

        public const int PLAYER_BASE_HEALTH_POINT = 1000; //point de vie de base du joueur
        #endregion

        static void Main(string[] args)

        {
            UserInterface.displayInfo(Program.DebugMode, "Bienvenu dans D&D !");
            Console.WriteLine("Entrez le nom de votre hero");
            string HeroName = "test";
            //string HeroName = Console.ReadLine();
            Heros currentHero = new Heros(HeroName);
            Dungeon newDungeon = new Dungeon();

            newDungeon.EnterDungeon(currentHero);
            UserInterface.displayInfo(Program.DebugMode, "Merci d'avoir joue");
            Console.Read();
        }
    }
}
