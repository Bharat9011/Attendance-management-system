<%@ Page Title="" Language="C#" MasterPageFile="~/Co_ordinator/Co_ordinator.Master" AutoEventWireup="true" CodeFile="ShowNotificationDetailes.aspx.cs" Inherits="Attendance_management_system.Co_ordinator.ShowNotificationDetailes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CssClass="table table-bordered table-striped table-hover table-responsive rounded" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
        <Columns>
            <asp:TemplateField HeaderText="Id">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Notification Title">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("NotificationTitle") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Notification Desciption">
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("Notification_Desciption") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowSelectButton="True" HeaderText="View" SelectText="Select" />
        </Columns>
    </asp:GridView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AMSConnectionString %>" SelectCommand="SELECT [id], [NotificationTitle], [Notification_Desciption] FROM [Notification] WHERE ([Notofication_To] = @Notofication_To)">
        <SelectParameters>
            <asp:Parameter DefaultValue="co-ordinator" Name="Notofication_To" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>

</asp:Content>
