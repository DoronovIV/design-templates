#pragma warning disable 1998


namespace Creational.Performance
{
    public class PrototypePerformer : IPerformable
    {
        public async Task Run()
        {
            SomeNewFinance money = new("Hello world!", 1_000, new("USD", "$"));
            SomeNewFinance money1 = new();

            // Cloning an object;
            money1 = (SomeNewFinance)money.Clone();
            AnsiConsole.Write(new Markup("Two objects have been created. Checking if they are clones...\n\n"));

            // Checking them for the differences;
            bool unitsAreEqual = money1.GetMeta().Equals(money.GetMeta());
            bool linksAreEqual = money1 == money;

            if (unitsAreEqual && !linksAreEqual)
            {
                AnsiConsole.Write(new Markup("[green on black]Success! The objects are identical although the links are different.[/]\n"));
            }
        }
    }
}
