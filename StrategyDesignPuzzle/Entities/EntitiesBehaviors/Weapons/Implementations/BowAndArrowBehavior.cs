using StrategyDesignPuzzle.Entities.Character;
using StrategyDesignPuzzle.Entities.EntitiesBehaviors.Weapons.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPuzzle.Entities.EntitiesBehaviors.Weapons.Implementations
{
    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public BowAndArrowBehavior() : base(7, 0.2)
        {}

        public override void PickUp(CharacterEntity attackerCharacterEntity)
        {
            Console.Write("Now, the glorious " + attackerCharacterEntity.ClassName + " is aiming with the mortal BOW! ");
        }
    }
}
