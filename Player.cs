using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Practice
{
    internal class Player
    {

        string _name;

        public Player(string name)
        {
            _name = name;
        }

        public string Name { get => _name; set => _name = value; }
        
        public void SayTheMessage(string message)
        {
            Console.WriteLine($"{_name} says {message}");
        }
    }
}
