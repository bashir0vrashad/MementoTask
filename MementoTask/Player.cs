using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoTask
{
    internal class Player
    {
        public string Name { get; }
        public int Health { get; set; }
        public int Level { get; set; }

        public Player(string name, int health, int level)
        {
            Name = name;
            Health = health;
            Level = level;
        }

      
        public PlayerMemento CreateMemento()
        {          
            return new PlayerMemento(Name, Health, Level);
        }

        
        public void RestoreMemento(PlayerMemento memento)
        {
            Health = memento.Health;
            Level = memento.Level;
            Console.WriteLine($"Evvelki Netice: AD - {Name} , CAN {Health} , SEVIYYE - {Level}");
        }
    }
}
