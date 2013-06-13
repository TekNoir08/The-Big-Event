<%@ Page Title="Sign up" Language="C#" MasterPageFile="~/Master Pages/MasterPage.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="User_Pages_SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" Width="818px" 
        ContinueDestinationPageUrl="~/MyProfile.aspx">
        <MailDefinition BodyFileName="~/App_Data/SignUpConf.txt" 
            Subject="Your new account">
        </MailDefinition>
        <WizardSteps>
            <asp:CreateUserWizardStep runat="server" />
            <asp:CompleteWizardStep runat="server" />
        </WizardSteps>
    </asp:CreateUserWizard>
</asp:Content>

