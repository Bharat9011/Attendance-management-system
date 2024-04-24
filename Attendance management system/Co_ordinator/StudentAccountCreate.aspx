<%@ Page Title="" Language="C#" MasterPageFile="~/Co_ordinator/Co_ordinator.Master" AutoEventWireup="true" CodeFile="StudentAccountCreate.aspx.cs" Inherits="Attendance_management_system.Co_ordinator.StudentAccountCreate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="bg-white shadow pb-5 rounded pt-4">

        <div class="col ps-4 border rounded ms-5 me-5">

            <div class="row col-12 col-lx-12 mt-3">
                <div class="form-group">
                    <asp:Label Text="Enter the Student name" runat="server" />
                    <asp:TextBox runat="server" ID="SubjectName" TextMode="SingleLine" CssClass="form-control mt-1" />
                </div>
            </div>

            <div class="row col-12 col-lx-12 mt-3">
                <div class="form-group">
                    <asp:Label Text="Enter the Email Address" runat="server" />
                    <asp:TextBox runat="server" ID="email" TextMode="SingleLine" CssClass="form-control mt-1" />
                </div>
            </div>

            <div class="row col-12 col-lx-12 mt-3">
                <div class="form-group">
                    <asp:Label Text="Enter the Contact Number" runat="server" />
                    <asp:TextBox runat="server" ID="number" TextMode="SingleLine" CssClass="form-control mt-1" />
                </div>
            </div>

            <div class="row col-12 col-lx-12 mt-3">
                <div class="form-group">
                    <asp:Label Text="Enter the Department" runat="server" />
                    <asp:TextBox runat="server" ID="department" Enabled="false" TextMode="SingleLine" CssClass="form-control mt-1" />
                </div>
            </div>

            <div class="row col-12 col-lx-12 mt-3">
                <div class="form-group">
                    <asp:Label Text="Enter the Course" runat="server" />
                    <asp:TextBox runat="server" ID="course" Enabled="false" TextMode="SingleLine" CssClass="form-control mt-1" />
                </div>
            </div>

            <div class="row col-12 col-lx-12 mt-3">
                <div class="form-group">
                    <asp:Label Text="Enter the Course Year" runat="server" />
                    <asp:TextBox runat="server" ID="classes" TextMode="SingleLine" CssClass="form-control mt-1" />
                </div>

                <div class="row col-12 col-lx-12 mt-3">
                    <div class="form-group">
                        <asp:Label Text="Enter the Session Year" runat="server" />
                        <asp:TextBox runat="server" ID="sessionYear" TextMode="SingleLine" CssClass="form-control mt-1" />
                    </div>
                </div>

                <div class="row col-12 col-lx-12 mt-3">
                    <div class="form-group">
                        <asp:Label Text="Enter the Password" runat="server" />
                        <asp:TextBox runat="server" ID="Password" TextMode="SingleLine" CssClass="form-control mt-1" />
                    </div>
                </div>

                <asp:Button runat="server" Text="Create Subject" ID="createstudentAccount" OnClick="createstudentAccount_click" style="width: 150px;" CssClass="btn btn-info mt-3 mb-3 rounded" />

            </div>
</asp:Content>
