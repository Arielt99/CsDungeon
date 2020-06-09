using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDungeon
{
    class Chest
    {
        public List<Item> ContainedItems { get; } = new List<Item>(Enum.GetValues(typeof(ITEM_TYPE)).Length);
        public List<Item> ChoosedItems { get; } = new List<Item>();
        public Chest()
        {
            foreach (ITEM_TYPE itemToAdd in Enum.GetValues(typeof(ITEM_TYPE)))
            {
                ContainedItems.Add(new Item(itemToAdd));
            }
        }

        internal void ItemsEnum()
        {
            for (int i = 0; i < ContainedItems.Count; i++)
            {
                UserInterface.displayInfo(Program.DebugMode,i+" - "+ ContainedItems[i].prop_iItem_value.ToString()+" "+ ContainedItems[i].prop_item_type.ToString());
            }
        }

        public Item TakeItem(int userEntry)
        {
            Item choosedItem = ContainedItems[userEntry];
            while (ChoosedItems.Contains(choosedItem))
            {
                UserInterface.displayInfo(Program.DebugMode, "Vous avez déjà choisi cet item");
                userEntry = Convert.ToInt32(Console.ReadLine());
                choosedItem = ContainedItems[userEntry];
            }
            ChoosedItems.Add(choosedItem);
            UserInterface.displayInfo(Program.DebugMode, "Liste actuelle des items choisis");
            for (int j = 0; j < ChoosedItems.Count; j++)
            {
                UserInterface.displayInfo(Program.DebugMode, j + " - " + ChoosedItems[j].prop_iItem_value.ToString() + " " + ChoosedItems[j].prop_item_type.ToString());

            }
            UserInterface.displayInfo(Program.DebugMode, "Voici le contenu restant du coffre, il vous reste " + (5 - ChoosedItems.Count) + " choix");
            ItemsEnum();
            return ContainedItems[userEntry];

        }
    }
}
