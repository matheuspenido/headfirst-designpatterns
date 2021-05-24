using StrategyDesignPuzzle.Entities.Character;
using StrategyDesignPuzzle.Entities.EntitiesBehaviors.Weapons.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPuzzle.Entities.EntitiesBehaviors.Weapons.Implementations
{
    public class KnifeBehavior : IWeaponBehavior
    {
        public KnifeBehavior() : base(4, 0.6)
        { }

        public override void PickUp(CharacterEntity attackerCharacterEntity)
        {
            Console.Write("Now, the glorious " + attackerCharacterEntity.ClassName + " is ready to cut with the most sharped KNIFE! ");
        }
    }
}
