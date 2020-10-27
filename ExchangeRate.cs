using System;
using System.Collections.Generic;
using System.Text;

namespace lisayl2
{
    public class ExchangeRate
    {
        public float _ExchangeRate;
        public string _StartCurrency;
        public string _EndCurrency;
        public ExchangeRate(Currency startcurrency, Currency endcurrency, float exchangerate)
        {
            Currency StartCurrency = new Currency(startcurrency._code);
            Currency EndCurrency = new Currency(endcurrency._code);
            _StartCurrency = StartCurrency._code;
            _EndCurrency = EndCurrency._code;
            _ExchangeRate = exchangerate;

        }
    }
}
