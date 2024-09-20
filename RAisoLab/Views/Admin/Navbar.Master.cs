using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAisoLab.Views.Admin
{
    public partial class Navbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/HomePage.aspx");
        }

        protected void TransactionButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/TransactionReport.aspx");
        }

        protected void UpdateProfileButton_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Session["UserId"]);
            Response.Redirect("~/Views/Admin/UpdateProfile.aspx?id=" + userId);
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();

            if (Request.Cookies["user_cookie"] != null)
            {
                HttpCookie cookie = new HttpCookie("user_cookie");
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
            }

            Response.Redirect("~/Views/Guest/LoginPage.aspx");
        }
    }
}