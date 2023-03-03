using PlantioClassLibrary.Basics.Commodity;
using PlantioClassLibrary.Basics.Items;

namespace PlantioClassLibrary.Basics.RealEstate
{
    public abstract class Stock : ICloneable
    {


        public CommodityStock? CommodityStock { get; set; }


        public ContainerStock? ContainerStock { get; set; }


        public string? Name { get; set; }


        public abstract object Clone();

    }
}
