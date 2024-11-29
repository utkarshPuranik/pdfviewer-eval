using System;

namespace USP.TestApp.Web
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
        }

        protected void Application_End(object sender, EventArgs e)
        {
            // Code that runs on application shutdown
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session starts
        }

        protected void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends.
            // Note: Session_End is raised only when the session state mode
            // is InProc. It is not raised for StateServer or SQLServer modes.
        }
    }
}
