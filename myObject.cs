using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllyPlanet
{
    public class myObject
    {
        private uint s_next_id = 0; // initial the ID of object
        private uint _ID;
        private string _name;

        public myObject() { }
        public uint getID() { return _ID; }
        public string getName() { return _name; }
        public virtual void update() { }

        public myObject(string name)
        {
            this._ID = s_next_id++;
            this._name = name;
        }

        public myObject(myObject src)
        {
            this._name = src._name;
            this._ID = s_next_id++;
        }
        
    }
}
