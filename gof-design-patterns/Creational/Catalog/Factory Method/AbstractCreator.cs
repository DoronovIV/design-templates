namespace Creational.Catalog.FactoryMethod
{
    public abstract class AbstractCreator
    {

        public abstract IPresentable Create();


        public string Announce()
        {
            var product = Create();

            string result = $"Creator: [green on black]{product.GetType()}[/] was just created.";

            return result;
        }

    }
}
