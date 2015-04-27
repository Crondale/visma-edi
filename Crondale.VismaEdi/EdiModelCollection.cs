using Crondale.VismaEdi.Attributes;
using Crondale.VismaEdi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Crondale.VismaEdi
{

    class EdiModelCollection : List<EdiModel>
    {

        public int Priority { get; set; }

        public string Name { get; set; }

        private Type type = null;

        public EdiModelCollection(Type type)
        {
            Name = type.Name;
            Priority = 50;

            this.type = type;

            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(type);

            EdiElementAttribute ediElementAttr = attrs
                .Where(x => x is EdiElementAttribute)
                .Select(x => x as EdiElementAttribute)
                .FirstOrDefault();


            if (ediElementAttr != null)
                Priority = ediElementAttr.Priority;

        }


        public EdiSet ToEdiSet()
        {
            EdiSet ediSet = new EdiSet(Name, Priority);

            foreach (EdiModel item in this)
            {
                EdiRow row = new EdiRow();

                foreach(PropertyInfo p in type.GetProperties())
                {
                    var value = p.GetValue(item);

                    if(value != null)
                    {
                        row[p.Name] = value.ToString();
                    }
                }

                ediSet.Add(row);
            }

            return ediSet;
        }


    }
}
