namespace Creational.Catalog.Builder
{
    public class CommodityPackageBuilder : ICommodityBuilder
    {


        #region State


        /// <summary>
        /// The built object instance.
        /// <br />
        /// Экземпляр строящегося объекта.
        /// </summary>
        private CommodityPackage objectBuilt = null!;


        #endregion State




        #region API


        public object GetProduct()
        {
            return objectBuilt;
        }


        public void Reset()
        {
            objectBuilt = new();
        }


        public void SetBasicType(BasicCommodityType type)
        {
            objectBuilt.BasicType = type;
        }


        public void SetManufacturers(List<Manufacturer> manufacturerList)
        {
            objectBuilt.Manufacturers = manufacturerList;
        }


        public void SetPrice(Finance Price)
        {
            objectBuilt.Price = Price;
        }


        public void SetVolume(double volume)
        {
            objectBuilt.Volume = volume;
        }


        public void SetMass(double mass)
        {
            //objectBuilt.Mass = mass;
        }


        #endregion API




        #region Construction


        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public CommodityPackageBuilder()
        {
            objectBuilt = new();
        }


        #endregion Construction


    }
}
