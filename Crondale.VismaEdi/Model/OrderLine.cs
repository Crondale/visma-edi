using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crondale.VismaEdi.Model
{
    public class OrderLine : EdiModel
    {

        public String ProdNo { get; set; }

        /// <summary>
        /// Quantity of product
        /// </summary>
        public String NoInvoAb { get; set; }
        public String Descr { get; set; }

        
    }
}
