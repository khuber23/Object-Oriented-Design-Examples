using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.QuackBehaviors
{
    public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Rubber duckie's squeak!!");
        }
    }
}
