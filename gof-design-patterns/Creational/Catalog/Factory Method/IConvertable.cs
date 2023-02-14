using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Catalog.FactoryMethod
{
    public interface IConvertable<T>
        where T : class
    {
        public T Convert(Currency currency);

    }
}
