using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Catalog.Builder
{
    public class CommodityPackageDirector
    {


        #region State


        /// <summary>
        /// A builder instance reference.
        /// <br />
        /// Ссылка на экземпляр билдера.
        /// </summary>
        private ICommodityBuilder builder;


        /// <summary>
        /// The basic type of the commodity.
        /// <br />
        /// Простой тип сырья.
        /// </summary>
        private BasicCommodityType basicType;


        /// <summary>
        /// The currency for the prices configuration.
        /// <br />
        /// Валюта для конфигурирования цен.
        /// </summary>
        private Currency currency;


        #endregion State



        #region API


        /// <summary>
        /// Returns new commodity package if the basic type was predefined at the director construction time. Otherwise - 'null'.
        /// <br />
        /// Возвращает новый пакет сырья, если простой тип был определён на этапе конструктора директора. Иначе - 'null'.
        /// </summary>
        public CommodityPackage? GetProduct()
        {
            if (basicType is not BasicCommodityType.Unknown)
            {
                throw new NotImplementedException();
            }

            else return null;
        }


        public CommodityPackage GetFertilizer()
        {
            basicType = BasicCommodityType.Fertilizer;

            builder.SetPrice(new(600, currency));
            builder.SetBasicType(basicType);
            builder.SetManufacturers(new(new Manufacturer[] { new Manufacturer("Renk", new("Germany")) }));
            builder.SetVolume(50);

        }


        #endregion API




        #region Construction


        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public CommodityPackageDirector()
        {
            builder = new CommodityPackageBuilder();
            basicType = BasicCommodityType.Unknown;
            currency = null;
        }



        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public CommodityPackageDirector(BasicCommodityType type, Currency currency) : this()
        {
            basicType = type;
            this.currency = currency;
        }


        #endregion Construction

    }
}
