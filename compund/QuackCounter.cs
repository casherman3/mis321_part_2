using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace compund
{
    public class QuackCounter : IQuackable
    {
        IQuackable duck;
        static int numberOfQuacks;
        public QuackCounter(IQuackable duck)
        {
            this.duck = duck;
        }
        public void Quack()
        {
            duck.Quack();
            numberOfQuacks++;
        }
        public static int GetNumebrOfQuacks()
        {
            return numberOfQuacks;
        }

    }
}