using RAisoLab.Controller;
using RAisoLab.Models;
using RAisoLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAisoLab.Views.Customer
{
    public partial class TransactionHistory : System.Web.UI.Page

    {
        TransactionController transactionController = new TransactionController();
        protected void Page_Load(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Session["UserId"]);

            if (userId == 0)
            {
                Response.Redirect("~/Views/Guest/LoginPage.aspx");
            }
            else
            {
                refreshTable();
            }
        }


        protected void TransactionGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = TransactionGrid.Rows[rowIndex];
                int id = int.Parse(row.Cells[0].Text);
                Response.Redirect("~/Views/Customer/TransactionDetail.aspx?id=" + id);
            }
        }


        protected void refreshTable()
        {
            int userId = Convert.ToInt32(Session["UserId"]);
            List<TransactionHeader> transactionHeaders = transactionController.getUserTransactions(userId);

            TransactionGrid.DataSource = transactionHeaders;
            TransactionGrid.DataBind();
        }

        protected void TransactionGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Session["UserId"]);
            GridViewRow selectedRow = TransactionGrid.SelectedRow; 
            String transactionId = selectedRow.Cells[0].Text;
            Response.Redirect("~/Views/Customer/TransactionDetailsPage.aspx?transactionId=" + transactionId);
        }
    }
}