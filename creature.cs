using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllyPlanet
{
   
    // is a model that about detail of Object's information 
    public class CreatureType:myObject
    {
        public CreatureType(string name) : base(name) { }

        public virtual void move() { }
        public virtual void absorb() { }
        public virtual int deadOrAlive() { return 0; }
        public virtual bool alive() { return false; }
        public virtual int birth() { return 0; }
    }

    // detail of Lion's information 
    public class Lion : CreatureType
    {
        public Lion(string name) : base(name) { }
        public override void move() { Console.WriteLine("Run Run Run"); }
        public override void absorb() { Console.WriteLine("Eat Eat Eat"); }
        public override int deadOrAlive() { Console.WriteLine("Alive"); return 0; }
        public override bool alive() { return true; }
        public override int birth() { return 0; }
    }

    // detail of Plant's information 
    public class Plant : CreatureType
    {
        public Plant(string name) : base(name) { }
        public override void move() { Console.WriteLine("Plant cannot move :("); }
        public override void absorb() { Console.WriteLine("Growth"); }
        public override int deadOrAlive() { Console.WriteLine("Alive"); return 0; }
        public override bool alive() { return true; }
        public override int birth() { Console.WriteLine("Spread seeds"); return 0; }
    }

}
