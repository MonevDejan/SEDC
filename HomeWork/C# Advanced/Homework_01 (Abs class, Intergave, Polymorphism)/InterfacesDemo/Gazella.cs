﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public class Gazella : IPray, IPredator
    {
        public string Name { get; set; }
        public int FleeSpeed { get; set; }
        public int AttackSpeed { get; set; }

        public void Flee()
        {
            Console.WriteLine($"{this.Name } flees away...");
        }

        public void Attack(IPray pray)
        {
            if (this.AttackSpeed > pray.FleeSpeed)
            {
                Console.WriteLine($"{this.Name } catches {pray.Name}");
            }
            else
            {
                pray.Flee();
            }
        }
    }
}
