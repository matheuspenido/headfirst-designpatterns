using StrategyDesignPuzzle.Entities.Character;
using StrategyDesignPuzzle.Entities.EntitiesBehaviors.Weapons.Interfaces;
using System;

namespace StrategyDesignPuzzle.Entities.EntitiesBehaviors.Weapons.Implementations
{
    class SwordBehavior : IWeaponBehavior
    {
        public SwordBehavior() : base(9, 0.4)
        { }

        public override void PickUp(CharacterEntity attackerCharacterEntity)
        {
            Console.Write("Now, the glorious " + attackerCharacterEntity.ClassName + " is ready to cut head of with SWORD! ");
        }
    }
}
