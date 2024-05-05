<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/principal.Master" AutoEventWireup="true" CodeFile="AllStudentList.aspx.cs" Inherits="Attendance_management_system.Principal.AllStudentList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-striped table-hover table-responsive">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="StudentName" HeaderText="Student Name" SortExpression="StudentName" />
            <asp:BoundField DataField="StudentEmail" HeaderText="Student Email" SortExpression="StudentEmail" />
            <asp:BoundField DataField="StudentContactNumber" HeaderText="Student Contact Number" SortExpression="StudentContactNumber" />
            <asp:BoundField DataField="DepartmentName" HeaderText="Student Department" SortExpression="StudentDepartment" />
            <asp:BoundField DataField="CourseName" HeaderText="Student Course" SortExpression="StudentCourse" />
            <asp:BoundField DataField="StudentClass" HeaderText="Student Class" SortExpression="StudentClass" />
            <asp:BoundField DataField="StudentSeesionYear" HeaderText="Student Seesion Year" SortExpression="StudentSeesionYear" />
        </Columns>
</asp:GridView>

<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AMSConnectionString %>" 
    SelectCommand="select n.id,n.studentName,n.StudentEmail,n.StudentContactNumber,d.DepartmentName,c.CourseName,n.StudentClass,n.StudentSeesionYear from StudentDetails n join DepartmentDetail d on n.StudentDepartment = d.id join CourseDeatil c on n.StudentCourse = c.id"></asp:SqlDataSource>

</asp:Content>
