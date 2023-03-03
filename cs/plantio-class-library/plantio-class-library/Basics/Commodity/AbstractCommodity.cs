using PlantioClassLibrary.Basics.Region;
using PlantioClassLibrary.Basics.Common;

namespace PlantioClassLibrary.Basics.Commodity
{
    public abstract class AbstractCommodity : ITradable, ICloneable
    {


        /// <summary>
        /// The volume value of the commodity.
        /// <br />
        /// Показатель объёма сырья.
        /// </summary>
        public virtual double Volume { get; set; }


        /// <summary>
        /// The net mass of the commodity.
        /// <br />
        /// Масса нетто сырья.
        /// </summary>
        public virtual double Mass { get; set; }


        /// <summary>
        /// The list of manufacturers of the commodity.
        /// <br />
        /// Список производителей сырья.
        /// </summary>
        public virtual List<Manufacturer>? Manufacturers { get; set; } = null!;


        /// <summary>
        /// The basic type of the commodity.
        /// <br />
        /// Простой тип сырья.
        /// </summary>
        public virtual BasicCommodityType BasicType { get; set; }


        public virtual Finance? Price { get; set; }


        public abstract object Clone();


    }
}
