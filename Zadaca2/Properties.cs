using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public class Property
    {
        private int _id;
        private string _name;
        private int _prop_value;
        public Property(int id, string name,int value)
        {
            _id = id;
            _name = name;
            _prop_value = value;
        }
        public string Name { get { return _name; } }
        public int Value { get { return _prop_value; } set { _prop_value = value; } }

        public int ID { get { return _id; } }
       
    }
}
