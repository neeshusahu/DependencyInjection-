using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjection.ControllerFactoryRepositories
{
    public class CompositionRoot
    {
        private readonly IControllerFactory controllerFactory;
        public CompositionRoot()
        {
            this.controllerFactory = CompositionRoot.CreateControllerFactory();

        }
        public IControllerFactory ControllerFactory
        {
            get
            {
                return controllerFactory;
            }
        }

        public static IControllerFactory CreateControllerFactory()
        {
            string repositorytypeName = ConfigurationManager.AppSettings["AzureRepositoryType"];
            var repositoryType = Type.GetType(repositorytypeName, true);
            var repository = (Domain.Repository.IRepository)Activator.CreateInstance(repositoryType);
            var controllerFactory = new DetailsControllerFactory(repository);
            return controllerFactory;
        }
    }
}