using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical4
{
    public partial class ServerSide_SessionManagement_Catche2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblFirstName.Text = Cache["FirstName"].ToString();
                lblLastName.Text = Cache["LastName"].ToString();
            }
            else
            {
                lblFirstName.Text = "Cache for FirstName Key is not Set!";
                lblLastName.Text = "Cache for FirstName Key is not Set!";
            }
        }
    }
}