using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.Delegate.ConsoleApp.Hander
{
    /// <summary>
    /// 事件
    /// </summary>
    public class Stock
    {



        private decimal price;

        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return;
                decimal oldprice = price;
                price = value;
                OnPriceChanged(new PriceChangedEventArgs(oldprice, Price));
            }
        }


        public event EventHandler<PriceChangedEventArgs> PriceChanged;

        protected virtual void OnPriceChanged(PriceChangedEventArgs e) 
        {
            PriceChanged?.Invoke(this, e);
        }

    }

    public class PriceChangedEventArgs : EventArgs 
    {
        public readonly decimal LastPrice;

        public readonly decimal NewPrice;

        public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)        {
            LastPrice = lastPrice;
            NewPrice = newPrice;
        }

    }
}
