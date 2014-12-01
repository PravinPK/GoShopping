﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignement5.Member_Pages
{
    public partial class StoreLocation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Product prod = (Product)Session["cartproduct"];
            CartProdct.Text = prod.name;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NearestStore.NearestStoreClient client = new NearestStore.NearestStoreClient();
            NearestStore.Store[] stores = client.GetNearestStore(TextBox1.Text);
            decimal value;

            if (TextBox1.Text == "")
            {
                Label1.Text = "<b>Zipcode should not be empty!</b>";
            }
            else if (!decimal.TryParse(TextBox1.Text, out value))
            {
                Label1.Text = "<b>Zip code should not contain characters!</b>";
            }
            else if (TextBox1.Text.Length != 5)
            {
                Label1.Text = "<b>Zip code should be of length 5!</b>";
            }

            else
            {
                Label1.Text = "";
                if (stores.Length > 0)
                {

                    if (stores.Length == 1)
                    {
                        Label1.Text = "<b>One store located!</b>";
                    }
                    else
                    {
                        Label1.Text = "<b>" + stores.Length + " stores located!</b>";
                    }

                    for (int i = 0; i < stores.Length; i++)
                    {
                        TableRow row1 = new TableRow();
                        Table1.Rows.Add(row1);

                        TableCell cell1 = new TableCell();
                        row1.Cells.Add(cell1);
                        cell1.Text = "<b>Store Name  </b>";

                        TableCell cell2 = new TableCell();
                        row1.Cells.Add(cell2);
                        cell2.Text = stores[i].longName;


                        TableRow row2 = new TableRow();
                        Table1.Rows.Add(row2);

                        TableCell cell3 = new TableCell();
                        row2.Cells.Add(cell3);
                        cell3.Text = "<b>Address  </b> ";

                        TableCell cell4 = new TableCell();
                        row2.Cells.Add(cell4);
                        cell4.Text = stores[i].address + " , " + stores[i].city + " , " + stores[i].region;


                        TableRow row3 = new TableRow();
                        Table1.Rows.Add(row3);

                        TableCell cell5 = new TableCell();
                        row3.Cells.Add(cell5);
                        cell5.Text = "<b>Hours Open  </b>";

                        TableCell cell6 = new TableCell();
                        row3.Cells.Add(cell6);
                        cell6.Text = stores[i].hours;


                        TableRow row4 = new TableRow();
                        Table1.Rows.Add(row4);

                        TableCell cell7 = new TableCell();
                        row4.Cells.Add(cell7);
                        cell7.Text = "";

                        TableCell cell8 = new TableCell();
                        row4.Cells.Add(cell8);
                        cell8.Text = "";


                        GeocodingServices.GeocodingClient geoclient = new GeocodingServices.GeocodingClient();
                        String location = geoclient.GetlocationWithAddress(stores[i].address, "", stores[i].city, stores[i].region, TextBox1.Text);
                        if (location == "Address Not found")
                        {
                          
                        }
                        else
                        {
                            String[] splitlocation = location.Split(new string[] { ":" }, StringSplitOptions.None);
                            String latitude = splitlocation[0];
                            String longtitude = splitlocation[1];
                            string callWithArgument = String.Format("pointAgain({0},{1})", latitude, longtitude);
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "myScript", callWithArgument, true);
                        }

                        WeatherService.WeatherSolarClient weatherclient = new WeatherService.WeatherSolarClient();
                        String[] weatherdata = weatherclient.GetWeatherDetails(Int32.Parse(TextBox1.Text));
                        if (!(weatherdata[0] == "City Not found"))
                            lbl_weather_output.Text = "<h3>Weather Forecast for your store Pick Up </h3><br/>" + weatherdata[0] + "<br/>" + weatherdata[1] + "<br/>" + weatherdata[2] + "<br/>" + weatherdata[3] + "<br/>" + weatherdata[4];
                        else
                            lbl_weather_output.Text = "";
                    }
                }
                else
                {
                    Label1.Text = "<b>No stores found! Check the input and Internet connection!</b>";
                }
            }
        }


    }
}