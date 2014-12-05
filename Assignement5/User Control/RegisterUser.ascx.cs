using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignement5.Classes;
using Library_hash_Encrypt;
using System.IO;
using System.Xml;
namespace Assignement5.User_Control
{
    public partial class RegisterUser : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (SU_username.Text == "" || SU_pass.Text == "" || SU_repass.Text == "" || SU_firstname.Text == "" || SU_Address.Text == "" || SU_City.Text == "" || SU_phone.Text == "" || SU_EmailID.Text == "")
                {
                    if (!(SU_pass.Text == SU_repass.Text))
                    {
                        SU_result.Text = "Password Mismatch";
                        SU_result.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        SU_result.Text = "Please Enter all fields";
                        SU_result.ForeColor = System.Drawing.Color.Red;
                    }
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
                       if(user.FirstChild.InnerText==SU_username.Text)
                       {
                           SU_result.Text = "User Already Registered";
                           SU_result.ForeColor = System.Drawing.Color.Red;
                           return;
                       }
                    }

                    //var xmlNodeExistsXpath = String.Format("Users/User[UserName='{0}']", SU_username.Text);
                    //var CustNoExist = Usersdoc.XPathSelectElement(xmlNodeExistsXpath);

                    XmlNode rootnote = Usersdoc.SelectSingleNode("Users");
                    XmlElement singleuser = Usersdoc.CreateElement("User");
                    String secretPassword = Library_hash_Encrypt.Hashing.HashPassword(SU_pass.Text);
                    XmlElement UserName = Usersdoc.CreateElement("UserName");
                    XmlElement Password = Usersdoc.CreateElement("Password");
                    XmlElement FirstName = Usersdoc.CreateElement("FirstName");
                    XmlElement Address = Usersdoc.CreateElement("Address");
                    XmlElement City = Usersdoc.CreateElement("City");
                    XmlElement PhoneNumber = Usersdoc.CreateElement("PhoneNumber");
                    XmlElement EmailID = Usersdoc.CreateElement("Email");
                    XmlElement role = Usersdoc.CreateElement("Role");

                    UserName.InnerText = SU_username.Text;
                    Password.InnerText = secretPassword;
                    FirstName.InnerText = SU_firstname.Text;
                    Address.InnerText = SU_Address.Text;
                    City.InnerText = SU_City.Text;
                    PhoneNumber.InnerText = SU_phone.Text;
                    EmailID.InnerText = SU_EmailID.Text;
                    role.InnerText = "Member";
                    singleuser.AppendChild(UserName);
                    singleuser.AppendChild(Password);
                    singleuser.AppendChild(FirstName);
                    singleuser.AppendChild(Address);
                    singleuser.AppendChild(City);
                    singleuser.AppendChild(PhoneNumber);
                    singleuser.AppendChild(EmailID);
                    singleuser.AppendChild(role);
                    rootnote.AppendChild(singleuser);
                    Usersdoc.Save(fLocation);

                    Users newUser = new Users(SU_username.Text, secretPassword, SU_firstname.Text, SU_Address.Text, SU_City.Text, SU_phone.Text, SU_EmailID.Text,"Member");
                    string catalogKey = "Users" + SU_username.Text;  // Form the index key for next session spot
                    Session[catalogKey] = newUser; // Add an object into session state 
                    HttpCookie storeCookies = new HttpCookie("BestBuyCookies");
                    storeCookies["Name"] = SU_username.Text;
                    storeCookies.Expires = DateTime.Now.AddMonths(6);
                    Response.Cookies.Add(storeCookies);
                    Response.Redirect("~/Member_Pages/ProductSelection.aspx"); 

                }

               }

            }
            catch (Exception err)
            {   
                SU_result.Text = String.Format("{0}",err.Message);
                SU_result.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void SU_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}