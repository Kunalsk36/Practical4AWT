using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical4
{
    public partial class SS_SessionStateDemo02 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Session.RemoveAll();
            if (!IsPostBack)
            {
                
                if(Session["FirstName"] != null && Session["LastName"] != null)
                {
                    lblFirstName.Text = Session["FirstName"].ToString();
                    lblLastName.Text = Session["LastName"].ToString();
                }
                else
                {
                    lblFirstName.Text = "Value for FirstName key is not set!";
                    lblLastName.Text = "Vale for LastName key is not set!";
                }
            }
        }
    }
}