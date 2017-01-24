using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllyPlanet
{
    public class CreatureType
    {
        public virtual void move() { }
        public virtual void absorb() { }
        public virtual int deadOrAlive() { return 0; }
        public virtual bool alive() { return false; }
        public virtual int birth() { return 0; }
    }

    //public class creature : myObject
    //{
    //    private int _amount = 0;
    //    private object _p_implement = null;

    //    public creature(creature src) : base(src.getName())
    //    {
    //        _amount = src._amount;
    //        _p_implement = src._p_implement;
    //    }

    //    public creature(string name) : base(name)
    //    {
    //        _p_implement = new object();
    //    }

    //    public virtual void update()
    //    {
    //        _p_implement 
    //    }
    //}
}
