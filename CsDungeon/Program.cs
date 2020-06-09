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

        public const int ENNEMI_HEALTH_POINT = 100000;//point de vie des ennemis
        public const int PLAYER_BASE_HEALTH_POINT = 1; //point de vie de base du joueur
        public static UserInterface ui = new UserInterface();
        static public void linkToInterface(CommunicatingClass communicatingClass)
        {
            communicatingClass.getPlayerAction = ui.getPlayerInput;
            communicatingClass.informePlayer = ui.givePlayerFeedBack;
        }

        #endregion

        static void Main(string[] args)

        {
            UserInterface.displayInfo(Program.DebugMode, "Bienvenu dans D&D !");
            Console.WriteLine("Entrez le nom de votre hero");
            string HeroName = "test";
            //string HeroName = Console.ReadLine();
            Heros currentHero = new Heros(HeroName);
            Dungeon newDungeon = new Dungeon();
            currentHero.HerosDeath += ui.CurrentHero_HerosDeath;
            currentHero.RemoveLifePoint(new Weapon(WEAPON_TYPE.SWORD) { WeaponDamage = 500 });
            newDungeon.EnterDungeon(currentHero);
            UserInterface.displayInfo(Program.DebugMode, "Merci d'avoir joue");
            Console.Read();
        }
    }
}
