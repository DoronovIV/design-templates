namespace Creational.Catalog.Singleton
{
    public class AlternativeStockSingleton : SimpleStock
    {

        private static AlternativeStockSingleton? instance = null;

        private static string SomeInformation = string.Empty;


        public static string GetSomeInformation()
        {
            return SomeInformation;
        }


        public static AlternativeStockSingleton? GetInstance()
        {
            if (instance is null)
            {
                instance = new AlternativeStockSingleton();
            }

            return instance;
        }


        private AlternativeStockSingleton()
        {
            SomeInformation = SomeInformation + " [yellow on black]Praise the sun![/] I have been created.\n";
        }

    }
}
