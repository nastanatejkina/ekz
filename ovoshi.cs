using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace экз
{
    internal class ovoshi
    {
        private string _name;

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public ovoshi (string name)
        {
            _name = name;
        }
    }
}
