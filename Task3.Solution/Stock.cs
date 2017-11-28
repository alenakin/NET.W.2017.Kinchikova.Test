using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class Stock
    {
        public event EventHandler<UpdateStockInfoEventArgs> UpdatedStockInfo = delegate { };
        
        protected virtual void OnUpdateStockInfo(UpdateStockInfoEventArgs e)
        {
            EventHandler<UpdateStockInfoEventArgs> temp = UpdatedStockInfo;

            temp?.Invoke(this, e);
        }

        public void Market()
        {
            Random rnd = new Random();
            int newUSD = rnd.Next(20, 40);
            int newEuro = rnd.Next(30, 50);
            OnUpdateStockInfo(new UpdateStockInfoEventArgs(newUSD, newEuro));
        }
    }
}
