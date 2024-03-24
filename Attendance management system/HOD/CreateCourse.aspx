<%@ Page Title="" Language="C#" MasterPageFile="~/HOD/HOD.Master" AutoEventWireup="true" CodeFile="CreateCourse.aspx.cs" Inherits="Attendance_management_system.HOD.CreateCourse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="bg-white shadow">
        <h1 class="text-center p-2">Create Course</h1>

        <div class="col ps-4 border rounded ms-5 me-5 ">

            <div class="row col-12 col-lx-12 mt-3">
                <div class="form-group">
                    <asp:Label Text="Enter the Course name" runat="server" CssClass="fs-5" />
                    <asp:TextBox runat="server" TextMode="SingleLine" CssClass="form-control mt-1"/>
                </div>
            </div>

            <div class="row col-12 col-lx-12 mt-3">
                <div class="form-group">
                    <asp:Label Text="Select Coordinator" runat="server" CssClass="fs-5" />
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                        <asp:ListItem>select </asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <div class="row col-12 col-lx-12 mt-3">
                <div class="form-group">
                    <asp:Label Text="Select Department" runat="server" CssClass="fs-5" />
                    <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control" DataSourceID="SqlDataSource1" DataTextField="DepartmentName" DataValueField="DepartmentName">
                        <asp:ListItem>select</asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;Encrypt=True;" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [DepartmentName] FROM [DepartmentDetail]"></asp:SqlDataSource>
                </div>
            </div>



        </div>
    </div>

</asp:Content>
