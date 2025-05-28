using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical4
{
    public partial class SessionMgmt_ViewState : System.Web.UI.Page
    {
        int counter;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                counter = 1;
            }
            else
            {
                counter = (int)ViewState["Counter"];
                counter++;
            }

            ViewState["Counter"] = counter;
            lblCounter.Text = "Counter : " + ViewState["Counter"];
        }
    }
}