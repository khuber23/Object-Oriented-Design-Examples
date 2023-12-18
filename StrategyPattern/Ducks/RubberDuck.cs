using StrategyPattern.FlyBehaviors;
using StrategyPattern.QuackBehaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
        }
        public override void display()
        {
            Console.WriteLine("I'm a rubber duck");
        }
    }
}
