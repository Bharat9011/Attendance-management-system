<%@ Page Title="" Language="C#" MasterPageFile="~/Co_ordinator/Co_ordinator.Master" AutoEventWireup="true" CodeFile="ShowSubject.aspx.cs" Inherits="Attendance_management_system.Co_ordinator.ShowSubject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered table-striped table-hover table-responsive" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
        <asp:BoundField DataField="SubjectName" HeaderText="SubjectName" SortExpression="SubjectName" />
        <asp:BoundField DataField="SubjectTeacher" HeaderText="Subject Teacher" SortExpression="SubjectTeacher" />
        <asp:BoundField DataField="Year" HeaderText="Year" SortExpression="Year" />
        <asp:BoundField DataField="Semister" HeaderText="Semister" SortExpression="Semister" />
        <asp:BoundField DataField="TeacherName" HeaderText="Create by" SortExpression="TeacherName" />
        <asp:BoundField DataField="DepartmentName" HeaderText="DepartmentName" SortExpression="DepartmentName" />
        <asp:BoundField DataField="CourseName" HeaderText="CourseName" SortExpression="CourseName" />
    </Columns>
</asp:GridView>


</asp:Content>