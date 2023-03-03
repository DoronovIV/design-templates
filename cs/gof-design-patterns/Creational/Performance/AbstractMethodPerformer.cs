#pragma warning disable 1998

using Creational.Catalog.FactoryMethod;

namespace Creational.Performance
{
    public class AbstractMethodPerformer : IPerformable
    {
        public async Task Run()
        {
            Console.WriteLine("App: Launched with the Liquid Mass Creator.");
            OuterCode(new LiquidCommodityMassCreator());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the Solid Mass Creator.");
            OuterCode(new SolidCommodityMassCreator());
        }


        public void OuterCode(AbstractCreator creator)
        {
            AnsiConsole.Write(new Markup("Client: I'm not aware of the creator's class," +
    "but it still works.\n" + creator.Announce() + "\n"));
        }
    }
}
