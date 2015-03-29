using System;

namespace Razin.Web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //Catch Exception in Global place
            var exc = Server.GetLastError();


            if (exc.GetType() == typeof(InvalidOperationException))
            {
                Server.Transfer("Exception.aspx");
            }

            // For other kinds of errors give the user some information
            // but stay on the default page
            Response.Flush();
            Response.Redirect("HttpErrorPage.aspx");

            // Clear the error from the server
            Server.ClearError();
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}