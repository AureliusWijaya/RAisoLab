using RAisoLab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAisoLab.Views.Admin
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int UserId = Convert.ToInt32(Session["UserId"]);


            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();
            String username = UsernameBox.Text;
            String phone = PhoneBox.Text;
            String address = AddressBox.Text;
            DateTime dob = DOBCalendar.SelectedDate;
            String gender = "";
            if (MaleButton.Checked)
            {
                gender = "Male";
            }
            else if (FemaleButton.Checked)
            {
                gender = "Female";
            }
            String password = PasswordBox.Text;

            String response = controller.doRegister(username, gender, dob, phone, address, password);
            if (response == "Success")
            {
                Response.Redirect("~/Views/Admin/HomePage.aspx?");
            }
            else
            {
                ErrorLabel.Text = response;
            }
        }
    }
}