namespace Creational.Catalog.FactoryMethod
{
    public class LiquidCommodityMassCreator : AbstractCreator
    {

        public override IPresentable Create()
        {
            return new LiquidCommodityMass(BasicCommodityType.Other, new(new CommodityType[] { new("Water"), new("Liquid Fertilizer") }), 10, 10, new(new Manufacturer[] { new("Renk", new("Germany")) }), new Finance(10, new Currency("USD", "$")));
        }



        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public LiquidCommodityMassCreator()
        {

        }

    }
}
