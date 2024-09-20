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
    public partial class TransactionDetails : System.Web.UI.Page
    {
        TransactionController transactionController = new TransactionController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refreshTable();
            }
        }

        protected void refreshTable()
        {
            int id = int.Parse(Request.QueryString["transactionId"]);
            List <TransactionDetail> td = transactionController.GetTransactionDetail(id);

            DetailGrid.DataSource = td;
            DetailGrid.DataBind();
        }
    }
}