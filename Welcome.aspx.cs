using System;

namespace LoginForm
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                string username = Request.Cookies["Username"].Value;
                lblWelcomeMessage.Text = "Benvenuto, " + username + "!";
            }
        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["Username"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("Login.aspx");
        }
    }
}
