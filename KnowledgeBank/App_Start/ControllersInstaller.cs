using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using KnowledgeBank.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace KnowledgeBank.App_Start
{
    public class ControllersInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            # region controllers
            container.Register(Classes.FromThisAssembly()
                .BasedOn(typeof(Controller))
                .LifestyleTransient());
            container.Register(Classes.FromThisAssembly()
                .BasedOn(typeof(ApiController))
                .LifestyleTransient());
            #endregion

            #region Repositories

            container.Register(Component
            .For<IKBRespository>()
            .ImplementedBy<KBRespository>()
            .LifeStyle.Transient);

            #endregion


            #region Factories
            /*
            container.Register(Component
            .For<IListingFactory>()
            .ImplementedBy<ListingFactory>()
            .LifeStyle.Transient);
            */

            #endregion
        }
    }
}