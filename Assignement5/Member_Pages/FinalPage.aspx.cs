using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignement5.Classes;

namespace Assignement5.Member_Pages
{
    public partial class FinalPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String mode = (String)Session["BuyMode"];
            if(mode=="Online")
            {
                Label1.Text = "Thanks for Shopping Your Product will be shipped within 3 Buisness days";
            }
            else
            {
                Label1.Text = "Thanks for Shopping Your Product will be ready for Store Pickup Tommorow";
            }
        }

        protected void SignOutClick_Click(object sender, EventArgs e)
        {
            Users currentUser;
            HttpCookie storeCookies = Request.Cookies["BestBuyCookies"];
            if (Session.Count != 0)
            {
                if (!(storeCookies["Name"] == ""))
                {
                    string catalogKey = "Users" + storeCookies["Name"];
                    currentUser = (Users)Session[catalogKey];
                    if (currentUser != null)
                    {
                        Session["catalogKey"] = null;
                    }
                }
            }
            Session["cartproduct"] = null;
            Response.Redirect("~/Member_Pages/Login.aspx");
        }
    }
}



       
