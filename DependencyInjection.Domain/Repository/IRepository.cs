using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DependencyInjection.Domain.Model;

namespace DependencyInjection.Domain.Repository
{
  public  interface IRepository
    {
        IEnumerable<Details> GetAllDetails();
        void CreateDetails( Details d);
        //Details ReadDetails(int id);
        //void UpdateDetails(Details d);
        //void DeleteDetails(int id);
    }
}
