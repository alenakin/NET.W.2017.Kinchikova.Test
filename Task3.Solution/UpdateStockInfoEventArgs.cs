using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class UpdateStockInfoEventArgs : EventArgs
    {
        public int USD { get; private set; }
        public int Euro { get; private set; }

        public UpdateStockInfoEventArgs(int usd, int euro)
        {
            USD = usd;
            Euro = euro;
        }
    }
}
