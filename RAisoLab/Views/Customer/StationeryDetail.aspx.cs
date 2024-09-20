using RAisoLab.Controller;
using RAisoLab.Handler;
using RAisoLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAisoLab.Views.Customer
{
    public partial class StationeryDetail : System.Web.UI.Page
    {
        CartController cartController = new CartController();
        StationeryController stationeryController = new StationeryController();
        CartHandler cartHandler = new CartHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["StationeryId"]);

                MsStationery stationery = stationeryController.getStationeryById(id);

                NameLabel.Text = stationery.StationeryName;
                PriceLabel.Text = stationery.StationeryPrice.ToString();
            }
        }

        protected void AddToCart_Click(object sender, EventArgs e)
        {
            int stationeryId = int.Parse(Request.QueryString["StationeryId"]);
            MsStationery temp = stationeryController.getStationeryById(stationeryId);
            int quantity = int.Parse(QuantityBox.Text);
            int UserId = Convert.ToInt32(Session["UserId"]);
            List<Cart> cartCheck = cartController.getCarts(UserId);
            foreach (Cart cart in cartCheck)
            {
                if(cart.StationeryID == stationeryId)
                {
                    ErrorLabel.Text = "Stationery already exists in cart";
                    return;
                }
            }

            cartController.addToCart(UserId, stationeryId, quantity);
            Response.Redirect("~/Views/Customer/HomePage.aspx?id=" + UserId);
        }
    }
}