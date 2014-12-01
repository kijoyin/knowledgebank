using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using KnowledgeBank.Lib.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnowledgeBank.App_Start
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssemblyContaining(typeof(KnowledgeBank.Lib.Service.IService))
                .BasedOn(typeof(IService))
                .WithService.AllInterfaces().LifestyleTransient());
                //.LifestylePerWebRequest());
        }
    }
}