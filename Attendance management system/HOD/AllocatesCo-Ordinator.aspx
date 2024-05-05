<%@ Page Title="" Language="C#" MasterPageFile="~/HOD/HOD.Master" AutoEventWireup="true" CodeFile="AllocatesCo-Ordinator.aspx.cs" Inherits="Attendance_management_system.HOD.AllocatesCo_Ordinator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="bg-white shadow pb-5 rounded">
    <h1 class="text-center p-2">Create Course</h1>

    <div class="col ps-4 border rounded ms-5 me-5">

        <div class="row col-12 col-lx-12 mt-3">
            <div class="form-group">
                <asp:Label Text="Select Course name" runat="server" />
                <asp:DropDownList runat="server" ID="DropDownList1" AutoPostBack="true" class="form-control"></asp:DropDownList>
            </div>
        </div>

        <div class="row col-12 col-lx-12 mt-3">
            <div class="form-group">
                <asp:Label Text="Select Teacher" runat="server"  />
                <asp:DropDownList runat="server" ID="DropDownList2" class="form-control"></asp:DropDownList>
            </div>
        </div>

        <asp:Button runat="server" Text="Button" ID="allocate" OnClick="allocate_Click" CssClass="btn btn-info mt-3 mb-3" />

    </div>
</div>

</asp:Content>
