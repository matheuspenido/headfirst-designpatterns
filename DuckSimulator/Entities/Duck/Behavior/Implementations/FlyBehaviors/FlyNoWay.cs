using DuckSimulator.Entities.Duck.Behavior.Interfaces;
using System;

namespace DuckSimulator.Entities.Duck.Behavior.Implementations.FlyBehaviors
{
    class FlyNoWay : IFlyBehavior
    {
        public void DuckFly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
