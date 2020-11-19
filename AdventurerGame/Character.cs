using System;
using System.Collections.Generic;
using System.Text;

namespace AdventurerGame
{
   public class Character
    {
        public string name;
        public static List<Item> Backpack = new List<Item>();
        public Character(string N)
        {
            name = N;
            
        }
        public void Inventory()
        {
           // Backpack 
        }
    }
}
