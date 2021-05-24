using StrategyDesignPuzzle.Entities.Character;
using StrategyDesignPuzzle.Entities.Character.Specializations;
using StrategyDesignPuzzle.Entities.EntitiesBehaviors.Weapons.Implementations;
using StrategyDesignPuzzle.Entities.EntitiesBehaviors.Weapons.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace StrategyDesignPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a not ended simulator using the strategy pattern to make behaviors about weapons used in the simulator.
            //The battle is ended when the king is defeated.
            //See: https://www.amazon.com.br/gp/product/B08P3X99QP?pf_rd_r=Y329M5SD8EZM51SPSCRP&pf_rd_p=72a7651a-a7d8-4551-b248-c61480b6ce6e&pd_rd_r=623c9ee4-0a54-4ac8-b6cc-efb8c6b5e60c&pd_rd_w=KAR3Y&pd_rd_wg=Y7D6a&ref_=pd_gw_unk

            Random random = new Random();

            CharacterEntity queen = new QueenEntity();
            CharacterEntity king = new KingEntity();
            CharacterEntity troll = new TrollEntity();
            CharacterEntity knight = new KnightEntity();

            List<IWeaponBehavior> weaponList = new List<IWeaponBehavior>();

            weaponList.Add(new SwordBehavior());
            weaponList.Add(new KnifeBehavior());
            weaponList.Add(new AxeBehavior());
            weaponList.Add(new BowAndArrowBehavior());

            while (king.isAlive == true)
            {
                Console.WriteLine("============================");
                Console.WriteLine("=========LIFE PANEL=========");
                Console.WriteLine("King life: " + king.LifeLevel);
                Console.WriteLine("Queen life: " + queen.LifeLevel);
                Console.WriteLine("Troll life: " + troll.LifeLevel);
                Console.WriteLine("Knight life: " + knight.LifeLevel);
                Console.WriteLine("============================\n\n");

                king.Fight(queen);
                king.Fight(troll);
                king.Fight(knight);
                queen.Fight(king);
                queen.Fight(troll);
                queen.Fight(knight);
                knight.Fight(troll);
                knight.Fight(queen);
                knight.Fight(king);
                troll.Fight(king);
                troll.Fight(queen);
                troll.Fight(knight);

                weaponList = weaponList.OrderBy(x => random.Next()).ToList();

                if (king.isAlive)
                {
                    Console.WriteLine("============================");
                    Console.WriteLine("Time to interchange weapons!");
                    Console.WriteLine("============================\n\n");
                }

                Thread.Sleep(10000);

                king.Weapon = weaponList.ElementAt(0);
                queen.Weapon = weaponList.ElementAt(1);
                troll.Weapon = weaponList.ElementAt(2);
                knight.Weapon = weaponList.ElementAt(3);
            }

            Console.WriteLine("============================");
            Console.WriteLine("=========LIFE PANEL=========");
            Console.WriteLine("King life: " + king.LifeLevel);
            Console.WriteLine("Queen life: " + queen.LifeLevel);
            Console.WriteLine("Troll life: " + troll.LifeLevel);
            Console.WriteLine("Knight life: " + knight.LifeLevel);
            Console.WriteLine("============================\n\n");
        }
    }
}
