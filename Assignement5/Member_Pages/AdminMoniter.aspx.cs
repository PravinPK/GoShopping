using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;
using System.Web.Hosting;
using System.IO;
using System.Xml.Xsl;
using Assignement5.Classes;

namespace Assignement5.Member_Pages
{
    public partial class AdminMoniter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String XmlUrl = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "Users.xml");
                XPathDocument doc = new XPathDocument(XmlUrl);
                XslCompiledTransform xslt = new XslCompiledTransform();
                String XslUrl = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "UserSchema.xslt");
                xslt.Load(XslUrl);
                StringWriter results = new StringWriter();
                xslt.Transform(doc, null, results);
                lblall.Text=results.ToString();

            }
            catch (Exception err)
            {
                lblall.Text =String.Format( "oops not loaded properly because {0}",err.Message);
            }
        }

        protected void AddUser_Click(object sender, EventArgs e)
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
                            if (user.FirstChild.InnerText == SU_username.Text)
                            {
                                SU_result.Text = "Staff Already Registered";
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
                        XmlElement Role = Usersdoc.CreateElement("Role");
                        UserName.InnerText = SU_username.Text;
                        Password.InnerText = secretPassword;
                        FirstName.InnerText = SU_firstname.Text;
                        Address.InnerText = SU_Address.Text;
                        City.InnerText = SU_City.Text;
                        PhoneNumber.InnerText = SU_phone.Text;
                        EmailID.InnerText = SU_EmailID.Text;
                        Role.InnerText = "Staff";
                        singleuser.AppendChild(UserName);
                        singleuser.AppendChild(Password);
                        singleuser.AppendChild(FirstName);
                        singleuser.AppendChild(Address);
                        singleuser.AppendChild(City);
                        singleuser.AppendChild(PhoneNumber);
                        singleuser.AppendChild(EmailID);
                        singleuser.AppendChild(Role);
                        rootnote.AppendChild(singleuser);
                        Usersdoc.Save(fLocation);
                        SU_result.Text = String.Format("Staff Member Saved");
                        SU_result.ForeColor = System.Drawing.Color.Green;

                    }

                }

            }
            catch (Exception err)
            {
                SU_result.Text = String.Format("{0}", err.Message);
                SU_result.ForeColor = System.Drawing.Color.Red;
            }
            try
            {
                String XmlUrl = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "Users.xml");
                XPathDocument doc = new XPathDocument(XmlUrl);
                XslCompiledTransform xslt = new XslCompiledTransform();
                String XslUrl = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "UserSchema.xslt");
                xslt.Load(XslUrl);
                StringWriter results = new StringWriter();
                xslt.Transform(doc, null, results);
                lblall.Text = results.ToString();

            }
            catch (Exception err)
            {
                lblall.Text = String.Format("oops not loaded properly because {0}", err.Message);
            }
        }

        protected void RemoveUser_Click(object sender, EventArgs e)
        {
            SU_result.Text = "";
            String delPath = String.Format("/Users/User[UserName='" + RemoveUserTxt.Text + "']");
            try
            {
                //String delPath = String.Format("/Users/User[UserName='a']");
                XmlDocument Usersdoc = new XmlDocument();
                string fLocation = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\Users.xml");
                Usersdoc.Load(fLocation);
                XmlNode node =Usersdoc.SelectSingleNode(delPath);
                 if (node != null)
                 {
                     node.ParentNode.RemoveChild(node);
                     Usersdoc.Save(fLocation);
                 }
                 else
                 {
                     RM_Result.Text = String.Format("No such UserName Exists");
                     RM_Result.ForeColor = System.Drawing.Color.Red;
                 }
            }
            catch (Exception err)
            {
                RM_Result.Text = String.Format("Cannot Delete");
                RM_Result.ForeColor = System.Drawing.Color.Red;
            }
            try
            {
                String XmlUrl = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "Users.xml");
                XPathDocument doc = new XPathDocument(XmlUrl);
                XslCompiledTransform xslt = new XslCompiledTransform();
                String XslUrl = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "UserSchema.xslt");
                xslt.Load(XslUrl);
                StringWriter results = new StringWriter();
                xslt.Transform(doc, null, results);
                lblall.Text = results.ToString();

            }
            catch (Exception err)
            {
                lblall.Text = String.Format("oops not loaded properly because {0}", err.Message);
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