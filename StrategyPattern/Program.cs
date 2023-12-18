using StrategyPattern.Ducks;
using System;
using System.Collections.Generic;

internal class Program
{
    public static void DisplayDuckInfo(Duck duck)
    {
        duck.display();
        duck.swim();
        duck.performFly();
        duck.performQuack();
        Console.WriteLine();
    }

    private static void Main(string[] args)
    {
        List<Duck> ducks = new List<Duck>
        {
            new MallardDuck(),
            new RedheadDuck(),
            new DecoyDuck(),
            new RubberDuck(),
        };

        foreach (Duck duck in ducks) { DisplayDuckInfo(duck); }

        Console.Read();
    }
}