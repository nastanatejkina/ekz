using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace экз
{
    internal class db
    {   
        internal List<recept> recepts { get; private set; }
        public void Initialize()
        {
            recepts = new List<recept>
            {
                new recept(new nazvanie("вермишелевый"), 2, specii.соль, new ovoshi("картошка, вермишель")),
                new recept(new nazvanie ("борщ"), 3, specii.соль_и_перец, new ovoshi("картошка, свекла, капуста")),
                new recept(new nazvanie("гороховый"), 1.5, specii.перец, new ovoshi("горох, картошка"))
            };

        }
    }
}
