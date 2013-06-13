<%@ Page Title="Login" Language="C#" MasterPageFile="~/Master Pages/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="User_Pages_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 351px;
        }
        .style3
        {
            width: 351px;
            height: 261px;
        }
        .style4
        {
            height: 261px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td class="style2">
                <h3> Login to the website</h3>
                <br />
                </td>
            <td>
                </td>
        </tr>
        <tr>
            <td class="style3" align="left">
                &nbsp;<asp:LoginView ID="LoginView1" runat="server">
                    <AnonymousTemplate>
                        <asp:Login ID="Login1" runat="server" Width="334px" TextLayout="TextOnTop" 
                            CreateUserText="Click here to sign up for new account" 
                            CreateUserUrl="~/User Pages/SignUp.aspx">
                        </asp:Login> 
                        <br /> 
                        <br />
                        <br /> 
                        <br />
                        <br /> 
                        <br />
                        <br /> 
                        <br />

                    </AnonymousTemplate>
                    <LoggedInTemplate>
                        You are already logged in
                    </LoggedInTemplate>
                </asp:LoginView>
            </td>
            <td align="center" class="style4">
                        <asp:PasswordRecovery ID="PasswordRecovery1" runat="server">
                        <MailDefinition Subject = "Your new password for The Big Event"></MailDefinition>
                        </asp:PasswordRecovery>

                </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                        &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

