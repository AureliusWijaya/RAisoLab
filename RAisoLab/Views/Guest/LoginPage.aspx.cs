using RAisoLab.Controller;
using RAisoLab.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAisoLab.Views.Guest
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();
            String username = UsernameBox.Text;
            String password = PasswordBox.Text;
            bool isRemember = RememberCheck.Checked;

            MsUser user = controller.doLogin(username, password);
            if(user == null)
            {
                ErrorLabel.Text = "No account found!";
            } else
            {
                int id = user.UserID;
                Session["UserId"] = id;
                if (isRemember)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = id.ToString();
                    cookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(cookie);
                }
                if (user.UserRole == "Customer")
                {
                    Response.Redirect("~/Views/Customer/HomePage.aspx?id=" + id);
                } else if(user.UserRole == "Admin")
                {
                    Response.Redirect("~/Views/Admin/HomePage.aspx?id=" + id);
                }
            }
        }
    }
}