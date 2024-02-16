<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/principal.Master" AutoEventWireup="true" CodeFile="HODAllocation.aspx.cs" Inherits="Attendance_management_system.Principal.HODAllocation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <fieldset class="border p-3 bg-white rounded">
        <legend class="w-auto">Department HOD allocation</legend>
        <div class="form-group mt-2">
            <label for="exampleFormControlSelect1">Select Department</label>
            <asp:DropDownList class="form-control" ID="DepartmentName" runat="server" DataSourceID="SqlDataSource1" DataTextField="DepartmentName" DataValueField="DepartmentName">
                <asp:ListItem>Select Course</asp:ListItem>
                <asp:ListItem>Course 1</asp:ListItem>
                <asp:ListItem>Course 2</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AMSConnectionString2 %>" SelectCommand="SELECT [DepartmentName] FROM [DepartmentDetail]"></asp:SqlDataSource>
        </div>

        <div class="form-group mt-2">
            <label for="exampleformcontrolselect1">Select HOD Name</label>
            <asp:DropDownList CssClass="form-control" ID="HODName" runat="server" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="name">
                <asp:ListItem>Select Teacher</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:AMSConnectionString2 %>" SelectCommand="SELECT [name] FROM [TeacherstaffDetail]"></asp:SqlDataSource>
        </div>
        <asp:Button runat="server" CssClass="btn btn-primary mt-3 align-items-center" Text="Allocated" OnClick="allocatedHOD" />
    </fieldset>

</asp:Content>
