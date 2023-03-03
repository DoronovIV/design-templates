using PlantioClassLibrary.Basics.Common;

namespace PlantioClassLibrary.Basics.Items
{
    public class SimpleContainer : IContainer
    {


        #region State


        /// <inheritdoc cref="IContainer.GetName"/>
        private string? name;


        /// <inheritdoc cref="IContainer.GetBasicContainerType"/>
        private BasicContainerType _basicType;

        public Finance? Price { get; set ; }



        #endregion State




        #region IContainer



        public BasicContainerType GetBasicContainerType()
        {
            return _basicType;
        }

        public string? GetName()
        {
            return name;
        }

        public object Clone()
        {
            SimpleContainer result = new SimpleContainer(name, _basicType, (Finance)Price.Clone());
            return result;
        }



        #endregion IContainer




        #region Construction




        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public SimpleContainer()
        {
            name = null;
            _basicType = BasicContainerType.Unknown;
            Price = null;
        }



        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public SimpleContainer(string name, BasicContainerType type, Finance price)
        {
            this.name = name;
            _basicType = type;
            Price = price;
        }



        #endregion Construction


    }
}
