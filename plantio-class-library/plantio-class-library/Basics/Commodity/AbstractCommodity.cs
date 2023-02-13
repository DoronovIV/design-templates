using PlantioClassLibrary.Basics.Region;
using PlantioClassLibrary.Basics.Common;

namespace PlantioClassLibrary.Basics.Commodity
{
    public abstract class AbstractCommodity
    {


        /// <summary>
        /// The volume value of the commodity.
        /// <br />
        /// Показатель массы сырья.
        /// </summary>
        public virtual double Volume { get; set; }


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


        /// <summary>
        /// The price of the commodity.
        /// <br />
        /// Стоимость сырья.
        /// </summary>
        public virtual Finance? Price { get; set; }


    }
}
