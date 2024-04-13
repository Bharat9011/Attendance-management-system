<%@ Page Title="" Language="C#" MasterPageFile="~/HOD/HOD.Master" AutoEventWireup="true" CodeFile="teacherDetails.aspx.cs" Inherits="Attendance_management_system.HOD.teacherDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <div class="row bg-white rounded ms-4 me-4 mt-4">

    <div class="row">

        <div class="col col-6 col-md-6">
            <div class="form-group">
                <label runat="server" for="ContentPlaceHolder1_DepartemtList" class="form-group col-form-label control-label">Name</label>
                <asp:TextBox runat="server" ID="Name" CssClass="form-control border-primary border-1"/>
            </div>
        </div>

        <div class="col col-6 col-md-6">
            <div class="form-group">
                <label for="ContentPlaceHolder1_EmailID" runat="server" class="form-group col-form-label control-label">Email ID</label>
                <asp:TextBox runat="server" TextMode="Email" ID="EmailID" CssClass="form-control border-primary border-1" />
            </div>
        </div>

    </div>

    <div class="row">

        <div class="col col-6 col-md-6">
            <div class="form-group">
                <label for="ContentPlaceHolder1_MobileNO" runat="server" class="form-group col-form-label control-label">Role</label>
                <asp:TextBox runat="server" ID="Role" CssClass="form-control border-primary border-1" />
            </div>
        </div>

        <div class="col col-6 col-md-6">
            <div class="form-group ">
                <label runat="server" for="ContentPlaceHolder1_country" class="form-group col-form-label control-label">Department Name</label>
                <asp:TextBox runat="server" ID="DepartmentName" CssClass="form-control border-primary border-1" />
            </div>
        </div>

    </div>

    <div class="row">

        <div class="col col-6 col-md-6">
            <div class="form-group ">
                <label for="ContentPlaceHolder1_state" runat="server" class="form-group col-form-label control-label">Permission</label>
                <asp:TextBox runat="server" ID="permission" CssClass="form-control border-primary border-1" />
            </div>
        </div>
    </div>

    <asp:Button runat="server" Text="Submit" OnClick="Unnamed_Click" CssClass="w-50 h-25 m-auto btn btn-primary mt-3 mb-3" />

</div>

</asp:Content>
