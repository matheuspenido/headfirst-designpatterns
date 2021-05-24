using StrategyDesignPuzzle.Entities.EntitiesBehaviors.Weapons.Implementations;
using StrategyDesignPuzzle.Entities.EntitiesBehaviors.Weapons.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPuzzle.Entities.Character.Specializations
{
    class KingEntity : CharacterEntity
    {
        public KingEntity() : base("King", 0.2, 100, 0.8)
        {
            this.Weapon = new KnifeBehavior();
        }
    }
}
