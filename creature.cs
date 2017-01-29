using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllyPlanet
{
   
    // is a model that about detail of Object's information 
    public class CreatureType
    {
        public virtual void move() { }
        public virtual void absorb() { }
        public virtual int deadOrAlive() { return 0; }
        public virtual bool alive() { return false; }
        public virtual int birth() { return 0; }
    }

    public class creature<T>: myObject
    {
        private int _amount = 0;
        private T _p_implement;

        public creature(creature<T> src) : base(src.getName())
        {
            _amount = src._amount;
            _p_implement = src._p_implement;
        }

        public creature(string name) : base(name)
        {
            Console.WriteLine("my name is : " + name);
        }

        public override void update()
        {
            //string typeAlly =  _p_implement.ToString();
            //Console.WriteLine("typeAlly" + typeAlly);
        }
    }
}
