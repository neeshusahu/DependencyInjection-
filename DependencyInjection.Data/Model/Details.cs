using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DependencyInjection.Data.Model
{
  public  class Details
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DependencyInjection.Domain.Model.Details ToDomainDetails()
        {
            return new Domain.Model.Details
            {
                id = this.Id,
                FirstName = this.FirstName,
                LastName = this.LastName
            };
        }
    }


  
}
