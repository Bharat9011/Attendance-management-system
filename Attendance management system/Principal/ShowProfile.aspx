<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/principal.Master" AutoEventWireup="true" CodeFile="ShowProfile.aspx.cs" Inherits="Attendance_management_system.Principal.ShowProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="bg-white rounded shadow p-2">

        <div class="h1">Update Profile</div>

        <div class="form-group">
            <label for="exampleInputEmail1">Full Name</label>
            <asp:Label runat="server" ID="Name" class="form-control fs-3" />
        </div>
        <div class="form-group mt-2">
            <label for="exampleInputEmail1">Email address</label>
            <asp:TextBox runat="server" TextMode="SingleLine" ID="Email" class="form-control"></asp:TextBox>
        </div>
        <div class="form-group mt-2">
            <label for="exampleInputPassword1">Password</label>
            <asp:TextBox runat="server" TextMode="SingleLine" ID="Password" class="form-control"></asp:TextBox>
        </div>
        <div class="form-group mt-2">
            <label for="exampleFormControlSelect1">Role 1</label>
            <asp:DropDownList class="form-control" ID="Role1" runat="server">
                <asp:ListItem>Select Role 1</asp:ListItem>
                <asp:ListItem Value="HOD">HOD</asp:ListItem>
                <asp:ListItem Value="Teacher">Teacher</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="form-group mt-2">
            <label for="exampleFormControlSelect1">Role 2</label>
            <asp:DropDownList class="form-control" ID="Role2" runat="server">
                <asp:ListItem class="form-control">Select Role 2</asp:ListItem>
                <asp:ListItem Value="Teacher">Teacher</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="form-group mt-2">
            <label for="exampleFormControlSelect1">Select Department</label>
            <asp:DropDownList class="form-control" ID="Department" runat="server" DataSourceID="SqlDataSource1" DataTextField="DepartmentName" DataValueField="DepartmentName">
                <asp:ListItem class="form-control">Select department 2</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AMSConnectionString %>" ProviderName="<%$ ConnectionStrings:AMSConnectionString.ProviderName %>" SelectCommand="SELECT [DepartmentName] FROM [DepartmentDetail]"></asp:SqlDataSource>
        </div>
    </div>

</asp:Content>
