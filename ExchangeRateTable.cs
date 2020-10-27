using System;
using System.Collections.Generic;
using System.Text;

namespace lisayl2
{
    public class ExchangeRateTable
    {
        public List<ExchangeRate> _rates = new List<ExchangeRate>();
        private List<string> CurrencyCodeList = new List<string>(); //kui ei sobi, siis tee stringina ja lisa listi kood. //võiks olla exchangeratetablei all
        public void AddNewCurrency(string code, string name)
        {
            Currency currency = new Currency(code, name);
            CurrencyCodeList.Add(currency._code); //currencylist.add(currency.code)

        }
        public List<string> GetCurrencies()
        {
            return CurrencyCodeList;
        }
        public void AddExchangeRate(Currency startcurrency, Currency endcurrency, float rate)
        {
            ExchangeRate Rate = new ExchangeRate(startcurrency, endcurrency, rate);
            _rates.Add(Rate);
        }
        public void ChangeExchangeRate(int rateIndex, ExchangeRate newExchangeRate)
        {
            _rates[rateIndex]._ExchangeRate = newExchangeRate._ExchangeRate;
        }
        public string ShowExchangeRates(Currency currency)
        {
            string table = "<tr><th>Start Currency</th><th> End Currency</th> <th>ExchangeRate</th></tr>";
            foreach (var exchangerate in _rates)
            {
                if (currency._code == exchangerate._StartCurrency || currency._code == exchangerate._EndCurrency)
                {
                    table += "<tr><td>" + exchangerate._StartCurrency + "</td>" +
                        "<td>" + exchangerate._EndCurrency + "</td>" +
                        "<td>" + exchangerate._ExchangeRate + "</td></tr>" + "\n";
                }
            }
            return table;
        }
        public float ConvertSumToAnotherCurrency(Currency EndCurrency, MoneyAmount sum)
        {
            float result = 0f;
            int amount = 0;
            Currency startcurrency = sum._currency;
            foreach (var item in _rates)
            {
                if (startcurrency._code == item._StartCurrency && EndCurrency._code == item._EndCurrency)
                {
                    result = sum._sum * item._ExchangeRate;
                    break;
                }
            }
            return result;
        }
    }
}
