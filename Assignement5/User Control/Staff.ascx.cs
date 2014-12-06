using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;
using Assignement5.Classes;
namespace Assignement5.User_Control
{
    public partial class Staff : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_Login_Click(object sender, EventArgs e)
        {

            try
            {
                if (AD_username.Text == "" || AD_pass.Text == "")
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
                            if (user.ChildNodes[0].InnerText == AD_username.Text && user.ChildNodes[1].InnerText == Library_hash_Encrypt.Hashing.HashPassword(AD_pass.Text) && user.LastChild.InnerText=="Staff")
                            {
                                Users newUser = new Users(user.ChildNodes[0].InnerText, user.ChildNodes[1].InnerText, user.ChildNodes[2].InnerText, user.ChildNodes[3].InnerText, user.ChildNodes[4].InnerText, user.ChildNodes[5].InnerText, user.ChildNodes[6].InnerText, user.ChildNodes[7].InnerText);
                                string catalogKey = "Users" + user.ChildNodes[0].InnerText; // Form the index key for next session spot
                                Session[catalogKey] = newUser; // Add an object into session stat
                                LG_result.Text = "Authentication Success";
                                LG_result.ForeColor = System.Drawing.Color.Green;
                                HttpCookie storeCookies = new HttpCookie("BestBuyCookies");
                                storeCookies["Name"] = AD_pass.Text;
                                storeCookies.Expires = DateTime.Now.AddMonths(6);
                                Response.Cookies.Add(storeCookies);
                                Response.Redirect("~/Member_Pages/StaffPage.aspx");
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