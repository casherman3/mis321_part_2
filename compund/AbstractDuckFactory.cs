using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace compund
{
    public abstract class AbstractDuckFactory
    {
        public abstract IQuackable CreateMallard();
        public abstract IQuackable CreateDuckCall();
    }
}