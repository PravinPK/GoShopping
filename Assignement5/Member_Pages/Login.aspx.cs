using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignement5.Member_Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_SignIn_Click(object sender, EventArgs e)
        {
            SignIndiv.Visible = true;
            registexrDiv.Visible = false;
            AdminDiv.Visible = false;
        }

        protected void btn_Register_Click(object sender, EventArgs e)
        {
            registexrDiv.Visible = true;
            SignIndiv.Visible = false;
            AdminDiv.Visible = false;

        }

        protected void btn_Admin_Click(object sender, EventArgs e)
        {
            AdminDiv.Visible = true;
            SignIndiv.Visible = false;
            registexrDiv.Visible = false;

        }
    }
}