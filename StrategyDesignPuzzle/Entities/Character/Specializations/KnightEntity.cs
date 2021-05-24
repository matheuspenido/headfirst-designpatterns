using StrategyDesignPuzzle.Entities.EntitiesBehaviors.Weapons.Implementations;
using StrategyDesignPuzzle.Entities.EntitiesBehaviors.Weapons.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPuzzle.Entities.Character.Specializations
{
    class KnightEntity : CharacterEntity
    {
        public KnightEntity() : base("Knight", 0.5, 150, 0.6)
        {
            this.Weapon = new SwordBehavior();
        }
    }
}
