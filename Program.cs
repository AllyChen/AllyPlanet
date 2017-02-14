using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllyPlanet
{
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
                        Console.WriteLine(" ");
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
                        if (c_type == "Lion")
                        {
                            op = new Lion(name); // create Lion
                            Console.WriteLine("my name is : " + name);
                        }
                        else if (c_type == "Plant")
                        {
                            op = new Plant(name); // create Plant
                            Console.WriteLine("my name is : " + name);
                        }
                        else
                        {
                            Console.WriteLine("You shall not pass!!");
                            continue;
                        }
                        p_planet.addObject(op); // add object
                        Console.WriteLine(op.getName()+" added!");
                        Console.WriteLine(" ");
                    }

                }
                // remove object on the planet
                else if (command == "ro")
                {
                    uint id;
                    // read the imformation of object
                    id = uint.Parse(Console.ReadLine());
                    if (p_planet == null) // if there is no planet, it can't create object
                    {
                        Console.WriteLine("Please create planet first.");
                        continue;
                    }
                    else
                    {
                        p_planet.removeObject(id); // remove object
                        Console.WriteLine(id + " removed!");
                        Console.WriteLine(" ");
                    }
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
