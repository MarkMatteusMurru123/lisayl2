using System;
using System.Collections.Generic;
using System.Text;

namespace lisayl2
{
    public class MoneyAmount
    {
        public int _sum;
        public Currency _currency;
        //private List<Currency> _currencyList;
        public MoneyAmount(int summa, Currency currency)
        {
            _sum = summa;
            _currency = currency;
            //_currencyList = _currency.GetCurrencies();
        }
        public decimal GetAmount()
        {
            return _sum;  
        }
        //public bool CurrencyCheck(Currency currency)
        //{
        //    if (_currencyList.Contains(currency))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Is not a valid currency!");
        //        return false;
        //    }
        //}
        public void AddMoney(int amount) {

            _sum += amount;
        }
        public void RemoveMoney(int amount)
        {
            _sum -= amount;

        }
        

    }
}


