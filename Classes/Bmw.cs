using Abstraction_Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Assignment.Classes
{
    public class Bmw : IDrive, IFloat, IFly
    {
        public void Drive()
        {
            Console.Write("BMW çok hızlı gider, ");
        }

        public void Float()
        {
            Console.Write("Denizde yüzer, ");
        }

        public void Fly()
        {
            Console.Write("havada uçar ");
        }

    }
}
