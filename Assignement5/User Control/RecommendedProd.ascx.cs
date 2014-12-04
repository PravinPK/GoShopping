using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignement5.User_Control
{
    public partial class RecommendedProd : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RecommendedService.RecommendServiceClient myClient = new RecommendedService.RecommendServiceClient();
            RecommendedService.Product[] products = myClient.GetProducts();
            if (products != null)
            {
                populateTable(products);
            }
            else
            {
                NoProductsLabel.Text = "<b><i>No products available!! Oh, wait!! check your internet connection</i></b>";
            }
        }

        public void populateTable(RecommendedService.Product[] products)
        {
            if (products != null && products.Length > 0)
            {
                TableRow tRow = new TableRow();
                TableCell tCellH0 = new TableCell();
                tCellH0.Text = "<b>Image</b>";
                tRow.Cells.Add(tCellH0);
                TableCell tCellH1 = new TableCell();
                tCellH1.Text = "<b>Product</b>";
                tRow.Cells.Add(tCellH1);
                TableCell tCellH2 = new TableCell();
                tCellH2.Text = "<b>Description</b>";
                tRow.Cells.Add(tCellH2);
                TableCell tCellH3 = new TableCell();
                tCellH3.Text = "<b>Sale Price</b>";
                tRow.Cells.Add(tCellH3);
                TableCell tCellH4 = new TableCell();
                tCellH4.Text = "<b>Product Link</b>";
                tRow.Cells.Add(tCellH4);
                Table1.Rows.Add(tRow);

                for (int i = 0; i < products.Length; i++)
                {
                    TableRow tRow1 = new TableRow();
                    TableCell tCell0 = new TableCell();
                    tCell0.Text = string.Format("<img src='{0}' />", products[i].image);
                    tRow1.Cells.Add(tCell0);
                    TableCell tCell1 = new TableCell();
                    tCell1.Text = products[i].name;
                    tRow1.Cells.Add(tCell1);
                    TableCell tCell2 = new TableCell();
                    tCell2.Text = products[i].shortDescription;
                    // if no description available
                    if (String.IsNullOrEmpty(products[i].shortDescription))
                    {
                        tCell2.Text = "No Description Available";
                    }
                    tRow1.Cells.Add(tCell2);
                    TableCell tCell3 = new TableCell();
                    tCell3.Text = "$" + products[i].salePrice.ToString();
                    tRow1.Cells.Add(tCell3);
                    TableCell tCell4 = new TableCell();
                    System.Web.UI.WebControls.HyperLink h = new HyperLink();
                    h.Text = "Land on Product";
                    h.Target = "_blank";
                    h.NavigateUrl = products[i].url;
                    tCell4.Controls.Add(h);
                    tRow1.Cells.Add(tCell4);
                    Table1.Rows.Add(tRow1);
                }

            }
        }
    }
}