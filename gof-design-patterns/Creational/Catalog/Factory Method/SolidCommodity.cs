using PlantioClassLibrary.Basics.Common;
using System.ComponentModel;
using System.Diagnostics;

namespace Creational.Catalog.FactoryMethod
{
    public class SolidCommodityMass : CommodityMass, IPresentable
    {

        public static bool isLiquid = false; // :p

        public override object Clone()
        {
            List<Manufacturer> manufacturersCopy = new();
            Manufacturers.CopyTo(manufacturersCopy.ToArray());

            List<CommodityType> typesCopy = new();
            CommodityTypes.CopyTo(typesCopy.ToArray());
            return new SolidCommodityMass(BasicType, typesCopy, Volume, Mass, manufacturersCopy, (Finance)Price.Clone());
        }

        public string GetManufacturer()
        {
            return Manufacturers.First().Title + "(" + Manufacturers.First().Nation.Name + ")";
        }

        public string GetMass()
        {
            return Mass.ToString() + " (kg)";
        }

        public string GetPrice()
        {
            return Price.ToString();
        }



        public SolidCommodityMass()
        {
            BasicType = BasicCommodityType.Unknown;
            CommodityTypes = null;
            Volume = 0;
            Mass = 0;
            Price = null;
            Manufacturers = null;
        }


        public SolidCommodityMass(BasicCommodityType type, List<CommodityType> typeList, double volume, double mass, List<Manufacturer> manufacturers, Finance price)
        {
            BasicType = type;
            CommodityTypes = typeList;
            Volume = volume;
            Mass = mass;
            Price = price;
            Manufacturers = manufacturers;
        }


    }
}
