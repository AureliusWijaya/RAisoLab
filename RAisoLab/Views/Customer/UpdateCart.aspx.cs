using RAisoLab.Controller;
using RAisoLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAisoLab.Views.Customer
{
    public partial class UpdateCart : System.Web.UI.Page
    {
        Cart cart = new Cart();
        CartController cartController = new CartController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["UserId"]);
            int stationeryId = int.Parse(Request.QueryString["StationeryId"]);
            int quantity = int.Parse(QuantityBox.Text);
            String response = cartController.updateCart(id, stationeryId, quantity);
            String userId = (Session["UserId"]).ToString();
            if (response == "Success")
            {
                Response.Redirect("~/Views/Customer/CartPage.aspx?id=" + userId);
            } else
            {
                ErrorLabel.Text = response;
            }
        }
    }
}