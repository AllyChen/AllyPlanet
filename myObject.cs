using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllyPlanet
{
    public class myObject
    {
        protected static uint s_next_id; // initial the ID of object
        private uint _ID;
        protected string _name;

        public myObject() { }
        public uint getID() { return _ID; }
        public string getName() { return _name; }
        public virtual void update() { }

        public myObject(string name)
        {
            _ID = s_next_id++;
            _name = name;
        }

        public myObject(myObject src)
        {
            _name = src._name;
            _ID = s_next_id++;
        }
        
    }
}
