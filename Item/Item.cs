using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRPG
{
    class Item
    {
        public string Name { get; }

        //public string ItemName { get; set; }
        //public Item()
        //{
        //    this.ItemName = "";
        //}

        public Item(string name)
        {
            this.Name = name;
        }
    }
}
