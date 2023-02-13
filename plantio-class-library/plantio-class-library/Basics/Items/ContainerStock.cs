namespace PlantioClassLibrary.Basics.Items
{
    public class ContainerStock
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



        #endregion State




        #region Construction



        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public ContainerStock()
        {
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
        }



        #endregion Construction


    }
}
