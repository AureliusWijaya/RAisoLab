using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAisoLab.Views.Customer
{
    public partial class Navbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/HomePage.aspx");
        }

        protected void CartButton_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Session["UserId"]);
            Response.Redirect("~/Views/Customer/CartPage.aspx?id=" + userId);
        }

        protected void TransactionButton_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Session["UserId"]);
            Response.Redirect("~/Views/Customer/TransactionHistory.aspx?id=" + userId);
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Session["UserId"]);
            Response.Redirect("~/Views/Customer/UpdateProfile.aspx?id=" + userId);
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