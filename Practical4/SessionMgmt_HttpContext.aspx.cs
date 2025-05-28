using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical4
{
    public partial class SessionMgmt_HttpContext : System.Web.UI.Page
    {

        HttpContext context = HttpContext.Current;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStore_Click(object sender, EventArgs e)
        {
            context.Session["UserName"] = txtName.Text;
            txtName.Text = "";
        }

        protected void btnRetrive_Click(object sender, EventArgs e)
        {
            txtName.Text = (string)(context.Session["UserName"]);
        }
    }
}