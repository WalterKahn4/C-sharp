using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("Make paste");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("Make special Italian dish");
        }
    }
}
