using RAisoLab.Controller;
using RAisoLab.Dataset;
using RAisoLab.Handler;
using RAisoLab.Models;
using RAisoLab.Report;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAisoLab.Views.Admin
{
    public partial class TransactionsPage : System.Web.UI.Page
    {
        TransactionsHandler transactionHandler = new TransactionsHandler();
        StationeryController stationeryController = new StationeryController();

        protected void Page_Load(object sender, EventArgs e)
        {
            TransactionReport report = new TransactionReport();
            CrystalReportViewer1.ReportSource = report;
            DataSet1 data = getData(transactionHandler.getAllTransactions());
            report.SetDataSource(data);
        }

        private DataSet1 getData(List<TransactionHeader> transactionHeaders)
        {
            DataSet1 data = new DataSet1();
            var headertable = data.TransactionHeader;
            var detailtable = data.TransactionDetail;

            foreach(TransactionHeader th in transactionHeaders)
            {
                var hrow = headertable.NewRow();
                hrow["transaction_id"] = th.TransactionID;
                hrow["user_id"] = th.UserID; ;
                hrow["transaction_date"] = th.TransactionDate;
                headertable.Rows.Add(hrow);
                int grandtotal = 0;

                foreach(TransactionDetail td in th.TransactionDetails)
                {
                    int subtotal = 0;
                    var drow = detailtable.NewRow();
                    drow["transaction_id"] = td.TransactionID;
                    drow["stationery_id"] = td.StationeryID;
                    drow["quantity"] = td.Quantity;
                    MsStationery stationery = stationeryController.getStationeryById(td.StationeryID);
                    subtotal = td.Quantity * (stationery.StationeryPrice);
                    drow["sub_total"] = subtotal;
                    detailtable.Rows.Add(drow);
                    grandtotal += subtotal;
                }
                hrow["grand_total"] = grandtotal;
            }
            return data;
        }
    }
}