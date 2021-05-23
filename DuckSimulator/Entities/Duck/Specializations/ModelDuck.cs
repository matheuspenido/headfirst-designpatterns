using DuckSimulator.Entities.Duck.Behavior.Implementations.FlyBehaviors;
using DuckSimulator.Entities.Duck.Behavior.Implementations.QuackBehaviors;
using System;

namespace DuckSimulator.Entities.Duck.Specializations
{
    class ModelDuck : DuckEntity
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public void Display() {
            Console.WriteLine("I'm a model duck!");
        }
    }
}
