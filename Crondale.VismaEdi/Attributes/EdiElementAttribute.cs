using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crondale.VismaEdi.Attributes
{
    class EdiElementAttribute : Attribute
    {

        public String Name { get; set; }

        public bool IdentifyByFirst { get; set; }
    }
}
