using System.Runtime.InteropServices;

namespace Creational.Catalog.Builder
{
    public interface ICommodityBuilder
    {

        /// <summary>
        /// Reset an object to the default settings.
        /// <br />
        /// Сбросить объект к дефолтным настройкам.
        /// </summary>
        public void Reset();


        /// <summary>
        /// Set the commodity volume value.
        /// <br />
        /// Задать показатель объёма сырья.
        /// </summary>
        public void SetVolume(double volume);


        /// <summary>
        /// Set the list of manufacturers.
        /// <br />
        /// Задать список производителей.
        /// </summary>
        public void SetManufacturers(List<Manufacturer> manufacturerList);


        /// <summary>
        /// Set the basic type of a commodity.
        /// <br />
        /// Задать малый тип сырья.
        /// </summary>
        public void SetBasicType(BasicCommodityType type);


        /// <summary>
        /// Set the price of the commodity.
        /// <br />
        /// Задать цену сырья.
        /// </summary>
        public void SetPrice(Finance Price);


        /// <summary>
        /// Get the result object.
        /// <br />
        /// Получить объект-результат.
        /// </summary>
        public object GetProduct();

    }
}
