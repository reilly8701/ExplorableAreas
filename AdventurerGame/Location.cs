using System;
using System.Collections.Generic;
using System.Text;

namespace AdventurerGame
{
   public class Location
    {
        public string name;
        public static List<Item> Worldshelf = new List<Item>();
        public Location(string N)
        {
            name = N;

        }
    }
}
