using DuckSimulator.Entities.Duck.Behavior.Implementations.FlyBehaviors;
using DuckSimulator.Entities.Duck.Behavior.Implementations.QuackBehaviors;

namespace DuckSimulator.Entities.Duck.Specializations
{
    class MallarDuck : DuckEntity
    {
        public MallarDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
    }
}
