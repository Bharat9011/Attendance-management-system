<%@ Page Title="" Language="C#" MasterPageFile="~/HOD/HOD.Master" AutoEventWireup="true" CodeFile="NotificationDetails.aspx.cs" Inherits="Attendance_management_system.HOD.NotificationDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="bg-white rounded form p-3 border border-primary ">

        <label>Title</label>

        <asp:Label runat="server" ID="Notification_Title" CssClass="fs-6 form-control mt-2" />

        <label>Notification Desciption</label>

        <asp:Label runat="server" ID="Notification_Desciption" CssClass="fs-6 form-control mt-2" />

        <label>To</label>

        <asp:Label runat="server" ID="To" CssClass="fs-6 form-control mt-2" />

    </div>

</asp:Content>
