using DuckSimulator.Entities.Duck.Behavior.Interfaces;
using System;

namespace DuckSimulator.Entities.Duck.Behavior.Implementations.FlyBehaviors
{
    class FlyWithWings : IFlyBehavior
    {
        public void DuckFly()
        {
            Console.WriteLine("I'm flying with my wings!");
        }
    }
}
