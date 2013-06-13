<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="User_Pages_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 98%;
        }
        .style2
        {
            width: 269px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    `<table class="style1">
    <tr>
        <td class="style2">
            <h3>Welcome</h3></td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
            <br />
            Welcome to The Big Event website. The Big Event is one of the worlds largest 
            sporting events with athletes from over 200 countries competing for medals. 
            Tickets are sure to be in popular demand so register your interest in those 
            tickets now before they are all gone.<br />
            <br />
        </td>
        <td>
            <img alt="" class="style7" src="images/homepage1.jpg" /></td>
    </tr>
</table>
<p></p>
<table>
<tr>
<td class="style6">
    <img alt="" class="style5" src="images/olympic%20tickets.jpg" /></td>
<td class="style3">
    <br />
            On The Big Event you will be able to search for 
            events
            by event name, date and ticket price.
        You will also be able to enter a draw for tickets which you wish to receive. 
    If your name is chosen from the draw you will be able to complete the purchase 
    of those tickets securely if you wish to do so. 
    <br />
</td>
</tr>
</table>

    </asp:Content>

