<%@ Page Title="" Language="C#" MasterPageFile="~/HOD/HOD.Master" AutoEventWireup="true" CodeFile="CreateCourse.aspx.cs" Inherits="Attendance_management_system.HOD.CreateCourse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="bg-white shadow pb-5 rounded">
        <h1 class="text-center p-2">Create Course</h1>

        <div class="col ps-4 border rounded ms-5 me-5">

            <div class="row col-12 col-lx-12 mt-3">
                <div class="form-group">
                    <asp:Label Text="Enter the Course name" runat="server" />
                    <asp:TextBox runat="server" ID="CourseName" TextMode="SingleLine" CssClass="form-control mt-1"/>
                </div>
            </div>

            <div class="row col-12 col-lx-12 mt-3">
                <div class="form-group">
                    <asp:Label Text="Select Department" runat="server"  />
                    <asp:TextBox runat="server" ID="Department" TextMode="SingleLine" CssClass="form-control mt-1" Enabled="false"/>
                </div>
            </div>

            <asp:Button runat="server" Text="Button" OnClick="Unnamed6_Click" CssClass="btn btn-info mt-3 mb-3" />


        </div>
    </div>

</asp:Content>
