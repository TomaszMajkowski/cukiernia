using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace WpfApplication1
{
    abstract class Zamowienie
    {
        protected DateTime czasDostawy;

        virtual public bool PoprawnyCzas()
        {
            if (czasDostawy > DateTime.Now)
                return (true);
            else
                return (false);
        }

        public void UstawCzasDostawy(DateTime czasDostawy)
        {
            this.czasDostawy = czasDostawy;
        }

    }
}
