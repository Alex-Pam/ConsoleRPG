using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRPG
{
    class Player
    {
        public string PlayerName { get; set; }
        public int  PlayerLevel { get; set; }
        public int PlayerHealth { get; set; }
        public int PlayerDamage { get; set; }
        public int PlayerArmor { get; set; }
        public List<object> inventory = new List<object>();
        public Player(string name)
        {
            PlayerName = name;
            PlayerLevel = 0;
            PlayerHealth = 100;
            PlayerDamage = 1;
            PlayerArmor = 0;
        }
        public void GetInfo()
        {
            Console.WriteLine(PlayerName);
            Console.WriteLine($"Player Level: {PlayerLevel}");
            Console.WriteLine($"Health: {PlayerHealth}/100");
            Console.WriteLine($"Armor: {PlayerArmor}");
            Console.WriteLine($"Damage done: {PlayerDamage}");
        }
        public void GetInentory()
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("Inventory is empty");
            }
            else
            {
               for(int i = 0; i < inventory.Count; i++)
                {
                    Console.WriteLine($"{i+1}: {inventory[i]}");
                }
            }

        }
    }
}
