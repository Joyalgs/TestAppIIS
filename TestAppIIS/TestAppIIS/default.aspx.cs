using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Principal;

namespace TestAppIIS
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            resWrite("GetCurrent user: ");
            resWrite(WindowsIdentity.GetCurrent().Name + "<br>");

            resWrite("User IsAuthenticated : ");
            resWrite(User.Identity.IsAuthenticated.ToString() + "<br>");

            resWrite("User AuthenticationType : ");
            resWrite(User.Identity.AuthenticationType.ToString() + "<br>");

            resWrite("User Name : ");
            resWrite(User.Identity.Name.ToString() + "<br>");

        }

        private void resWrite(string msg)
        {
            Response.Write(msg + "<br>");
        }
    }
}