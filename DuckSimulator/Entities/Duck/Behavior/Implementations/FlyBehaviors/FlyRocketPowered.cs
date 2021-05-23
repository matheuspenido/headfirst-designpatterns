using DuckSimulator.Entities.Duck.Behavior.Interfaces;
using System;

namespace DuckSimulator.Entities.Duck.Behavior.Implementations.FlyBehaviors
{
    class FlyRocketPowered : IFlyBehavior
    {
        public void DuckFly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
