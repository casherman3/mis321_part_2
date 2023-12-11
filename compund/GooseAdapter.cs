using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace compund
{
    public class GooseAdapter : IQuackable
    {
        Goose goose;

        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
        }

        public void Quack()
        {
            goose.Honk();
        }
    }
}