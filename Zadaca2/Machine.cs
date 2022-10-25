using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public class Machine
    {
        private String _name;
        public string name { get { return _name; } }
        private int _type;
        public int type { get { return _type; } }
        private string _description;
        public string description { get { return _description; } }
        public Machine(string Name, int Type, string Decsription)
        {
            _name = Name;
            _type = Type;
            _description = Decsription;
        }
    }
}
