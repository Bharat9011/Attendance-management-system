<%@ Page Title="" Language="C#" MasterPageFile="~/Co_ordinator/Co_ordinator.Master" AutoEventWireup="true" CodeFile="StudentAccountCreate.aspx.cs" Inherits="Attendance_management_system.Co_ordinator.StudentAccountCreate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
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
                    <asp:Label Text="Enter the Year" runat="server" />
                    <asp:DropDownList ID="Year" runat="server" CssClass="form-control">
                        <asp:ListItem Value="1 Year">1 Year</asp:ListItem>
                        <asp:ListItem Value="2 Year">2 Year</asp:ListItem>
                        <asp:ListItem Value="3 Year">3 Year</asp:ListItem>
                        <asp:ListItem Value="4 Year">4 Year</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <div class="row col-12 col-lx-12 mt-3">
                <div class="form-group">
                    <asp:Label Text="Enter the Semister" runat="server" />
                    <asp:DropDownList ID="Semister" runat="server" CssClass="form-control">
                        <asp:ListItem Value="1 Semister">1 Semister</asp:ListItem>
                        <asp:ListItem Value="2 Semister">2 Semister</asp:ListItem>
                        <asp:ListItem Value="3 Semister">3 Semister</asp:ListItem>
                        <asp:ListItem Value="4 Semister">4 Semister</asp:ListItem>
                        <asp:ListItem Value="5 Semister">5 Semister</asp:ListItem>
                        <asp:ListItem Value="6 Semister">6 Semister</asp:ListItem>
                        <asp:ListItem Value="7 Semister">7 Semister</asp:ListItem>
                        <asp:ListItem Value="8 Semister">8 Semister</asp:ListItem>
                    </asp:DropDownList>
                </div>
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

            
</asp:Content>
