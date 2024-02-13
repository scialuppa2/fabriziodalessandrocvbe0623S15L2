using System;
using System.Web;

namespace LoginForm
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["LOGIN"] != null)
                {
                    Response.Redirect("Welcome.aspx");
                }
            }
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            HttpCookie mycookie = new HttpCookie("LOGIN");
            mycookie.Values["username"] = txtUsername.Text;
            mycookie.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Add(mycookie);
            Response.Redirect("Welcome.aspx");
        }

    }
}
