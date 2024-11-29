using System;

namespace USP.TestApp.Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Code for page load
        }

        protected void btnClickMe_Click(object sender, EventArgs e)
        {
            // Button click logic
            Response.Write("Button clicked!");
        }
    }
}