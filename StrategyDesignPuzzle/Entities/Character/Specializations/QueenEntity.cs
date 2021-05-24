using StrategyDesignPuzzle.Entities.EntitiesBehaviors.Weapons.Implementations;

namespace StrategyDesignPuzzle.Entities.Character.Specializations
{
    class QueenEntity : CharacterEntity
    {
        public QueenEntity() : base("Queen", 0.3, 200, 0.2)
        {
            this.Weapon = new BowAndArrowBehavior();
        }
    }
}
