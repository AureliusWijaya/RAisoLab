using RAisoLab.Controller;
using RAisoLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAisoLab.Views.Admin
{
    public partial class StationeryDetail : System.Web.UI.Page
    {
        StationeryController controller = new StationeryController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["StationeryId"]);

                MsStationery stationery = controller.getStationeryById(id);

                NameLabel.Text = stationery.StationeryName;
                PriceLabel.Text = stationery.StationeryPrice.ToString();
            }
        }
    }
}