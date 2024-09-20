using RAisoLab.Controller;
using RAisoLab.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAisoLab.Views.Customer
{
    public partial class CartPage : System.Web.UI.Page
    {
        CartController cartController = new CartController();
        StationeryController stationeryController = new StationeryController();
        TransactionController transactionController = new TransactionController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int userId = Convert.ToInt32(Session["UserId"]);
                LoadCarts(userId);
            }
        }

        protected void OrderButton_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Session["UserId"]);
            List<Cart> temp = cartController.getCarts(userId);
            if(temp == null || !temp.Any())
            {
                ErrorLabel.Text = "Cart still empty!";
                return;
            }
            processOrder(userId);
        }

        protected void processOrder(int userId)
        {
            DateTime transactionDate = DateTime.Now;
            TransactionHeader newHeader = transactionController.CreateTransactionHeader(userId, transactionDate);
            foreach (GridViewRow row in CartGrid.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    string stationeryName = row.Cells[0].Text;
                    MsStationery stationery = stationeryController.getStationeryByName(stationeryName);
                    int price = Convert.ToInt32(row.Cells[1].Text);
                    int quantity = Convert.ToInt32(row.Cells[2].Text);
                    cartController.removeCart(userId, stationery.StationeryID);

                    transactionController.CreateTransactionDetail(newHeader.TransactionID, stationery.StationeryID, quantity);
                }
            }
            LoadCarts(userId);
        }

        protected void LoadCarts(int userId)
        {
            var cartItems = cartController.getCarts(userId);

            CartGrid.DataSource = cartItems;
            CartGrid.DataBind();
        }

        protected void CartGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int rowIndex = e.RowIndex;
            GridViewRow row = CartGrid.Rows[rowIndex];
            string stationeryName = row.Cells[0].Text;
            int UserId = Convert.ToInt32(Session["UserId"]);
            MsStationery stationery = stationeryController.getStationeryByName(stationeryName);
            String response = cartController.removeCart(UserId, stationery.StationeryID);
            if(response == "Success")
            {
                Response.Redirect("~/Views/Customer/CartPage.aspx?id=" + UserId);
            }
        }

        protected void CartGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow selectedRow = CartGrid.SelectedRow;
            string stationeryName = selectedRow.Cells[0].Text;
            int UserId = Convert.ToInt32(Session["UserId"]);
            MsStationery stationery = stationeryController.getStationeryByName(stationeryName);
            Response.Redirect("~/Views/Customer/UpdateCart.aspx?UserId=" + UserId + "&StationeryId=" + stationery.StationeryID);
        }
    }
}