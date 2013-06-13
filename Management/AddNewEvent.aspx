<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/ManagementMaster.master" AutoEventWireup="true" CodeFile="AddNewEvent.aspx.cs" Inherits="Management_AddNewEvent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td align="center" colspan="5" style="height: 2px">
                <h3>
                    Add New Event</h3>
            </td>
        </tr>
        <tr>
            <td style="height: 3px">
                </td>
            <td style="width: 363px; height: 3px;">
                </td>
            <td style="width: 617px; height: 3px;">
                </td>
            <td style="width: 172px; height: 3px;">
                </td>
            <td style="width: 218px; height: 3px;">
                </td>
        </tr>
        <tr>
            <td class="style2">
            </td>
            <td class="style2" style="width: 363px">
                Category:</td>
            <td class="style2" style="width: 617px">
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    DataSourceID="SqlDataSource1" DataTextField="CategoryType" DataValueField="Id">
                </asp:DropDownList>
            </td>
            <td class="style2" style="width: 172px">
                &nbsp;</td>
            <td class="style2" style="width: 218px">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 363px">
                Event Name:</td>
            <td style="width: 617px">
                <asp:TextBox ID="EventNameBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="EventNameBox" ErrorMessage="Enter an Event Name" 
                    ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
            <td style="width: 172px">
                &nbsp;</td>
            <td style="width: 218px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
            </td>
            <td class="style3" style="width: 363px">
                Venue:</td>
            <td class="style3" style="width: 617px">
                <asp:DropDownList ID="DropDownList2" runat="server" 
                    DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Id">
                </asp:DropDownList>
            </td>
            <td class="style3" style="width: 172px">
                &nbsp;</td>
            <td class="style3" style="width: 218px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 30px">
                </td>
            <td style="width: 363px; height: 30px;">
                Price:</td>
            <td style="width: 617px; height: 30px;">
                <asp:TextBox ID="PriceTextBox" runat="server"></asp:TextBox>
                
                <asp:RangeValidator ID="RangeValidator1" runat="server" 
                    ControlToValidate="PriceTextBox" Display="Dynamic" 
                    ErrorMessage="Price must be greater than 0" ForeColor="Red" MaximumValue="2000" 
                    MinimumValue="0" Type="Currency">*</asp:RangeValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="PriceTextBox" Display="Dynamic" ErrorMessage="Enter a Price" 
                    ForeColor="Red">*</asp:RequiredFieldValidator>
                
            </td>
            <td style="width: 172px; height: 30px;">
                </td>
            <td style="width: 218px; height: 30px;">
                </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 363px">
                Start time:</td>
            <td style="width: 617px">
                <asp:DropDownList ID="DropDownList3" runat="server">
                    <asp:ListItem>00</asp:ListItem>
                    <asp:ListItem>01</asp:ListItem>
                    <asp:ListItem>02</asp:ListItem>
                    <asp:ListItem>03</asp:ListItem>
                    <asp:ListItem>04</asp:ListItem>
                    <asp:ListItem>05</asp:ListItem>
                    <asp:ListItem>06</asp:ListItem>
                    <asp:ListItem>07</asp:ListItem>
                    <asp:ListItem>08</asp:ListItem>
                    <asp:ListItem>09</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                    <asp:ListItem>21</asp:ListItem>
                    <asp:ListItem>22</asp:ListItem>
                    <asp:ListItem>23</asp:ListItem>
                </asp:DropDownList>
                :<asp:DropDownList ID="DropDownList4" runat="server">
                    <asp:ListItem>00</asp:ListItem>
                    <asp:ListItem>05</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                    <asp:ListItem>25</asp:ListItem>
                    <asp:ListItem>30</asp:ListItem>
                    <asp:ListItem>35</asp:ListItem>
                    <asp:ListItem>40</asp:ListItem>
                    <asp:ListItem>45</asp:ListItem>
                    <asp:ListItem>50</asp:ListItem>
                    <asp:ListItem>55</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 172px">
                &nbsp;</td>
            <td style="width: 218px">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 363px">
                Event
                Date:</td>
            <td style="width: 617px">
                <asp:Calendar ID="Calendar1" runat="server" >
                </asp:Calendar>
            </td>
            <td style="width: 172px">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" 
                    Height="193px" style="margin-left: 0px" Width="254px" />
            </td>
            <td style="width: 218px">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 363px">
                Number of Tickets:</td>
            <td style="width: 617px">
                <asp:TextBox ID="TicketsBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="TicketsBox" ErrorMessage="EnterNumber of Tickts" 
                    ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator2" runat="server" 
                    ControlToValidate="TicketsBox" ErrorMessage="Enter a Number " ForeColor="Red" 
                    MaximumValue="10000" MinimumValue="0" Type="Integer">*</asp:RangeValidator>
            </td>
            <td style="width: 172px">
                &nbsp;</td>
            <td style="width: 218px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 75px">
            </td>
            <td style="width: 363px; height: 75px">
                Description:</td>
            <td style="width: 617px; height: 75px" align="left" valign="bottom">
                <asp:TextBox ID="DescriptionBox" runat="server" Height="75px" 
                    style="margin-top: 0px" TextMode="MultiLine" Width="233px"></asp:TextBox>
            </td>
            <td style="width: 172px; height: 75px">
                &nbsp;</td>
            <td style="width: 218px; height: 75px">
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 363px">
                &nbsp;</td>
            <td style="width: 617px">
                <asp:Button ID="Button1" runat="server" Text="Add Event" Width="135px" 
                    onclick="Button1_Click" />
            </td>
            <td style="width: 172px">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString1 %>" 
                    SelectCommand="SELECT [CategoryType], [Id] FROM [Category] ORDER BY [CategoryType]">
                </asp:SqlDataSource>
            </td>
            <td style="width: 218px">
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString1 %>" 
                    SelectCommand="SELECT [Name], [Id] FROM [Venue] ORDER BY [Name]">
                </asp:SqlDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

