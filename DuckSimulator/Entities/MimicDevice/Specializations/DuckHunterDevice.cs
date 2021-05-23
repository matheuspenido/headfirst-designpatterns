using DuckSimulator.Entities.Duck.Behavior.Implementations.QuackBehaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.Entities.MimicDevice.Specializations
{
    class DuckHunterDevice : MimicDeviceEntity
    {
        public DuckHunterDevice()
        {
            quackBehavior = new Quack();
        }
    }
}
