#pragma warning disable 1998

using Creational.Catalog.FactoryMethod;

namespace Creational.Performance
{
    public class AbstractMethodPerformer : IPerformable
    {
        public async Task Run()
        {
            LegalPayment payment = new (10_000, new ("RUB", "P"));
            payment = payment.Convert(new ("USD", "$"));
            Console.WriteLine(payment.Amount);
        }
    }
}
