<%@ Page Title="" Language="C#" MasterPageFile="~/HOD/HOD.Master" AutoEventWireup="true" CodeFile="TeacherAccountCreate.aspx.cs" Inherits="Attendance_management_system.HOD.TeacherAccountCreate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset class="border p-3 bg-white rounded">
    <legend class="w-auto">Teacher Account Deatil</legend>

    <asp:Panel runat="server" ID="MessageBox" Visible="False">
        <div class="alert alert-success" id="MessageBox" role="alert">
            <asp:Label runat="server" ID="massage" />
        </div>
    </asp:Panel>
    <div class="form-group">
        <label for="exampleInputEmail1">Full Name</label>
        <asp:TextBox runat="server" TextMode="SingleLine" ID="NameTeacher" class="form-control"></asp:TextBox>
    </div>
    <div class="form-group mt-2">
        <label for="exampleInputEmail1">Email address</label>
        <asp:TextBox runat="server" TextMode="Email" ID="EmailTeacher" class="form-control"></asp:TextBox>
    </div>
    <div class="form-group mt-2">
        <label for="exampleInputPassword1">Password</label>
        <asp:TextBox runat="server" TextMode="Password" ID="PasswordTeacher" class="form-control"></asp:TextBox>
    </div>
    <div class="form-group mt-2">
        <label for="exampleFormControlSelect1">Allocates as Co-ordinator</label>
        <asp:DropDownList class="form-control" ID="Role1" runat="server">
            <asp:ListItem>Select Role 1</asp:ListItem>
            <asp:ListItem>HOD</asp:ListItem>
            <asp:ListItem>Teacher</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div class="form-group mt-2">
        <label for="exampleFormControlSelect1">Allocates as teacher</label>
        <asp:DropDownList class="form-control" ID="Role2" runat="server">
            <asp:ListItem class="form-control">Select Role 2</asp:ListItem>
            <asp:ListItem>Teacher</asp:ListItem>
            <asp:ListItem>Co-ordinator</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div class="form-group mt-2">
        <label for="exampleFormControlSelect1">Select Department</label>
        <asp:TextBox runat="server" ID="CourseName" Enabled="false" TextMode="SingleLine" CssClass="form-control mt-1"/>
    </div>
    <asp:Button runat="server" CssClass="btn btn-primary mt-3 align-items-center" Text="Submit" />
</fieldset>
</asp:Content>
