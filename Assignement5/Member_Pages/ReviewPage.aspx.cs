using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignement5.Member_Pages
{
    public partial class ReviewPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Product prod = (Product)Session["Reviewproduct"];

            ReviewServiceReference.ReviewServiceClient myClient = new ReviewServiceReference.ReviewServiceClient();
            string productID = prod.productId.ToString();
            if (String.IsNullOrEmpty(productID) || String.IsNullOrWhiteSpace(productID))
            {
                Label1.Text = "<b><i>Ahh!! You have not entered any Product Id!</i></b>";
            }
            else
            {
                ReviewServiceReference.Reviews allReviews = myClient.getReviews(productID);
                if (allReviews != null && allReviews.reviews != null && allReviews.reviews.Length > 0)
                {
                    ReviewServiceReference.Review[] reviews= allReviews.reviews;

                    TableRow tRow = new TableRow();
                    TableCell tCellH1 = new TableCell();
                    tCellH1.Text = "<b>Review number</b>";
                    tRow.Cells.Add(tCellH1);
                    TableCell tCellH2 = new TableCell();
                    tCellH2.Text = "<b>Product ID</b>";
                    tRow.Cells.Add(tCellH2);
                    TableCell tCellH3 = new TableCell();
                    tCellH3.Text = "<b>Rating</b>";
                    tRow.Cells.Add(tCellH3);
                    TableCell tCellH4 = new TableCell();
                    tCellH4.Text = "<b>Reviewer Name</b>";
                    tRow.Cells.Add(tCellH4);
                    TableCell tCellH5 = new TableCell();
                    tCellH5.Text = "<b>Comment</b>";
                    tRow.Cells.Add(tCellH5);
                    TableCell tCellH6 = new TableCell();
                    tCellH6.Text = "<b>Date of Submission</b>";
                    tRow.Cells.Add(tCellH6);
                    Table1.Rows.Add(tRow);

                    
                    int count = 1;

                    foreach (ReviewServiceReference.Review review in reviews)
                    {
                        TableRow tRow1 = new TableRow();
                        TableCell tCell1 = new TableCell();
                        tCell1.Text = "" + count++;
                        tRow1.Cells.Add(tCell1);
                        TableCell tCell2 = new TableCell();
                        tCell2.Text = "" + review.sku;
                        tRow1.Cells.Add(tCell2);
                        TableCell tCell3 = new TableCell();
                        tCell3.Text = "" + review.rating;
                        tRow1.Cells.Add(tCell3);
                        TableCell tCell4 = new TableCell();
                        if (review.reviewer != null && review.reviewer[0] != null)
                        {
                            tCell4.Text = review.reviewer[0].name;
                        }
                        tRow1.Cells.Add(tCell4);
                        TableCell tCell5 = new TableCell();
                        tCell5.Text = review.comment;
                        tRow1.Cells.Add(tCell5);
                        TableCell tCell6 = new TableCell();
                        tCell6.Text = review.submissionTime;
                        tRow1.Cells.Add(tCell6);
                        Table1.Rows.Add(tRow1);
                    }
                }
                else
                {
                    Label1.Text = "<b><i>No reviews are found!! Be the first reviewer and visit back!!</i></b>";
                }
            }  
        }

        protected void BtnBuy_Click(object sender, EventArgs e)
        {
            Session["cartproduct"] = (Product)Session["Reviewproduct"];;
            Response.Redirect("~/Member_Pages/StoreLocation.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Member_Pages/ProductSelection.aspx");
        }
    }
}