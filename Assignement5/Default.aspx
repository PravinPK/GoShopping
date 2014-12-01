<%@ Page Title="" Language="C#" MasterPageFile="~/BestBuy.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignement5.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 style="align-self:center">Public Page</h2>
    <h4>System Description</h4>
    <p>This is a Shopping Application.We have used the Best Buy API to simulate a product search, Recommeded Products , Locate and Map the nearest store and finllay allow the user to buy their products</p>
    <h4>Service Description</h4>
    <asp:Button ID="enterApp" runat="server" Text="Enter into Application" OnClick="enterApp_Click" />
    <table border="1" cellspacing="0" cellpadding="0" width="816">
        <tbody>
        <tr>
            <td width="816" colspan="5" valign="top">
                <p align="center">
                    Assignment 5 Part 1 Submission
                </p>
            </td>
        </tr>
            <tr>
            <td width="500" valign="top">
                <p align="left">
                    Provider name
                </p>
            </td>
            <td width="500" valign="top">
                <p align="left">
                    Local Component
                </p>
            </td>
            <td width="250" valign="top">
                <p align="left">
                    TryIt link
                </p>
            </td>
            <td width="500" valign="top">
                <p align="left">
                    Description
                </p>
            </td>
            <td width="291" valign="top">
                <p align="left">
                   Services Used
                </p>
            </td>
        </tr>
         <tr>
            <td width="96" valign="top">
                <p align="left">
                    Pravin Prakash Kumar
                </p>
            </td>
            <td width="144" valign="top">
                <p align="left">
                   <h5> DLL Library Hashing</h5>
                    <br/>
                    Input: Password String
                    <br/>
                    Output: Hashed and Encrypted output
                </p>
            </td>
            <td width="133" valign="top">
                <p align="left">
                     <a href="http://webstrar17.fulton.asu.edu/page0/TryIt/DLLHashing.aspx">http://webstrar17.fulton.asu.edu/page0/TryIt/DLLHashing.aspx</a>
                </p>
            </td>
            <td width="152" valign="top">
                <p align="left">
                    Used DLL Library methods to provide encryption and decryption functionality.Use this Library to hash and store the password.
                </p>
            </td>
            <td width="291" valign="top">
                <p align="left">
                   N/A 
                </p>
            </td>
        </tr>
         <tr>
            <td width="96" valign="top">
                <p align="left">
                    Pravin Prakash Kumar
                </p>
            </td>
            <td width="144" valign="top">
                <p align="left">
                   <h4>User Control</h4>
                    <br/>
                    Created two user control to switch between Register User and SignIn
                </p>
            </td>
            <td width="133" valign="top">
                <p align="left">
                  <a href="http://webstrar17.fulton.asu.edu/page0/Member_Pages/Login.aspx">http://webstrar17.fulton.asu.edu/page0/Member_Pages/Login.aspx</a>
                </p>
            </td>
            <td width="152" valign="top">
                <p align="left">
                   This is the Entry point of out application to Login or register a user.Once registered Hashing is done to store the password and cookies are used to store user Info.
                </p>
            </td>
            <td width="291" valign="top">
                <p align="left">
                    <a href="http://webstrar17.fulton.asu.edu/page8/UserManagementService.svc">http://webstrar17.fulton.asu.edu/page8/UserManagementService.svc</a>
                </p>
            </td>
        </tr>




          <tr>
            <td width="96" valign="top">
                <p align="left">
                    Kannan Haridas 
                </p>
            </td>
            <td width="144" valign="top">
                <p align="left">
                   <h5> Global.asax</h5>
                    Global.asax file with a reasonable event handlers
 Stores the events logged Global.xml
                    <br />
                    <h5>User Control</h5>     
 User Control to search for products related to the keywords entered in the input box
 

                </p>
            </td>
            <td width="133" valign="top">
                <p align="left">
                     <a href=" http://webstrar17.fulton.asu.edu/page7/ProductSearchTryIt.aspx"> http://webstrar17.fulton.asu.edu/page7/ProductSearchTryIt.aspx</a>
                </p>
            </td>
            <td width="152" valign="top">
                <p align="left">
                    Global.asax file with a reasonable event handlers
 Stores the events logged Global.xml
                    <br />
                     User Control to search for products related to the keywords entered in the input box
                    <br />
                </p>
            </td>
            <td width="291" valign="top">
                <p align="left">
                     <a href="http://webstrar17.fulton.asu.edu/Page5/ProductSearch.svc">http://webstrar17.fulton.asu.edu/Page5/ProductSearch.svc</a>
                </p>
            </td>
        </tr>


          <tr>
            <td width="96" valign="top">
                <p align="left">
                  Santhosh Raja
                </p>
            </td>
            <td width="144" valign="top">
                <p align="left">
                   <h4> 1.Session and Cookies</h4>
                     Cookie for storing user profile and Session state for storing temporary states for sharing among the sessions
                    <h4>2.User Control</h4>
                   User Control component to get the recommended products or trending sales from BestBuy.com
                </p>
            </td>
            <td width="133" valign="top">
                <p align="left">
                     <a href="http://webstrar17.fulton.asu.edu/page7/ProductTrendandReview.aspx">http://webstrar17.fulton.asu.edu/page7/ProductTrendandReview.aspx</a>
                </p>
            </td>
            <td width="152" valign="top">
                <p align="left">
                   User Control - Gets the recommended products from BestBuy.com
                    <br />
                    <br />
                 Cookies - Stores the user profile entered in the page.
                    <br />
                  Session - Stores the user information, product id and product reviews in the session to share among two pages.
                </p>
            </td>
            <td width="291" valign="top">
                <p align="left">
                   <a href="http://webstrar17.fulton.asu.edu/page1/TopSellersService.svc?wsdl ">http://webstrar17.fulton.asu.edu/page1/TopSellersService.svc?wsdl</a>
                    <br />
                    <a href="http://webstrar17.fulton.asu.edu/page1/ReviewService.svc?wsdl">http://webstrar17.fulton.asu.edu/page1/ReviewService.svc?wsdl</a>
                    

                </p>
            </td>
        </tr>


        </tbody>
    </table>
</asp:Content>
