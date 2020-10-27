using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace lisayl2
{
    public class Currency
    {
        public string _code;
        public string _name;
        private List<string> CurrencyCodeList = new List<string>(); //kui ei sobi, siis tee stringina ja lisa listi kood. //võiks olla exchangeratetablei all
        public Currency(string code, string name)
        {
            _code = code;
            _name = name;
            //_currency.AddNewCurrency("EUR", "Euro");
        }
        public Currency(string code)
        {
            _code = code;
        }
        public Currency()
        {

        }
        
        
    }
}
