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
    public partial class HomePage : System.Web.UI.Page
    {
        StationeryController stationeryController = new StationeryController();
        UserController userController = new UserController();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Session["UserId"]);

            if (Session["UserId"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/Views/Guest/LoginPage.aspx");
            } else
            {
                MsUser user;
                if (Session["UserId"] == null)
                {
                    int id = int.Parse(Request.Cookies["user_cookie"].Value);
                    user = userController.getUserById(id);
                    Session["UserId"] = user.UserID;
                } else
                {
                    int id = Convert.ToInt32(Session["UserId"]);
                    user = userController.getUserById(id);
                }
            }
            refreshTable();
        }

        protected void refreshTable()
        {
            List<MsStationery> stationery = stationeryController.getAllStationery();

            StationeryGrid.DataSource = stationery;
            StationeryGrid.DataBind();
        }

        protected void StationeryGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int UserId = Convert.ToInt32(Session["UserId"]);
            int selectedIndex = StationeryGrid.SelectedIndex;
            int stationeryId = (int)StationeryGrid.DataKeys[selectedIndex].Value;
            Response.Redirect("~/Views/Customer/StationeryDetail.aspx?UserId=" + UserId  + "&StationeryId=" + stationeryId);
        }
    }
}