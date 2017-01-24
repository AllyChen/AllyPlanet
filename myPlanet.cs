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
        private LinkedList<myObject> _object_ptrs;

        public myPlanet(myPlanet src) :base(src.getName())
        {
            _object_ptrs = src._object_ptrs;
        }
              
        public myPlanet(string name, float radius) :base(name)
        {
            _position = new Coordinate();
            _radius = radius;
            if (!radiusCheck())
                Console.WriteLine("Radius should be greater than 0.0f.");
        }

        public myPlanet(string name, Coordinate position, float radius):base(name)
        {
            _position = position;
            _radius = radius;
            if (!radiusCheck())
                Console.WriteLine("Radius should be greater than 0.0f.");
        }

        public void setPosition(Coordinate position)
        {
            _position = position;
        }
        
        public void setRadius(float radius)
        {
            _radius = radius;
        }

        public void addObject(myObject ptr)
        {
            _object_ptrs.AddLast(ptr); // push back to the link
        }

        public void removeObject(uint id)
        {
            foreach (myObject p in _object_ptrs)
            {
                if(id == p.getID())
                {
                    _object_ptrs.Remove(p);
                    return;
                }
            }
        }

        public virtual void update()
        {
            foreach (myObject p in _object_ptrs)
            {
                Console.WriteLine(p.getID() + " " + p.getName());
                p.update();
                Console.WriteLine("");
            }
        }
    }
}
