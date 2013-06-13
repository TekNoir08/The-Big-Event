<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/ManagementMaster.master" AutoEventWireup="true" CodeFile="AddNewCategory.aspx.cs" Inherits="Management_AddNewCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td align="center" colspan="3">
                <h3>
                    Add New Category</h3>
            </td>
        </tr>
        <tr>
            <td class="style2" style="width: 160px">
                &nbsp;</td>
            <td style="width: 97px">
                &nbsp;</td>
            <td style="width: 544px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" style="width: 160px">
                Enter Category Type:</td>
            <td style="width: 97px">
                <asp:TextBox ID="TextBox1" runat="server" Width="147px"></asp:TextBox>
            </td>
            <td style="width: 544px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="*Required Field" ForeColor="Red" 
                    ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2" style="width: 160px">
                &nbsp;</td>
            <td style="width: 97px">
                <asp:Button ID="Button1" runat="server"  Text="Add" 
                    Width="76px" onclick="Button1_Click" />
            </td>
            <td style="width: 544px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3" style="width: 160px">
            </td>
            <td class="style4" style="width: 97px">
            </td>
            <td class="style4" style="width: 544px">
            </td>
        </tr>
    </table>
</asp:Content>

