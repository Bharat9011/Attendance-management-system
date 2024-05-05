<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/principal.Master" AutoEventWireup="true" CodeFile="ShowAttendance.aspx.cs" Inherits="Attendance_management_system.Principal.ShowAttendance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CssClass="table table-bordered table-striped table-responsive table-hover">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" InsertVisible="False" SortExpression="id"></asp:BoundField>
            <asp:BoundField DataField="LectureTopic" HeaderText="LectureTopic" SortExpression="LectureTopic"></asp:BoundField>
            <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time"></asp:BoundField>
            <asp:BoundField DataField="StudentName" HeaderText="StudentName" SortExpression="StudentName"></asp:BoundField>
            <asp:BoundField DataField="Department" HeaderText="Department" SortExpression="Department"></asp:BoundField>
            <asp:BoundField DataField="course" HeaderText="course" SortExpression="course"></asp:BoundField>
            <asp:BoundField DataField="Attendance" HeaderText="Attendance" SortExpression="Attendance"></asp:BoundField>
            <asp:BoundField DataField="studentYear" HeaderText="studentYear" SortExpression="studentYear"></asp:BoundField>
            <asp:BoundField DataField="semister" HeaderText="semister" SortExpression="semister"></asp:BoundField>
            <asp:BoundField DataField="CourseYear" HeaderText="CourseYear" SortExpression="CourseYear"></asp:BoundField>
            <asp:BoundField DataField="AttendanBy" HeaderText="AttendanBy" SortExpression="AttendanBy"></asp:BoundField>
            <asp:BoundField DataField="SubjectName" HeaderText="SubjectName" SortExpression="SubjectName"></asp:BoundField>
        </Columns>
    </asp:GridView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:AMSConnectionString %>' SelectCommand="SELECT * FROM [Attendance]"></asp:SqlDataSource>

</asp:Content>
