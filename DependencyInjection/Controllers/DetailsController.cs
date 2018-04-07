using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependencyInjection.Domain.Repository;

namespace DependencyInjection.Controllers
{
    public class DetailsController : Controller
    {
        // GET: Details
        private IRepository _repository;
        public DetailsController(IRepository repository)
        {
            _repository = repository;
        }
        [HttpPost]
        public ActionResult CreateDetails(Domain.Model.Details d)
        {
            _repository.CreateDetails(d);
            return View();
        }
        public PartialViewResult GetDetails()
        {


            return PartialView(_repository.GetAllDetails());
        }
    }
}