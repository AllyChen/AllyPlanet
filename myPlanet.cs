using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllyPlanet
{
    public class myPlanet :myObject
    {
        private float _radius; // the radius of planet
        private bool radiusCheck() { return _radius > 0.0f; } // check the radius
        private Coordinate _position; // the position of planet
        private List<myObject> _object_ptrs = new List<myObject>(); // the list of objects which are created 
                    
        // get the information of planet
        public myPlanet(string name, Coordinate position, float radius):base(name)
        {
            _position = position;
            _radius = radius;
            if (!radiusCheck())
                Console.WriteLine("Radius should be greater than 0.0f.");
        }
        // set the position of planet
        public void setPosition(Coordinate position)
        {
            _position = position;
        }
        // set the radius of planet
        public void setRadius(float radius)
        {
            _radius = radius;
        }

        // add the object on the planet
        public void addObject(myObject ptr)
        {
                _object_ptrs.Add(ptr); // push back to the link
        }

        // remove the object
        public void removeObject(uint id)
        {
            foreach (myObject p in _object_ptrs)
            {
                if (id == p.getID())
                {
                    _object_ptrs.Remove(p);
                    return;
                }
            }
        }

        // show the information of the planet
        public override void update()
        {
            if(_object_ptrs.Count == 0)
            {
                Console.WriteLine("There is no object on the planet !!!");
            }
            else
            {
                foreach (CreatureType p in _object_ptrs)
                {
                    Console.WriteLine(p.getID() + " " + p.getName());
                    p.move();
                    p.absorb();
                    p.deadOrAlive();
                    p.alive();
                    p.birth();
                    Console.WriteLine("");
                }
            }          
        }
    }
}
