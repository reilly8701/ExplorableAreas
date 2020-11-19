using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Console;

namespace AdventurerGame
{
    class World
    {
        public static List<Location> Locations = new List<Location>();

        Item Potion = new Item("potion", "Heals you.");
        Item ManaPotion = new Item("manapotion", "Gives magic points");
        Item StaminaPotion = new Item("staminapotion", "Replenishs stamina");

        Location Loc1 = new Location("village");
        Location Loc2 = new Location("forest");
        Location Loc3 = new Location("city");

        Character Char1 = new Character("old man peter");
        Character Char2 = new Character("Player");
        public World()
        {
            Setup();
            Rpg();
        }


        public void Setup ()
        {
            

            Locations.Add(Loc1);
            Locations.Add(Loc2);
            Locations.Add(Loc3);

      

        }

        public void Forest()
        {
            WriteLine(Char1.name + " :You come upon a troll and tells you it dangerous to go alone and gives you stuff");
           // Char2.Inventory.add(Potion.Name);
        }

        public void City()
        {
            WriteLine();
        }

        public void Rpg()
        {
            WriteLine("The Player enters a small Tavern in the " + Loc1.name + ". Its pretty busy, but you can make out a distint old man sitting in the back of the tavern.");
            WriteLine("The old man introdues himself as " + Char1.name + "." );
            WriteLine(Char1.name + ": what is your name traveler?" );
            Char2.name = ReadLine();
            //WriteLine(Char1.name + " : Where would you like to go " + Char2.name + " the " + Loc2.name + " or " + Loc3.name );
            Travel();
            
           
        }

        public void Travel()
        {
            int i = 1;
            foreach (Location l in Locations)
            {
                Console.WriteLine($"{i}: {l.name}");
                i++;
            }


            ReadKey();
            int input = Convert.ToInt32(ReadLine());

            input--;

            Console.WriteLine($"You have arrived at {Locations[input].name}");

            Travel();
        }

    }
}
