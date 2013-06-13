<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/ManagementMaster.master" AutoEventWireup="true" CodeFile="AddNewVenue.aspx.cs" Inherits="Management_AddNewVenue" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" style="width: 813px">
        <tr>
            <td align="center" colspan="3">
                <h3>
                    Add New Venue</h3>
            </td>
        </tr>
        <tr>
            <td class="style3" style="width: 142px">
                &nbsp;</td>
            <td class="style5" style="width: 163px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4" style="width: 142px">
                Venue Name:</td>
            <td class="style6" style="width: 163px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td class="style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="*Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style3" style="width: 142px">
                Venue Location:</td>
            <td class="style5" style="width: 163px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="*Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style4" style="width: 142px">
            </td>
            <td class="style6" style="width: 163px">
            </td>
            <td class="style2">
            </td>
        </tr>
        <tr>
            <td class="style3" style="width: 142px">
                &nbsp;</td>
            <td class="style5" style="width: 163px">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Add" 
                    Width="130px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

