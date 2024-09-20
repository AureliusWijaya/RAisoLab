using RAisoLab.Controller;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAisoLab.Views.Admin
{
    public partial class InsertStationery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            String name = NameBox.Text;
            int price = int.Parse(PriceBox.Text);

            StationeryController stationeryController = new StationeryController();
            String response = stationeryController.insertStationery(name, price);
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