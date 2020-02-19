using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleInterface
{
    class Pokemon :IDisplayable, ICloneable
    {
        private string _name;
        private int _hp;
        private string _type;

        public Pokemon() { }

        public Pokemon(string name, int hp, string type)
        {
            this._name = name;
            this._hp = hp;
            this._type = type;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int HP
        {
            get
            {
                return _hp;
            }
            set
            {
                _hp = value;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public string GetDisplayText() =>
            "\nName: " + this.Name +" \nHP: " + this.HP.ToString() + " \nType: " + this.Type;

        public object Clone()
        {
            Pokemon p = new Pokemon();
            p._name = this.Name;
            p._hp = this.HP;
            p._type=this.Type;
            return p;
        }
    }
}
