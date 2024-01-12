using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Chef
    {
        public Chef() { }

        public void MakeChicken()
        {
            Console.WriteLine("Making chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("Making salad");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("Making special dish");
        }
    }
}
