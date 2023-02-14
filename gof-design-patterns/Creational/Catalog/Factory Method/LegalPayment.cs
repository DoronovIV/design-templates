using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Catalog.FactoryMethod
{
    public class LegalPayment : Finance, IConvertable<LegalPayment>
    {
        private static Currency feeCurrency = new("USD", "$");

        private static Finance fee = new Finance(0.5m, feeCurrency);


        public LegalPayment Convert(Currency currency)
        {
            if (currency.Code != Currency.Code)
            {
                var comissionedPayment = TakeCommissionFee();

                return new LegalPayment(comissionedPayment.Amount * (Decimal)(CurrencyExtensions.GetCurrencyRate(Currency)), currency);
            }

            else return this;
        }


        protected LegalPayment TakeCommissionFee()
        {
            Currency previousCurrency = Currency;

            PrivatePayment unrentedPayment = new(Amount, Currency);

            unrentedPayment = unrentedPayment.Convert(feeCurrency);

            decimal newAmount = unrentedPayment.Amount;
            if (unrentedPayment.Amount > fee.Amount) newAmount = unrentedPayment.Amount - fee.Amount;

            var rentedPayment = new PrivatePayment
            (
                amount: newAmount,
                currency: feeCurrency
            );

            rentedPayment = rentedPayment.Convert(previousCurrency);

            return new LegalPayment(rentedPayment.Amount, rentedPayment.Currency);
        }



        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public LegalPayment()
        {
            Amount = 0.0m;
            Currency = null;
        }


        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public LegalPayment(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }

    }
}
