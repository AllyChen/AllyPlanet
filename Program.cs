using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllyPlanet
{

    // detail of Lion's information 
    public class Lion : CreatureType
    {
        public void move() { Console.WriteLine("Run Run Run"); }
        public void absorb() { Console.WriteLine("Eat Eat Eat"); }
        public int deadOrAlive() { Console.WriteLine("Alive"); return 0; }
        public bool alive() { return true; }
        public int birth() { return 0; }
    }

    // detail of Plant's information 
    public class Plant : CreatureType
    {
        public void move() { Console.WriteLine("Plant cannot move :("); }
        public void absorb() { Console.WriteLine("Growth"); }
        public int deadOrAlive() { Console.WriteLine("Alive"); return 0; }
        public bool alive() { return true; }
        public int birth() { Console.WriteLine("Spread seeds"); return 0; }
    }

    class Program
    {
        static void Main()
        {
            string command;
            myPlanet p_planet = null;
            while((command = Console.ReadLine()) != null && command != "exit")
            {
                // create planet
                if (command == "cp")
                {
                    float r; // radius
                    Coordinate pos; // position of planet
                    string name; // planet's name

                    // read the imformation of planet
                    name = Console.ReadLine();
                    pos.x = float.Parse(Console.ReadLine());
                    pos.y = float.Parse(Console.ReadLine());
                    pos.z = float.Parse(Console.ReadLine());
                    r = float.Parse(Console.ReadLine());

                    try
                    {
                        // create planet
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
                // create object on the planet
                else if (command == "ac")
                {
                    string c_type; // type of object
                    string name; // object's name

                    // read the imformation of object
                    c_type = Console.ReadLine();
                    name = Console.ReadLine();

                    // the object that user create
                    myObject op;
                    
                    if (p_planet == null) // if there is no planet, it can't create object
                    {
                        Console.WriteLine("Please create planet first.");
                        continue;
                    }
                    else
                    {
                        if (c_type == "Lion") // create Lion
                        {
                            op = new creature<Lion>(name); // create Lion
                        }
                        else if (c_type == "Plant") // create Plant
                        {
                            op = new creature<Plant>(name); // create Plant
                        }
                        else
                        {
                            Console.WriteLine("You shall not pass!!");
                            continue;
                        }
                        p_planet.addObject(op); // add object
                        Console.WriteLine(op.getName()+" added!");
                    }

                }
                // remove object on the planet
                else if (command == "ro")
                {

                }
                // update
                else if (command == "up")
                {
                    if (p_planet == null) // there is no planet
                    {
                        Console.WriteLine("Please create planet first.");
                    }
                    else
                        p_planet.update(); // update
                }
            }
        }
    }
}
