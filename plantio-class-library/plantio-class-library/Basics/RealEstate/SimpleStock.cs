using PlantioClassLibrary.Basics.Commodity;
using PlantioClassLibrary.Basics.Items;

namespace PlantioClassLibrary.Basics.RealEstate
{
    public class SimpleStock : Stock
    {


        #region API



        public override object Clone()
        {
            string copyName = new string(Name.ToCharArray());
            SimpleStock result = new(copyName, (CommodityStock)CommodityStock.Clone(), (ContainerStock)ContainerStock.Clone());
            return result;
        }



        #endregion API




        #region Construction




        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public SimpleStock()
        {
            CommodityStock = null;
            ContainerStock = null;
            Name = null;
        }



        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public SimpleStock(string name, CommodityStock commodityStock, ContainerStock containerStock)
        {
            Name = name;
            CommodityStock = commodityStock;
            ContainerStock = containerStock;
        }



        #endregion Construction



    }
}
