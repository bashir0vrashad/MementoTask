using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoTask
{
    internal class PlayerMemento
    {
        public string Name { get; }
        public int Health { get; }
        public int Level { get; }

        public PlayerMemento(string name, int health, int level)
        {
            Name = name;
            Health = health;
            Level = level;
        }
    }
}
