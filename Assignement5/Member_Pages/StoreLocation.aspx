﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StoreLocation.aspx.cs" MasterPageFile="~/BestBuy.Master" Inherits="Assignement5.Member_Pages.StoreLocation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


   <script src="https://maps.googleapis.com/maps/api/js"></script>
   <script type="text/javascript">
       function initialize() {
           var mapCanvas = document.getElementById('map_canvas');
           var mapOptions = {
               center: new google.maps.LatLng(44.5403, -78.5463),
               zoom: 8,
               mapTypeId: google.maps.MapTypeId.ROADMAP
           }
           var map = new google.maps.Map(mapCanvas, mapOptions)
       }
       // google.maps.event.addDomListener(window, 'load', initializ);

       function pointAgain(lat, longi) {
           var mapCanvas1 = document.getElementById('map_canvas');
           var mapOptions1 = {
               center: new google.maps.LatLng(lat, longi),
               zoom: 16,
               mapTypeId: google.maps.MapTypeId.ROADMAP
           }
           var map = new google.maps.Map(mapCanvas1, mapOptions1)
           var marker = new google.maps.Marker({
               position: new google.maps.LatLng(lat, longi),
               map: map,
               draggable: true,
               animation: google.maps.Animation.BOUNCE,
               title: "Typed Location"
           });
       }
    </script>


    <h3>Selected Products&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h3>
     <asp:Panel HorizontalAlign="Right" runat="server"> <asp:Button ID="Button2" runat="server" style="align-self:auto;" Text="Sign Out" OnClick="SignOutClick_Click" /></asp:Panel>
    <asp:GridView ID="GridView" runat="server">
    </asp:GridView>
    <asp:Label ID="Label4" runat="server" Text="Total Price :"></asp:Label>
&nbsp;<asp:Label ID="totalPriceLabel" runat="server"></asp:Label>
    <br />
    <asp:Label ID="NoItemsLabel" runat="server"></asp:Label>
    <br />
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem Value="Store" Selected="True">Store Pickup</asp:ListItem>
        <asp:ListItem>Buy Online</asp:ListItem>
    </asp:RadioButtonList>
    <h3>Store Location</h3>
    <h3>Store Pick Up? Check Your Nearest Store&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Buy It Online<br /></h3>
    Provide your ZipCode&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="CreditCard No"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 55px"></asp:TextBox>
    <p>
        <asp:TextBox ID="TextBox1" runat="server" Text="85282"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ships To :
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Width="127px" />
    <asp:Button ID="BuyClicked" runat="server" style="margin-left: 686px" Text="Pay and CheckOut" OnClick="BuyClicked_Click" Width="203px" />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <asp:Label ID="Label5" runat="server" style="margin-left: 770px" ></asp:Label>
    <br />
    <asp:Table ID="Table1" runat="server" BorderStyle="None" GridLines="Both" Height="149px" Width="381px">
    </asp:Table>

        <br />

    <div id="map_canvas"></div>
    
        <style type="text/css">
       #map_canvas {
        width: 500px;
        height: 400px;
         background-color: #CCC;
      }
    </style>
        <asp:Label ID="lbl_weather_output" runat="server"></asp:Label>
</asp:Content>
