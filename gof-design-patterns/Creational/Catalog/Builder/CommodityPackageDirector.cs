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
        private Currency? currency;


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
                switch (basicType) 
                {
                    case BasicCommodityType.Fertilizer:
                        return GetFertilizer();


                    case BasicCommodityType.Soil:
                        return GetSoil();


                    default: return null;
                }
            }

            else return null;
        }


        /// <summary>
        /// Get the fertilizer commodity package.
        /// <br />
        /// Получить пакет сырья удобрения.
        /// </summary>
        public CommodityPackage GetFertilizer()
        {
            basicType = BasicCommodityType.Fertilizer;

            builder.SetPrice(new (600, currency));
            builder.SetBasicType(basicType);
            builder.SetManufacturers(new(new Manufacturer[] { new Manufacturer("Renk", new("Germany")) }));
            builder.SetMass(0.020d);

            return (CommodityPackage)builder.GetProduct();
        }


        /// <summary>
        /// Get the soil commodity package.
        /// <br />
        /// Получить пакет сырья почвы.
        /// </summary>
        public CommodityPackage GetSoil()
        {
            basicType = BasicCommodityType.Soil;

            builder.SetPrice(new (2000, currency));
            builder.SetBasicType(basicType);
            builder.SetManufacturers(new(new Manufacturer[] { new Manufacturer("Renk", new("Germany")) }));
            builder.SetMass(10.0d);
            builder.SetVolume(11.5d);

            return (CommodityPackage)builder.GetProduct();
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
