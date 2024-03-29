<%@ Page Title="Course List" Language="C#" MasterPageFile="~/HOD/HOD.Master" AutoEventWireup="true" CodeFile="CourseList.aspx.cs" Inherits="Attendance_management_system.HOD.CourseList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="bg-white rounded p-4">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CssClass="table table-bordered table-hover table-striped" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="CourseName" HeaderText="Course Name" SortExpression="CourseName" />
                <asp:BoundField DataField="Co_ordinator" HeaderText="Co ordinator" SortExpression="Co_ordinator" />
                <asp:BoundField DataField="DepartmentName" HeaderText="Department Name" SortExpression="DepartmentName" />
                <asp:CommandField HeaderText="View" SelectText="View" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AMSConnectionString %>" SelectCommand="SELECT [id], [CourseName], [Co_ordinator], [DepartmentName] FROM [CourseDeatil]"></asp:SqlDataSource>
    </div>

</asp:Content>
