using RAisoLab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAisoLab.Views.Admin
{
    public partial class UpdateStationery : System.Web.UI.Page
    {
        StationeryController stationeryController = new StationeryController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"]);
            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            String name = NameBox.Text;
            int price = int.Parse(PriceBox.Text);
            String response = stationeryController.updateStationery(id, name, price);

            if(response == "Success")
            {
                Response.Redirect("~/Views/Admin/HomePage.aspx");
            } else
            {
                ErrorLabel.Text = response;
            }
        }
    }
}