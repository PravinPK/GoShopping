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
    public partial class StaffPage : System.Web.UI.Page
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