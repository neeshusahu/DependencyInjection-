using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DependencyInjection.Data.Context;
using DependencyInjection.Domain.Repository;
using DependencyInjection.Data.Model;
using System.Collections;
using Newtonsoft.Json;
using DependencyInjection.Service.Context;
using StackExchange.Redis;

namespace DependencyInjection.Data.Repository
{
    class AzureSQLRepository : IRepository
    {
        IDatabase cache = Caching.Connection.GetDatabase();
        public void CreateDetails(Domain.Model.Details d)
        {
            using (DetailsContext context = new DetailsContext())
            {
               Details p=new Details()
                {
                    Id= d.id,
                    FirstName= d.FirstName,
                    LastName= d.LastName

                };
                context.people.Add(p);
                context.SaveChanges();

            }

        }
        public IEnumerable<Domain.Model.Details> GetAllDetails()
        {
            IList<Details> d;
            var cachedDetails=cache.StringGet("Details");
            if (!string.IsNullOrEmpty(cachedDetails))
            {
                d = JsonConvert.DeserializeObject<List<Details>>(cachedDetails);
            }
            else
            {
                using (DetailsContext context = new DetailsContext())
                {
                    d = context.people.ToList<Details>();
                }
                cache.StringSet("Details", JsonConvert.SerializeObject(d));
            }

            var p = from q in d
                    select q.ToDomainDetails();
            return p.ToList();
        

             
            }
        }
    }



