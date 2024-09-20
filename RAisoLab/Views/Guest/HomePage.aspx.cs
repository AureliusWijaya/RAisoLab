using RAisoLab.Controller;
using RAisoLab.Models;
using RAisoLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAisoLab.Views.Guest
{
    public partial class HomePage : System.Web.UI.Page
    {
        StationeryController stationeryController = new StationeryController();
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshTable();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = StationeryGrid.SelectedIndex;
            int id = (int)StationeryGrid.DataKeys[selectedIndex].Value;
            Response.Redirect("~/Views/Guest/StationeryDetail.aspx?id=" + id);
        }

        protected void refreshTable()
        {
            List<MsStationery> stationery = stationeryController.getAllStationery();

            StationeryGrid.DataSource = stationery;
            StationeryGrid.DataBind();
        }
    }
}