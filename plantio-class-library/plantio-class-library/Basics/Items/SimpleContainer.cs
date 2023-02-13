using PlantioClassLibrary.Basics.Common;

namespace PlantioClassLibrary.Basics.Items
{
    public class SimpleContainer : IContainer
    {


        #region State


        /// <inheritdoc cref="IContainer.GetName"/>
        private string? _name;


        /// <inheritdoc cref="IContainer.GetBasicContainerType"/>
        private BasicContainerType _basicType;

        /// <inheritdoc cref="IContainer.GetPrice"/>
        private Finance? _price;


        #endregion State




        #region IContainer



        public BasicContainerType GetBasicContainerType()
        {
            return _basicType;
        }

        public string? GetName()
        {
            return _name;
        }

        public Finance? GetPrice()
        {
            return _price;
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
            _name = null;
            _basicType = BasicContainerType.Unknown;
            _price = null;
        }



        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public SimpleContainer(string name, BasicContainerType type, Finance price)
        {
            _name = name;
            _basicType = type;
            _price = price;
        }



        #endregion Construction


    }
}
