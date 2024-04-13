<%@ Page Title="" Language="C#" MasterPageFile="~/HOD/HOD.Master" AutoEventWireup="true" CodeFile="ShowCourseDetails.aspx.cs" Inherits="Attendance_management_system.HOD.ShowCourseDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row bg-white rounded ms-4 me-4 mt-4">

        <div class="row">

            <div class="col col-6 col-md-6">
                <div class="form-group">
                    <label runat="server" for="ContentPlaceHolder1_DepartemtList" class="form-group col-form-label control-label">Course Name</label>
                    <asp:TextBox runat="server" ID="CourseName" CssClass="form-control border-primary border-1" />
                </div>
            </div>

            <div class="col col-6 col-md-6">
                <div class="form-group">
                    <label for="ContentPlaceHolder1_EmailID" runat="server" class="form-group col-form-label control-label">Co-ordinator</label>
                    <asp:TextBox runat="server" TextMode="SingleLine" ID="Co_ordinator" CssClass="form-control border-primary border-1" />
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col col-6 col-md-6">
                <div class="form-group">
                    <label runat="server" for="ContentPlaceHolder1_DepartemtList" class="form-group col-form-label control-label">Department Name</label>
                    <asp:TextBox runat="server" ID="DepartmentName" CssClass="form-control border-primary border-1" />
                </div>
            </div>
        </div>

        <asp:Button runat="server" Text="Submit" ID="Update" OnClick="submit_Click" CssClass="w-25 h-25 m-auto btn btn-primary mt-3 mb-3" />
        <asp:Button runat="server" Text="delete" ID="Delete" OnClick="Delete_Click" CssClass="w-25 h-25 m-auto btn btn-danger mt-3 mb-3" />

    </div>

</asp:Content>
