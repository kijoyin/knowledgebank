using Castle.Windsor;
using KnowledgeBank.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace KnowledgeBank
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public IWindsorContainer Container { get; set; }

        protected void Application_Start()
        {
            this.Container = (IWindsorContainer)new WindsorContainer();

            this.Container.Install(new ServiceInstaller());
            this.Container.Install(new ControllersInstaller());
            var controllerFactory = new WindsorControllerFactory(this.Container.Kernel);
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator),new WindsorCompositionRoot(this.Container));
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
