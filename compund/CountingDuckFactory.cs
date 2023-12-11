using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace compund
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallard()
        {
            return new QuackCounter(new Mallard());
        }

        public override IQuackable CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }
    }
}