<%@ Page Title="" Language="C#" MasterPageFile="~/HOD/HOD.Master" AutoEventWireup="true" CodeFile="CourseFrom.aspx.cs" Inherits="Attendance_management_system.HOD.CourseFrom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <div class="col bg-white rounded shadow">

       <div class="h1 text-center pt-2">
           Course Form
       </div>

       <div class="row p-3">
           <div class="col col-12 col-lg-12">
               <asp:Label runat="server" Text="Course Name" />
               <asp:TextBox runat="server" ID="CourseName" CssClass="form-control mt-1" Enabled="false"/>
           </div>

           <div class="col col-12 col-lg-12">
               <asp:Label runat="server" Text="Co-ordinator" />
               <asp:DropDownList runat="server" Enabled="false" ID="co_ordinator" CssClass="form-control mt-1"></asp:DropDownList>
               <asp:SqlDataSource runat="server"></asp:SqlDataSource>
           </div>

           <div class="col col-12 col-lg-12">
               <asp:Label runat="server" Text="Course Name" />
               <asp:DropDownList runat="server" Enabled="false" ID="Department" CssClass="form-control mt-1"></asp:DropDownList>
               <asp:SqlDataSource runat="server"></asp:SqlDataSource>
           </div>

           <div class="col col-12 col-lg-12 mt-3">
               <asp:Button runat="server" Text="Update" CssClass="btn btn-success" />
               <asp:Button runat="server" Text="Delete" CssClass="btn btn-danger ms-2" />
           </div>
       </div>
   </div>
</asp:Content>
