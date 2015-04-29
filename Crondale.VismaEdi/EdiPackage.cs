using Crondale.VismaEdi.File;
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

        private List<Actor> actors = new List<Actor>();

        private List<Order> orders = new List<Order>();

        String firmId;

        public EdiPackage(String firmId)
        {
            this.firmId = firmId;
        }

        public void Add(Actor actor)
        {
            actors.Add(actor);
        }

        public void Add(Order order)
        {
            orders.Add(order);
        }

        public EdiFile ToEdiFile()
        {
            EdiFile result = new EdiFile(firmId);
            EdiTable actorsTable = EdiModel.EdiTableFor<Actor>();

            foreach (Actor actor in actors)
            {
                actorsTable.Add(actor.ToEdiRow());
            }

            result.Add(actorsTable);

            foreach (Order order in orders)
            {
                EdiTable orderTable = EdiModel.EdiTableFor<Order>();
                orderTable.Add(order.ToEdiRow());
                result.Add(orderTable);

                EdiTable orderLineTable = EdiModel.EdiTableFor<OrderLine>();

                foreach (OrderLine orderline in order.OrderLines)
                {
                    orderLineTable.Add(orderline.ToEdiRow());
                }

                result.Add(orderLineTable);
            }

            result.RemoveUnusedFields();

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
