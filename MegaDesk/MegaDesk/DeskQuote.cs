using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class DeskQuote
    {
        public enum Shipping
        {
            Rush3Days,
            Rush5Days,
            Rush7Days,
            Normal14Days
        }
        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        public string ShippingType { get; set; }

        public decimal QuotePrice { get; set; }

        public Desk Desk { get; set; }

        public decimal getQuotePrice() {

            return 0;
        }


    }
}
