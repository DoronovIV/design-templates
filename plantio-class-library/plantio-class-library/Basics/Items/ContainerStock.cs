using PlantioClassLibrary.Basics.Common;

namespace PlantioClassLibrary.Basics.Items
{
    public class ContainerStock : ICloneable, ITradable
    {


        #region State



        /// <inheritdoc cref="Container"/>
        private IContainer? _container;


        /// <inheritdoc cref="Amount"/>
        private int _amount;



        /// <summary>
        /// The type of containers.
        /// <br />
        /// Тип контейнеров.
        /// </summary>
        public IContainer? Container
        {
            get { return _container; }
            set { _container = value; }
        }


        /// <summary>
        /// The amount of containers.
        /// <br />
        /// Кол-во контейнеров.
        /// </summary>
        public int Amount
        {
            get { return _amount; } 
            set { _amount = value; }
        }


        public Finance? Price { get; set; }



        #endregion State



        #region API



        public object Clone()
        {
            ContainerStock result = new ContainerStock((IContainer)Container.Clone(), Amount);
            return result;
        }



        #endregion API



        #region Construction



        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public ContainerStock()
        {
            Price = null;
            Container = null;
            Amount = 0;
        }



        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public ContainerStock(IContainer container, int amount)
        {
            Container = container;
            Amount = amount;
            Price = new Finance(Container.Price.Amount * Amount /* amount of items */, Container.Price.Currency);
        }



        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public ContainerStock(IContainer container, int amount, Finance price)
        {
            Container = container;
            Amount = amount;
            Price = price;
        }



        #endregion Construction


    }
}
