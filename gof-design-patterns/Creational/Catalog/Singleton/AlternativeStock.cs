namespace Creational.Catalog.Singleton
{
    public class AlternativeStock : SimpleStock
    {

        private static string SomeInformation = string.Empty;


        public static string GetSomeInformation()
        {
            return SomeInformation;
        }


        public AlternativeStock()
        {
            SomeInformation = SomeInformation + " Hello! I have been created.\n";
        }

    }
}
