using System;

namespace LoginForm
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["Username"] != null)
                {
                    Response.Redirect("Welcome.aspx");
                }
            }
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Response.Cookies["Username"].Value = txtUsername.Text;
            Response.Redirect("Welcome.aspx");
        }
    }
}
