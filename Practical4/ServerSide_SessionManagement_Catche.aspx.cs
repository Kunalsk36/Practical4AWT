﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical4
{
    public partial class ServerSide_SessionManagement_Catche : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Cache["FirstName"] = txtFirstName.Text;
            Cache["LastName"] = txtLastName.Text;

            Response.Redirect("ServerSide_SessionManagement_Catche2.aspx");
        }
    }
}