using DuckSimulator.Entities.Duck.Behavior.Interfaces;

namespace DuckSimulator.Entities.MimicDevice
{
    abstract class MimicDeviceEntity
    {
        protected IQuackBehavior quackBehavior;

        public void PerformQuack()
        {
            quackBehavior.DuckQuack();
        }
    }
}
