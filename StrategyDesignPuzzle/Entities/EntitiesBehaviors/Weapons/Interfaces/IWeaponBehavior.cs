using StrategyDesignPuzzle.Entities.Character;
using System;

namespace StrategyDesignPuzzle.Entities.EntitiesBehaviors.Weapons.Interfaces
{
    public abstract class IWeaponBehavior
    {
        protected short MaxDamage { get; }
        protected double HitProbability { get; }
        private Random random;

        public IWeaponBehavior(short MaxDamage, double HitProbability)
        {
            if (MaxDamage < 1 || MaxDamage > 10)
                throw new Exception("Damage is out of range [1,10]");
            if (HitProbability < 0.1 || HitProbability > 1.0)
                throw new Exception("Hit probability is out of range [0.1,1.0]");

            this.MaxDamage = MaxDamage;
            this.HitProbability = HitProbability;
            this.random = new Random();
        }

        public void UseWeapon(CharacterEntity attackerCharacterEntity, CharacterEntity enemyCharacterEntity)
        {
            PickUp(attackerCharacterEntity);

            double tryIt = random.NextDouble() * (1.0 + attackerCharacterEntity.Skill) * (1.0 + HitProbability);

            if (tryIt >= enemyCharacterEntity.Armor)
            {
                short damage = (short)( random.NextDouble() * MaxDamage );

                enemyCharacterEntity.Harm(damage);

                Console.WriteLine(attackerCharacterEntity.ClassName + " hit the " + enemyCharacterEntity.ClassName + " with damage of " + damage);
            }
            else
            {
                Console.WriteLine("...AND FAIL TO HIT THE " + enemyCharacterEntity.ClassName + "!");
            }
        }

        public abstract void PickUp(CharacterEntity attackerCharacterEntity);
    }
}