<%@ Page Title="My Events" Language="C#" MasterPageFile="~/Master Pages/MasterPage.master" AutoEventWireup="true" CodeFile="MyEvents.aspx.cs" Inherits="User_Pages_MyEvents" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td>
                <h3>View tickets you have registered or won </h3></td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                You have registered for the following events:</td>
            <td class="style2">
                You have won the following events:</td>
            <td class="style2">
                </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="RegisteredGridView" runat="server" 
                        EmptyDataText ="You have not registered for any events yet" 
                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                    GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                    <asp:BoundField DataField = "EventType" HeaderText = "Event" />
                    <asp:BoundField DataField ="Date" HeaderText ="Date" DataFormatString ="{0:d}" />

                    </Columns>

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
            <td>
                <asp:GridView ID="WonGridView" runat="server" EmptyDataText ="You have not won tickets for any event yet" 
                 AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                    GridLines="None" onrowcommand="WonGridView_RowCommand">
                    <AlternatingRowStyle BackColor="White" />
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
                    
                    <Columns>
                    <asp:BoundField DataField = "EventType" HeaderText = "Event" />
                    <asp:BoundField DataField ="Date" HeaderText ="Date" DataFormatString ="{0:d}" />
                    
                    <asp:ButtonField ButtonType="button" CommandName="Accept" 
                                             Text="Accept Ticket" />
                    <asp:ButtonField ButtonType="button" CommandName="Reject" 
                                             Text="Reject Ticket" />
                    </Columns>


                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                You can register for
                <asp:Label ID="NumTickets" runat="server"></asp:Label>
&nbsp;more ticket(s)</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

