<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Tacher.Master" AutoEventWireup="true" CodeFile="ShowNotification.aspx.cs" Inherits="Attendance_management_system.Teacher.ShowNotification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" DataSourceID="sqlDataSource" CssClass="table table-bordered table-striped table-responsive table-hover">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="NotificationTitle" HeaderText="NotificationTitle" SortExpression="NotificationTitle" />
            <asp:BoundField DataField="Notification_Desciption" HeaderText="Notification_Desciption" SortExpression="Notification_Desciption" />
        </Columns>
    </asp:GridView>

    <asp:SqlDataSource ID="sqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:AMSConnectionString %>" SelectCommand="SELECT [id], [NotificationTitle], [Notification_Desciption] FROM [Notification] WHERE (([Notofication_To] = @Notofication_To) OR ([Notofication_To] = @Notofication_To2) OR ([Notofication_To] = @Notofication_To3))">
        <SelectParameters>
            <asp:Parameter DefaultValue="Teacher and co-ordinator" Name="Notofication_To" Type="String" />
            <asp:Parameter DefaultValue="All (HOD,Teacher,Co-ordinator, Student)" Name="Notofication_To2" Type="String" />
            <asp:Parameter DefaultValue="Teacher" Name="Notofication_To3" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>

</asp:Content>
