using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace compund
{
    public class Mallard : IQuackable
    {
        public void Quack()
        {
            System.Console.WriteLine("Quack");
        }
    }
}