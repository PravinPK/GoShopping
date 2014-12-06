using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignement5.User_Control
{
    public partial class Admin : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            if(AD_username.Text=="TA" && AD_pass.Text==@"CSE44558ta!") 
            Response.Redirect("~/Member_Pages/AdminMoniter.aspx");
            else
            {
                LG_result.Text = "Invalid AdminID/Password";
                LG_result.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}