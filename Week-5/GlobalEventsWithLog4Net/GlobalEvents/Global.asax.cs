using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace GlobalEvents
{
    public class Global : HttpApplication
    {
        readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
     
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            log4net.Config.XmlConfigurator.Configure();
            
            logger.Info("Application Started");
        
        }

        void Application_Error(object sender, EventArgs e)
        {
            logger.Info("Error in Application");
        }

        void Session_Start(object sender, EventArgs e)
        {
            logger.Info("New Session Started");
        }

        void Session_End(object sender, EventArgs e)
        {

            logger.Info("Session Ended");
        }
    }
}