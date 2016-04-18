using System;

namespace Observer
{
    public class Investor : IInvestor
    {
        private string _name;
        public Investor(string name)
        {
            this._name = name;
        }

        private Stock _stock;
        public Stock Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public void Update(Stock stock)
        {
            this._stock = stock;
        }
    }

   
}