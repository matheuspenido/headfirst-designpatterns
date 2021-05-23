using DuckSimulator.Entities.Duck;
using DuckSimulator.Entities.Duck.Behavior.Implementations.FlyBehaviors;
using DuckSimulator.Entities.Duck.Specializations;
using DuckSimulator.Entities.MimicDevice;
using DuckSimulator.Entities.MimicDevice.Specializations;

namespace DuckSimulator
{
    class Program

    //For more details: https://www.amazon.com.br/gp/product/B08P3X99QP?pf_rd_r=0W3Q803Q1FZTF1JY7Y6Y&pf_rd_p=72a7651a-a7d8-4551-b248-c61480b6ce6e&pd_rd_r=23b19d1f-14d7-4cae-86dc-df0b7874c02c&pd_rd_w=tHqau&pd_rd_wg=meIfc&ref_=pd_gw_unk
    {
        static void Main(string[] args)
        {
            //Create one kind of duck.
            DuckEntity mallard = new MallarDuck();

            //Test entity
            mallard.PerformQuack();
            mallard.PerformFly();

            //Create another kind of duck (another behavior duck)
            DuckEntity model = new ModelDuck();

            //Test new entity.
            model.PerformFly();

            //Change duck behavior in runtime.
            model.FlyBehavior = new FlyRocketPowered();

            //Test new behavior.
            model.PerformFly();

            //Create another kind of Duck.
            //It's not a child of DuckEntity class but at same time it can use the behaviors because there are no inhertitance here
            //only composition from encapsulated algorithms behaviors regardless of DuckEntity. Great advantage!
            MimicDeviceEntity deviceForHunter = new DuckHunterDevice();

            deviceForHunter.PerformQuack();
        }
    }
}
