using PlantioClassLibrary.Basics.Region;

namespace PlantioClassLibrary.Basics.Common
{
    public class Manufacturer
    {



        #region State


        /// <inheritdoc cref="Title"/>
        private string _title;


        /// <inheritdoc cref="Nation"/>
        private Country? _nation;


        /// <summary>
        /// The title of the manufacturer company.
        /// <br />
        /// Название фирмы производителя.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }



        /// <summary>
        /// Country of the manufacturer.
        /// <br />
        /// Страна производителя.
        /// </summary>
        public Country? Nation
        {
            get { return _nation; }
            set { _nation = value; }
        }


        #endregion State





        #region Construction



        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public Manufacturer()
        {
            _title = string.Empty;
            _nation = null;
        }



        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public Manufacturer(string title, Country country)
        {
            _title = title;
            _nation = country;
        }



        #endregion Construction



    }
}
