using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace экз
{
           public enum specii
        {
            соль, 
            перец,
            соль_и_перец
        }

        internal class recept
        {
            private double voda;
            private specii specii = specii.соль;
            private ovoshi ovoshi;
            private nazvanie nazvanie;

             public double _voda 
            {
                get => voda;
            }

            public specii _specii
            {
                get => specii;
            }

            private ovoshi _ovoshi
            {
                get => ovoshi;
            }
               public nazvanie _nazvanie
              {
                   get => nazvanie;
              }


        public string овощи
            {
                get { return ovoshi != null ? ovoshi.Name : "Не назначено"; }
            }
        public string название
        {
            get { return nazvanie != null ? nazvanie.Name : "Не назначено"; }
        }

        public recept (nazvanie _nazvanie, double _voda, specii _specii, ovoshi _ovoshi)
        { 
            nazvanie = _nazvanie;
            voda = _voda;
            specii = _specii;
            ovoshi = _ovoshi;
           
        }

        
    }
}
