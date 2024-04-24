<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/principal.Master" AutoEventWireup="true" CodeFile="AllStudentList.aspx.cs" Inherits="Attendance_management_system.Principal.AllStudentList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-striped table-hover table-responsive">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="StudentName" HeaderText="StudentName" SortExpression="StudentName" />
            <asp:BoundField DataField="StudentEmail" HeaderText="StudentEmail" SortExpression="StudentEmail" />
            <asp:BoundField DataField="StudentContactNumber" HeaderText="StudentContactNumber" SortExpression="StudentContactNumber" />
            <asp:BoundField DataField="StudentDepartment" HeaderText="StudentDepartment" SortExpression="StudentDepartment" />
            <asp:BoundField DataField="StudentCourse" HeaderText="StudentCourse" SortExpression="StudentCourse" />
            <asp:BoundField DataField="StudentClass" HeaderText="StudentClass" SortExpression="StudentClass" />
            <asp:BoundField DataField="StudentSeesionYear" HeaderText="StudentSeesionYear" SortExpression="StudentSeesionYear" />
        </Columns>
</asp:GridView>

<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AMSConnectionString %>" SelectCommand="SELECT [id], [StudentName], [StudentEmail], [StudentContactNumber], [StudentDepartment], [StudentCourse], [StudentClass], [StudentSeesionYear] FROM [StudentDetails]"></asp:SqlDataSource>

</asp:Content>
