using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crondale.VismaEdi
{
    class EdiRow
    {

        private Dictionary<String, String> fields = new Dictionary<string, string>();

        internal EdiRow()
        {

        }


        internal String this[String key]
        {
            get
            {
                if (!fields.ContainsKey(key))
                    return null;

                return fields[key];
            }
            set
            {
                if (value == null)
                    return;

                fields[key] = value.Trim();
            }
        }

    }
}
