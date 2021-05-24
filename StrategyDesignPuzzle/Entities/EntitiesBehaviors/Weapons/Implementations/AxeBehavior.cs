using StrategyDesignPuzzle.Entities.Character;
using StrategyDesignPuzzle.Entities.EntitiesBehaviors.Weapons.Interfaces;
using System;

namespace StrategyDesignPuzzle.Entities.EntitiesBehaviors.Weapons.Implementations
{
    public class AxeBehavior : IWeaponBehavior
    {
        public AxeBehavior() : base(8, 0.1)
        {}

        public override void PickUp(CharacterEntity attackerCharacterEntity)
        {
            Console.Write("Now, the glorious " + attackerCharacterEntity.ClassName + " is rotating the BIG AXE! ");
        }
    }
}
