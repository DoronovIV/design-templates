namespace Creational.Catalog.FactoryMethod
{
    public class SolidCommodityMassCreator : AbstractCreator
    {
        public override IPresentable Create()
        {
            return new SolidCommodityMass(BasicCommodityType.Other, new(new CommodityType[] { new("Black Soil"), new("Turf") }), 0, 20, new(new Manufacturer[] { new("Custom", new("Unknown")) }), new Finance(10, new Currency("USD", "$")));
        }
    }
}
