using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllyPlanet
{
    public class Lion : CreatureType
    {
        public virtual void move() { Console.WriteLine("Run Run Run"); }
        public virtual void absorb() { Console.WriteLine("Eat Eat Eat"); }
        public virtual int deadOrAlive() { Console.WriteLine("Alive"); return 0; }
        public virtual bool alive() { return true; }
        public virtual int birth() { return 0; }
    }

    public class Plant : CreatureType
    {
        public virtual void move() { Console.WriteLine("Plant cannot move :("); }
        public virtual void absorb() { Console.WriteLine("Growth"); }
        public virtual int deadOrAlive() { Console.WriteLine("Alive"); return 0; }
        public virtual bool alive() { return true; }
        public virtual int birth() { Console.WriteLine("Spread seeds"); return 0; }
    }

    class Program
    {
        static void Main()
        {
            string command;
            myPlanet p_planet = null;
            while((command = Console.ReadLine()) != null && command != "exit")
            {
                if (command == "cp")
                {
                    float r;
                    Coordinate pos;
                    string name;
                    name = Console.ReadLine();
                    pos.x = float.Parse(Console.ReadLine());
                    pos.y = float.Parse(Console.ReadLine());
                    pos.z = float.Parse(Console.ReadLine());
                    r = float.Parse(Console.ReadLine());

                    try
                    {
                        p_planet = new myPlanet(name, pos, r);
                        Console.WriteLine(p_planet.getName() + " created!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("you shall not pass!!");
                        if (p_planet != null)
                            p_planet = null;
                    }

                }
                else if (command == "ac")
                {
                    string c_type;
                    string name;
                    c_type = Console.ReadLine();
                    name = Console.ReadLine();
                    myObject op;

                    //if (c_type == "Lion")
                    //{
                    //    op = new Lion(name);
                    //}
                    //else if()
                    //{

                    //}
                }
                else if (command == "ro")
                {

                }
                else if (command == "up")
                {

                }
            }
        }
    }
}
