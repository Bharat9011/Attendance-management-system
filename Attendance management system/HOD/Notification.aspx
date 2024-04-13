<%@ Page Title="" Language="C#" MasterPageFile="~/HOD/HOD.Master" AutoEventWireup="true" CodeFile="Notification.aspx.cs" Inherits="Attendance_management_system.HOD.Notification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="sqlDataSource1" CssClass="table table-bordered table-striped table-hover table-responsive rounded" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
        <Columns>
            <asp:TemplateField HeaderText="id">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Notification Title">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("NotificationTitle") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Notification Desciption">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("Notification_Desciption") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowSelectButton="True" HeaderText="View" SelectText="View" />
        </Columns>
    </asp:GridView>

    <asp:SqlDataSource ID="sqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AMSConnectionString %>" SelectCommand="SELECT id,[NotificationTitle], [Notification_Desciption] FROM [Notification] WHERE (([Notofication_To] = @Notofication_To) OR ([Notofication_To] = @Notofication_To2))">
        <SelectParameters>
            <asp:Parameter DefaultValue="All (HOD,Teacher,Co-ordinator, Student)" Name="Notofication_To" Type="String" />
            <asp:Parameter DefaultValue="HOD" Name="Notofication_To2" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>

</asp:Content>
