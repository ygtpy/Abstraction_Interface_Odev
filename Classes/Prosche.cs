using Abstraction_Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Assignment.Classes
{
    internal class Prosche : IFly
    {
        public void Fly()
        {
            Console.Write("Havada uçar ");
        }
    }
}
