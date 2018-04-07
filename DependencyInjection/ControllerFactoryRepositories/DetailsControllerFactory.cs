using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DependencyInjection.Controllers;
using DependencyInjection.Domain.Repository;
using System.Web.Mvc;
using System.Web.Routing;

namespace DependencyInjection.ControllerFactoryRepositories
{
    public class DetailsControllerFactory:DefaultControllerFactory
    {
        private readonly Dictionary<string,Func<RequestContext,IController>>_controllerMap;
        public DetailsControllerFactory(IRepository repository)
        {
            if(repository==null)
            {
                throw new ArgumentNullException();
            }
            this._controllerMap = new Dictionary<string, Func<RequestContext, IController>>();
            this._controllerMap["Home"] = context => new HomeController();
            this._controllerMap["Details"] = context => new DetailsController(repository);
        }
        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            if(this._controllerMap.ContainsKey(controllerName))
            {
                return this._controllerMap[controllerName](requestContext);
            }
            else
            {
                return null;
            }
        }

    }
}