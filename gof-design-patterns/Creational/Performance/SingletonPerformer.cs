#pragma warning disable 1998


namespace Creational.Performance
{
    public class SingletonPerformer : IPerformable
    {
        public async Task Run()
        {
            AlternativeStock ordinaryStock = new();
            AlternativeStock ordinaryStock1 = new();
            AlternativeStock ordinaryStock2 = new();

            //AlternativeStockSingleton exceptionalStock = new();
            AlternativeStockSingleton? exceptionalStock1 = AlternativeStockSingleton.GetInstance();
            AlternativeStockSingleton? exceptionalStock2 = AlternativeStockSingleton.GetInstance();

            AnsiConsole.Write(new Markup(AlternativeStock.GetSomeInformation()));
            AnsiConsole.Write(new Markup(AlternativeStockSingleton.GetSomeInformation()));
        }
    }
}
