using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Solution;

namespace Task3.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            Broker broker = new Broker("broker1");
            broker.Register(stock);
            Bank bank = new Bank("bank1", stock);
            stock.Market();
        }
    }
}
