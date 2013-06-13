<%@ Page Title="Search" Language="C#" MasterPageFile="~/Master Pages/MasterPage.master" AutoEventWireup="true" CodeFile="search.aspx.cs" Inherits="User_Pages_search" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        #table
        {
            margin-left: 0px;
        }
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 221px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="table">
    
    
    <%--  This is the gridview, Autogenerate is set to false to allow custom field names and layout --%>
        <table class="style1">
            <tr>
                <td>
                    <h3>Search for Tickets</h3></td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns ="False"
        EmptyDataText ="Your search returned no results." CellPadding="4" 
        ForeColor="#333333" GridLines="None" meta:resourcekey="GridView1Resource1" 
        onrowcommand="GridView1_RowCommand">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="EventType" HeaderText="Event" 
                meta:resourcekey="BoundFieldResource1"  />
            <asp:BoundField DataField="Name" HeaderText="Venue" 
                meta:resourcekey="BoundFieldResource2"  />
            <asp:BoundField DataField="Price" DataFormatString = "{0:C2}" 
                HeaderText="Price" meta:resourcekey="BoundFieldResource3"  />
            <asp:BoundField DataField="Date" DataFormatString ="{0:d}" HeaderText="Date" 
                meta:resourcekey="BoundFieldResource4"  />
            <asp:BoundField DataField="Time" DataFormatString ="{0:hh}:{0:mm}" 
                HeaderText="Start Time" meta:resourcekey="BoundFieldResource5"  />
            <asp:BoundField DataField="Description" HeaderText="Description" 
                meta:resourcekey="BoundFieldResource6"  />
            <asp:CommandField ButtonType="Button" SelectText="Register For Event" 
                ShowSelectButton="True" />
        </Columns>
        

          <%-- Formatting for the gridview --%>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
        
        
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
        Search by Date:</td>
            </tr>
            <tr>
                <td colspan="3">
        <asp:Calendar ID="Calendar1" runat="server" 
            onselectionchanged="Calendar1_SelectionChanged" 
            meta:resourcekey="Calendar1Resource1"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Advanced Search</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
        <asp:DropDownList ID="CategoryDropdown" runat="server" 
            DataSourceID="SqlDataSource1"  DataTextField="CategoryType" AppendDataBoundItems ="True"
            DataValueField="CategoryType" meta:resourcekey="CategoryDropdownResource1">
            <asp:ListItem Value ="" meta:resourcekey="ListItemResource1">Select Category</asp:ListItem> 
        </asp:DropDownList>
        
        <asp:DropDownList ID="PriceDropdown" runat="server" 
            meta:resourcekey="PriceDropdownResource1">
            <asp:ListItem Value ="" meta:resourcekey="ListItemResource2">Select Price Range</asp:ListItem>
            <asp:ListItem Value= "1" meta:resourcekey="ListItemResource3" >£0-£10</asp:ListItem>
            <asp:ListItem Value= "2" meta:resourcekey="ListItemResource4" >£11 - £25</asp:ListItem>
            <asp:ListItem Value= "3" meta:resourcekey="ListItemResource5" >£26 - £50</asp:ListItem>
            <asp:ListItem Value= "4" meta:resourcekey="ListItemResource6" >£50+</asp:ListItem>
            
        </asp:DropDownList>
        <asp:DropDownList ID="DateDropdown" runat="server" AppendDataBoundItems="True" 
            meta:resourcekey="DateDropdownResource1">
            <asp:ListItem meta:resourcekey="ListItemResource7">Select Date Range</asp:ListItem>
            <asp:ListItem Value="1" meta:resourcekey="ListItemResource8">Next 7 Days</asp:ListItem>
            <asp:ListItem Value="2" meta:resourcekey="ListItemResource9">Next 14 Days</asp:ListItem>
            <asp:ListItem Value="3" meta:resourcekey="ListItemResource10">Next 1 Month</asp:ListItem>
            <asp:ListItem Value="4" meta:resourcekey="ListItemResource11">Next 3 Months</asp:ListItem>
        </asp:DropDownList>
                    <asp:Label ID="Label1" runat="server" 
            Text="* All fields must be selected" meta:resourcekey="Label1Resource1"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
        <asp:Button ID="Button1" runat="server" Text="Filter" onclick="Button1_Click" 
            Height="25px" Width="75px" meta:resourcekey="Button1Resource1" />
        <asp:Button ID="Button2" runat="server" Height="25px" onclick="Button2_Click" 
            Text="Reset" Width="75px" meta:resourcekey="Button2Resource1" />
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        
        
        <br />
        <br />
        &nbsp;&nbsp;
        <br />
        
        



        <%-- Formatting for the gridview --%>
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString1 %>" 
            SelectCommand="SELECT DISTINCT * FROM [Category] ORDER BY [CategoryType]">
        </asp:SqlDataSource>
    &nbsp;
        &nbsp;<br />
        <br />
        <br />
    </div>
    </asp:Content>

