<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/principal.Master" AutoEventWireup="true" CodeFile="ShowNotificationDetailes.aspx.cs" Inherits="Attendance_management_system.Principal.ShowNotificationDetailes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="overflow: hidden; scroll-behavior:auto; scrollbar-width: none;">
        <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered table-striped table-hover table-responsive" AutoGenerateColumns="False" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
            <Columns>
                <asp:TemplateField HeaderText="Id">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Notification Title">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("NotificationTitle") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Notification Desciption">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Notification_Desciption") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowSelectButton="True" HeaderText="Select" SelectText="View"></asp:CommandField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
