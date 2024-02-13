using System;

namespace LoginForm
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["LOGIN"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                string username = Request.Cookies["LOGIN"]["username"];

                lblWelcomeMessage.Text = "Benvenuto, " + username + "!";
            }
        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["LOGIN"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("Login.aspx");
        }
    }
}
