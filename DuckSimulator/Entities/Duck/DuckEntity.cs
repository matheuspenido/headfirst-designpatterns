using DuckSimulator.Entities.Duck.Behavior.Interfaces;
using System;

namespace DuckSimulator.Entities.Duck
{
    public abstract class DuckEntity
    {
        protected IQuackBehavior quackBehavior;
        protected IFlyBehavior flyBehavior;

        public void PerformQuack()
        {
            quackBehavior.DuckQuack();
        }

        public void PerformFly()
        {
            flyBehavior.DuckFly();
        }

        public IFlyBehavior FlyBehavior { set { this.flyBehavior = value; } }

        public IQuackBehavior QuackBehavior { set { this.quackBehavior = value; } }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoy!");
        }
    }
}
