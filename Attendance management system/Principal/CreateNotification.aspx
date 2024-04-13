<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/principal.Master" AutoEventWireup="true" CodeFile="CreateNotification.aspx.cs" Inherits="Attendance_management_system.Principal.CreateNotification" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset class="border p-3 bg-white rounded">
        <legend class="w-auto">Create Notification</legend>
        <div class="form-group">
            <label for="exampleInputEmail1">Notification Title</label>
            <asp:TextBox runat="server" TextMode="SingleLine" ID="Notification_Title" class="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="exampleInputEmail1">Notification Desciption</label>
            <asp:TextBox runat="server" TextMode="SingleLine" ID="Notification_Desciption" class="form-control"></asp:TextBox>
        </div>

        <div class="form-group mt-2">
            <label for="exampleFormControlSelect1">For</label>
            <asp:DropDownList class="form-control" ID="To" runat="server">
                <asp:ListItem>All (HOD,Teacher,Co-ordinator, Student)</asp:ListItem>
                <asp:ListItem>HOD</asp:ListItem>
                <asp:ListItem>Teacher and co-ordinator</asp:ListItem>
                <asp:ListItem>Student</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Button runat="server" CssClass="btn btn-primary mt-3 align-items-center" Text="Submit" ID="send_notification" OnClick="send_notification_Click" />
    </fieldset>
</asp:Content>
