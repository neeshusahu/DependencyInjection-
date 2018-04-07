using DependencyInjection.Service.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DependencyInjection.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void CreateDetails(Domain.Model.Details d)
        {
            using (detailsEntities context = new detailsEntities())
            {
                Person p = new Person()
                {
                    id = d.id,
                    firstName = d.FirstName,
                    lastName = d.LastName

                };
                context.People.Add(p);
                context.SaveChanges();

            }
        }
    }
}
