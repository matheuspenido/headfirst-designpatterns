using DuckSimulator.Entities.Duck;
using DuckSimulator.Entities.Duck.Behavior.Implementations.FlyBehaviors;
using DuckSimulator.Entities.Duck.Specializations;
using DuckSimulator.Entities.MimicDevice;
using DuckSimulator.Entities.MimicDevice.Specializations;

namespace DuckSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            DuckEntity mallard = new MallarDuck();

            mallard.PerformQuack();
            mallard.PerformFly();

            DuckEntity model = new ModelDuck();
            model.PerformFly();
            model.FlyBehavior = new FlyRocketPowered();
            model.PerformFly();

            MimicDeviceEntity deviceForHunter = new DuckHunterDevice();

            deviceForHunter.PerformQuack();
        }
    }
}
