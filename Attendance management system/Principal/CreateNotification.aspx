<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/principal.Master" AutoEventWireup="true" CodeFile="CreateNotification.aspx.cs" Inherits="Attendance_management_system.Principal.CreateNotification" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <fieldset class="border p-3 bg-white rounded">
        <legend class="w-auto">Create Notification</legend>
        <div class="form-group">
            <label for="exampleInputEmail1">Notification Title</label>
            <asp:TextBox runat="server" TextMode="SingleLine" ID="NameCourse" class="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="exampleInputEmail1">Notification Desciption</label>
            <asp:TextBox runat="server" TextMode="SingleLine" ID="TextBox1" class="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="exampleInputEmail1">Notification images document</label>
            <asp:TextBox runat="server" TextMode="SingleLine" ID="TextBox2" class="form-control"></asp:TextBox>
        </div>

        <div class="form-group mt-2">
            <label for="exampleFormControlSelect1">For</label>
            <asp:DropDownList class="form-control" ID="Role1" runat="server">
                <asp:ListItem>All (HOD,Teacher,Co-ordinator)</asp:ListItem>
                <asp:ListItem>HOD</asp:ListItem>
                <asp:ListItem>Teacher</asp:ListItem>
                <asp:ListItem>Co-ordinator</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Button runat="server" CssClass="btn btn-primary mt-3 align-items-center" Text="Submit" />
    </fieldset>

</asp:Content>
