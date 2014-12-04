using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignement5.Classes;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Net;

namespace Assignement5.Member_Pages
{
    
    public partial class ProductSelection : System.Web.UI.Page
    {
        List<Product> productList;
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie storeCookies = Request.Cookies["BestBuyCookies"];
            if ((storeCookies == null) || (storeCookies["Name"] == ""))
            {
                Greeting.Text = "Welcome, new user";
            }
            else
            {
                Greeting.Text = "Welcome, " + storeCookies["Name"];
            }
        }

        protected void btnShowDetails_Click(object sender, EventArgs e)
        {
            panelshowUserDetails.Visible = !panelshowUserDetails.Visible;
            
            try
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
                            lblUserDetail.Text = currentUser._FirstName + "<br />" + currentUser._EmailID + "<br />" + currentUser._PhoneNumber + "<br />" + currentUser._Address + "<br />" + currentUser._City + "<br />" + currentUser._Password+ "<br />" ;
                        }
                    }
                }
                else
                {
                    lblUserDetail.Text = "Details Not Available";
                }
            }
            catch
            {
                lblUserDetail.Text = "Details Not Available";
            }
        }

        protected void btnProductSearch_Click(object sender, EventArgs e)
        {
            Uri baseUri = new Uri("http://webstrar17.fulton.asu.edu/Page5/ProductSearch.svc");



            decimal value; 

            if (TextBox1.Text == "")
            {
                Label1.Text = " <b>Input should not be empty!</b>";
            }

            else
            {
                Label1.Text = "";

                string text = TextBox1.Text;
                UriTemplate myTemplate = new UriTemplate("GetProductList/{searchItem}");
                Uri completeUri = myTemplate.BindByPosition(baseUri, text);
                WebClient channel = new WebClient();
                byte[] abc = channel.DownloadData(completeUri);
                Stream stream = new MemoryStream(abc);
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Product>));
                 productList = (List<Product>)serializer.ReadObject(stream);
                for (int i = 0; i < 5; i++)
                {

                    TableRow row1 = new TableRow();
                    Table1.Rows.Add(row1);
                    
                    TableCell cell = new TableCell();
                    row1.Cells.Add(cell);
                    cell.Text = string.Format("<img src='{0}' />", productList[i].image);

                    TableCell cell1 = new TableCell();
                    row1.Cells.Add(cell1);
                    cell1.Text = productList[i].name;

                    TableCell cell2 = new TableCell();
                    row1.Cells.Add(cell2);
                    cell2.Text = "$" + productList[i].salePrice.ToString();

                    TableCell cell3 = new TableCell();
                    System.Web.UI.WebControls.HyperLink hlink = new HyperLink();
                    hlink.Text = "Go to product page";
                    hlink.NavigateUrl = productList[i].url;
                    cell3.Controls.Add(hlink);
                    row1.Cells.Add(cell3);

                    //TableCell cell4 = new TableCell();
                    //System.Web.UI.WebControls.HyperLink hlink1 = new HyperLink();
                    //hlink1.Text = "Add to Cart";
                    //hlink1.NavigateUrl = "~/Member_Pages/StoreLocation.aspx";
                    //cell4.Controls.Add(hlink1);
                    //row1.Cells.Add(cell4);

                    Button newButton = new Button();
                    newButton.Text = "Add To Cart";
                    newButton.OnClientClick = "AddcartClient()";
                    newButton.Click += delegate(object sender2, EventArgs e2)
                        
                    {
                        Session["cartproduct"] = productList[i];
                        Response.Redirect("~/Member_Pages/StoreLocation.aspx");
                    };
                    TableCell tbcell = new TableCell();
                    tbcell.Controls.Add(newButton);
                    row1.Cells.Add(tbcell);

                    Button reviewbtn = new Button();
                    reviewbtn.Text = "Get Review";
                    reviewbtn.Click += delegate(object sender2, EventArgs e2)
                    {
                        Session["cartproduct"] = productList[i];
                        Response.Redirect("~/Member_Pages/StoreLocation.aspx");
                    };
                    TableCell tbcell2 = new TableCell();
                    tbcell2.Controls.Add(reviewbtn);
                    row1.Cells.Add(tbcell2);


                }
            }
        }

        protected void GotoStoreLocation_Click(object sender, EventArgs e)
        {
            Product sampleProd = new Product();
            sampleProd.name = "Acer";
            sampleProd.productId = 1722009;
            Session["cartproduct"] = sampleProd;
            Response.Redirect("~/Member_Pages/StoreLocation.aspx");
        }

        protected void SeeReview_Click(object sender, EventArgs e)
        {
            Product sampleProd = new Product();
            sampleProd.name = "Acer";
            sampleProd.productId = 1722009;
            Session["Reviewproduct"] = sampleProd;
            Response.Redirect("~/Member_Pages/ReviewPage.aspx");
        }

    }
}

    public class Product
    {
       
        public string name { get; set; }

       
        public string shortDescription { get; set; }

       
        public long productId { get; set; }

       
        public double regularPrice { get; set; }

       
        public double salePrice { get; set; }

      
        public string image { get; set; }

       
        public string url { get; set; }
    }