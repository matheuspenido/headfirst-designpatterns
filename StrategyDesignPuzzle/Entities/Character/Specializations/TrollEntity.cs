using StrategyDesignPuzzle.Entities.EntitiesBehaviors.Weapons.Implementations;
using StrategyDesignPuzzle.Entities.EntitiesBehaviors.Weapons.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPuzzle.Entities.Character.Specializations
{
    class TrollEntity : CharacterEntity
    {
        public TrollEntity() : base("Troll", 0.5, 100, 0.4)
        {
            this.Weapon = new AxeBehavior();
        }
    }
}
