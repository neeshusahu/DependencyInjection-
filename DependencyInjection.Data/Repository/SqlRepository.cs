//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using DependencyInjection.Domain.Repository;
//using DependencyInjection.Data.Context;
//using DependencyInjection.Data.Model;
//using DependencyInjection.Service.Context;

//namespace DependencyInjection.Data.Repository
//{
//    class SqlRepository : IRepository
//    {
//        public void CreateDetails(Domain.Model.Details d)
//        {
//            using (detailsEntities context = new detailsEntities())
//            {
//                Person p = new Person()
//                {
//                    id = d.id,
//                    firstName = d.FirstName,
//                    lastName = d.LastName

//                };
//                context.People.Add(p);
//                context.SaveChanges();

//            }

//        }
//        public IEnumerable<Domain.Model.Details> GetAllDetails()
//        {
//            using (detailsEntities context = new detailsEntities())
//            {
//                IList<Details> d = new List<Details>();

//                var query = context.People.ToList();
//                foreach (var q in query)
//                {
//                    d.Add(q);
//                }
//                var p = from detail in d
//                        select detail.ToDomainDetails();
//                return p.ToList();
//            }
//        }
//    }
//}
//}
