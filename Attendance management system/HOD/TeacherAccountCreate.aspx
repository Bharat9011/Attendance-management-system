<%@ Page Title="" Language="C#" MasterPageFile="~/HOD/HOD.Master" AutoEventWireup="true" CodeFile="TeacherAccountCreate.aspx.cs" Inherits="Attendance_management_system.HOD.TeacherAccountCreate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset class="border p-3 bg-white rounded shadow">
        <legend class="w-auto">Teacher Account Deatil</legend>

        <asp:Panel runat="server" ID="MessageBox1" Visible="False">
            <div class="alert alert-success" id="MessageBox" role="alert">
                <asp:Label runat="server" ID="massage" />
            </div>
        </asp:Panel>
        <div class="form-group">
            <label for="FullName">Full Name</label>
            <asp:TextBox runat="server" TextMode="SingleLine" ID="FullName" class="form-control"></asp:TextBox>
        </div>
        <div class="form-group mt-2">
            <label for="EmailAddress">Email address</label>
            <asp:TextBox runat="server" TextMode="Email" ID="Emails" class="form-control"></asp:TextBox>
        </div>
        <div class="form-group mt-2">
            <label for="Password">Password</label>
            <asp:TextBox runat="server" TextMode="Password" ID="Password" class="form-control"></asp:TextBox>
        </div>

        <asp:RadioButtonList ID="RadioButtonList1" CssClass="mt-2" runat="server" >
            <asp:ListItem Value="Teacher">Teacher</asp:ListItem>
            <asp:ListItem Value="co-ordinator">Co-ordinator</asp:ListItem>
        </asp:RadioButtonList>

        <div class="form-group mt-2">
            <label for="exampleFormControlSelect1">Select Co-Ordinator</label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>

        <div class="form-group mt-2">
            <label for="exampleFormControlSelect1">Select Department</label>
            <asp:TextBox runat="server" ID="DepartmentName" Enabled="false" TextMode="SingleLine" CssClass="form-control mt-1" />
        </div>
        <asp:Button runat="server" CssClass="btn btn-primary mt-3 align-items-center" Text="Submit" OnClick="Unnamed_Click" />
    </fieldset>
</asp:Content>
