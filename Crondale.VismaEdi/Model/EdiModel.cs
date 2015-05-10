using Crondale.VismaEdi.Attributes;
using Crondale.VismaEdi.File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Crondale.VismaEdi.Model
{
    public class EdiModel
    {

        public EdiRow ToEdiRow()
        {
            EdiRow row = new EdiRow();

            foreach (PropertyInfo p in this.GetType().GetProperties())
            {
                if (p.PropertyType != typeof(String))
                    continue;

                var value = p.GetValue(this);

                if (value != null)
                {
                    row[p.Name] = value.ToString();
                }
            }

            return row;
        }

        public static EdiTable EdiTableFor<T>() where T:EdiModel
        {
            String name = typeof(T).Name;
            bool identifyByFirst = false;

            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(typeof(T));

            EdiElementAttribute ediElementAttr = attrs
                .Where(x => x is EdiElementAttribute)
                .Select(x => x as EdiElementAttribute)
                .FirstOrDefault();


            if (ediElementAttr != null)
            {
                if (ediElementAttr.Name != null)
                    name = ediElementAttr.Name;

                identifyByFirst = ediElementAttr.IdentifyByFirst;
            }
            

            EdiTable table = new EdiTable(name);
            table.ImportMethod = identifyByFirst ? 1 : 3;

            foreach (PropertyInfo p in typeof(T).GetProperties())
            {
                if (p.PropertyType != typeof(String))
                    continue;

                table.AddHeader(p.Name);
            }

            return table;
        }

    }
}
