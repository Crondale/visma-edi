using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crondale.VismaEdi
{
    class EdiSet
    {

        internal int Priority { get; set; }
        internal String Name { get; set; }


        internal List<String> Headers
        {
            get
            {
                return headers;
            }
        }

        private List<EdiRow> rows = new List<EdiRow>();
        private List<String> headers = new List<String>();


        internal EdiSet(string name)
            :this(name, 50)
        {
        }

        internal EdiSet(string name, int pri)
        {
            Name = name;
            Priority = pri;
        }


        internal String[,] GetTable()
        {
            String[,] table = new String[headers.Count, rows.Count + 1];

            for(int i = 0; i < headers.Count; i++)
            {
                table[i, 0] = headers[i];
            }

            int rowIndex = 1;

            foreach (EdiRow row in rows)
            {
                for (int i = 0; i < headers.Count; i++)
                {
                    table[i, rowIndex] = row[headers[i]];
                }

                rowIndex++;
            }

            return table;
        }

        internal void RemoveUnusedFields()
        {
            for(int i = headers.Count - 1; i >= 0; i--)
            {
                string header = headers[i];
                bool delete = true;

                foreach(EdiRow row in rows)
                {
                    if (row[header] != null && row[header] != "0")
                    {
                        delete = false;
                        break;
                    }
                }

                if(delete)
                {
                    headers.RemoveAt(i);
                }
            }
        }


        internal void Add(EdiRow row)
        {
            rows.Add(row);
        }

        internal void AddHeader(string header)
        {
            headers.Add(header);
        }


    }
}
