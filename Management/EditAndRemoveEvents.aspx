<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/ManagementMaster.master" AutoEventWireup="true" CodeFile="EditAndRemoveEvents.aspx.cs" Inherits="Management_EditAndRemoveEvents" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
    <tr>
        <td align="center" colspan="3">
            <h3 align="center">
                    Edit and Remove Events</h3>
        </td>
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
        <td colspan="3">
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                    AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" 
                    DataSourceID="SqlDataSource2" 
                    EmptyDataText="There are no data records to display.">
                <Columns>
                    <asp:BoundField DataField="CategoryId" HeaderText="CategoryId" 
                            SortExpression="CategoryId" />
                    <asp:BoundField DataField="EventType" HeaderText="EventType" 
                            SortExpression="EventType" />
                    <asp:BoundField DataField="VenueId" HeaderText="VenueId" 
                            SortExpression="VenueId" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                    <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
                    <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                    <asp:BoundField DataField="Description" HeaderText="Description" 
                            SortExpression="Description" />
                    <asp:CommandField ShowDeleteButton="True" ButtonType ="Button" ShowEditButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString1 %>" 
                    DeleteCommand="DELETE FROM [Event] WHERE [Id] = @Id" 
                    InsertCommand="INSERT INTO [Event] ([CategoryId], [EventType], [VenueId], [Price], [Time], [Date], [Description]) VALUES (@CategoryId, @EventType, @VenueId, @Price, @Time, @Date, @Description)" 
                    ProviderName="<%$ ConnectionStrings:DatabaseConnectionString1.ProviderName %>" 
                    SelectCommand="SELECT [Id], [CategoryId], [EventType], [VenueId], [Price], [Time], [Date], [Description] FROM [Event]" 
                    UpdateCommand="UPDATE [Event] SET [CategoryId] = @CategoryId, [EventType] = @EventType, [VenueId] = @VenueId, [Price] = @Price, [Time] = @Time, [Date] = @Date, [Description] = @Description WHERE [Id] = @Id">
                <DeleteParameters>
                    <asp:Parameter Name="Id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="CategoryId" Type="Int32" />
                    <asp:Parameter Name="EventType" Type="String" />
                    <asp:Parameter Name="VenueId" Type="Int32" />
                    <asp:Parameter Name="Price" Type="Decimal" />
                    <asp:Parameter DbType="Time" Name="Time" />
                    <asp:Parameter DbType="Date" Name="Date" />
                    <asp:Parameter Name="Description" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="CategoryId" Type="Int32" />
                    <asp:Parameter Name="EventType" Type="String" />
                    <asp:Parameter Name="VenueId" Type="Int32" />
                    <asp:Parameter Name="Price" Type="Decimal" />
                    <asp:Parameter DbType="Time" Name="Time" />
                    <asp:Parameter DbType="Date" Name="Date" />
                    <asp:Parameter Name="Description" Type="String" />
                    <asp:Parameter Name="Id" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </td>
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

