using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical4
{
    public partial class SS_SessionStateDemo01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSetSessionState_Click(object sender, EventArgs e)
        {
            Session["FirstName"] = txtFirstName.Text;
            Session["LastName"] = txtLastName.Text;

            Response.Redirect("SS_SessionStateDemo02.aspx");
        }
    }
}