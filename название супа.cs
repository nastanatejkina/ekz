using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace экз
{
    internal class nazvanie
    {
        private string _name;

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public nazvanie (string name)
        {
            _name = name;
        }
    }
}
