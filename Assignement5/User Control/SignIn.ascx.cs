using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
namespace Assignement5.User_Control
{
    public partial class SignIn : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (LG_username.Text == "" || LG_pass.Text == "")
                {
                    LG_result.Text = "Please enter required values";
                    LG_result.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                   string fLocation = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\Users.xml");
                    if (File.Exists(fLocation))
                    {
                        XmlDocument Usersdoc = new XmlDocument();
                    Usersdoc.Load(fLocation);
                    XmlNodeList Userlist = Usersdoc.GetElementsByTagName("User");
                    foreach (XmlNode user in Userlist)
                    {
                        if (user.ChildNodes[0].InnerText == LG_username.Text && user.ChildNodes[1].InnerText == Library_hash_Encrypt.Hashing.HashPassword(LG_pass.Text))
                       {
                           LG_result.Text = "Authentication Success";
                           LG_result.ForeColor = System.Drawing.Color.Green;
                           HttpCookie storeCookies = new HttpCookie("BestBuyCookies");
                           storeCookies["Name"] = LG_username.Text;
                           storeCookies.Expires = DateTime.Now.AddMonths(6);
                           Response.Cookies.Add(storeCookies);
                           Response.Redirect("~/Member_Pages/ProductSelection.aspx");
                       }
                      }
                            LG_result.Text = "Incorrect UserName or Password";
                            LG_result.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            catch
            {
                LG_result.Text = "Connection Problem not Logged in";
                LG_result.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}