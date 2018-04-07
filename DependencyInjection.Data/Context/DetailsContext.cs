using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DependencyInjection.Data.Model;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DependencyInjection.Data.Context
{
    public partial class DetailsContext:DbContext
    { 
      public DetailsContext():base("DetailsContext")
        {
    }

    public DbSet<Details> people { get;set; }
   

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }
}
}
