using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical4
{
    public partial class SessionManagement_QueryString : System.Web.UI.Page
    {
        int cnt = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            cnt = Convert.ToInt32(Server.UrlDecode(Request.QueryString["count"]));
            if(cnt != 0)
            {
                cnt = cnt + 1;
            }
            else
            {
                cnt = 1;
            }
            lblCount.Text = Convert.ToString(cnt);
            lblMessage.Text = "Welcome! " + Request.QueryString["name"];
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("SessionManagement_QueryString.aspx?count=" + Server.UrlEncode(lblCount.Text) + "&&name=kunal");
        }
    }
}