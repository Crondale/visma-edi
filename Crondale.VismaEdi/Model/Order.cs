using Crondale.VismaEdi.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crondale.VismaEdi.Model
{
    [EdiElement(Name = "OrderHead")]
    public class Order : EdiModel
    {

        public String TrTp { get; set; }
        public String OrdTp { get; set; }
        public String OrdDt { get; set; }
        public String CustNo { get; set; }


        public List<OrderLine> OrderLines { get; private set; }

        public Order()
        {
            OrderLines = new List<OrderLine>();
        }

    }
}
