using StrategyDesignPuzzle.Entities.EntitiesBehaviors.Weapons.Interfaces;
using System;

namespace StrategyDesignPuzzle.Entities.Character
{
    public abstract class CharacterEntity
    {
        public IWeaponBehavior Weapon { get { return weapon; } set { weapon = value; } }
        private IWeaponBehavior weapon;
        public string ClassName { get; }
        public double Armor { get; }
        public short LifeLevel { get; set; }
        public double Skill { get; }
        public bool isAlive { get { return (LifeLevel > 0); } }

        protected CharacterEntity(string ClassName, double Armor, short LifeLevel, double Skill)
        {
            if (Armor < 0.1 || Armor > 1.0)
                throw new Exception("Hit probability is out of range [0.1,1.0].");
            if (LifeLevel <= 0)
                throw new Exception("Only positive life level is allowed.");
            if (Skill < 0.1 || Skill > 1.0)
                throw new Exception("Attack skill is out of range [0.1,1.0].");

            this.ClassName = ClassName;
            this.Armor = Armor;
            this.LifeLevel = LifeLevel;
            this.Skill = Skill;
        }

        public void Harm(short lifeLevel)
        {
            this.LifeLevel -= lifeLevel;
        }

        public void Fight(CharacterEntity enemy)
        {
            weapon.UseWeapon(this, enemy);
        }
    }
}
