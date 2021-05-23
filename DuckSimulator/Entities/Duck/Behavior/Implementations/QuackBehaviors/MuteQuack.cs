using DuckSimulator.Entities.Duck.Behavior.Interfaces;
using System;

namespace DuckSimulator.Entities.Duck.Behavior.Implementations.QuackBehaviors
{
    class MuteQuack : IQuackBehavior
    {
        public void DuckQuack()
        {
            Console.WriteLine("<< SILENCE >>");
        }
    }
}
