using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1
{
    class NaWynos : Zamowienie // dziedziczenie 
    {
        public override bool PoprawnyCzas()
        {
            if (czasDostawy.Hour + 2 > DateTime.Now.Hour)
            {
                return true;
            }
            else return false;
        }
    }
}
