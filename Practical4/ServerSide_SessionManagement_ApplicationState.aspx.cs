using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical4
{
    public partial class ServerSide_SessionManagement_ApplicationState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblVisitorsCount.Text = "Visitors Count: " + Application["SiteVisiterCounter"].ToString();
            lblOnlineVisitorsCount.Text = "Online Visitors Count: " + Application["OnlineUserCounter"].ToString();
        }

        protected void btnClearSession_Click(object sender, EventArgs e)
        {
            Session.Abandon();
        }
    }
}