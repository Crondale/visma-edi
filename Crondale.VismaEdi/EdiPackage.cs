using Crondale.VismaEdi.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crondale.VismaEdi
{
    public class EdiPackage
    {

        String firmId;

        private Dictionary<String, EdiModelCollection> elements = new Dictionary<String, EdiModelCollection>();


        public EdiPackage(String firmId)
        {
            this.firmId = firmId;
        }


        private List<EdiModelCollection> sortedElements()
        {
            List<EdiModelCollection> result = new List<EdiModelCollection>(elements.Values);
            result.Sort();

            return result;
        }

        public void Add(EdiModel model)
        {
            Type t = model.GetType();

            if(! elements.ContainsKey(t.Name))
            {
                elements[t.Name] = new EdiModelCollection(t);
            }

            elements[t.Name].Add(model);
        }

        public EdiFile ToEdiFile()
        {
            EdiFile result = new EdiFile(firmId);

            foreach (EdiModelCollection collection in sortedElements())
            {
                result.Add(collection.ToEdiSet());
            }

            return result;
        }

        public void SaveTo(String path)
        {
            ToEdiFile().Save(path);
        }

        public void SaveTo(Stream stream)
        {
            ToEdiFile().SaveToStream(stream);
        }



    }
}
