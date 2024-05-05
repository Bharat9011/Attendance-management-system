<%@ Page Title="" Language="C#" MasterPageFile="~/Co_ordinator/Co_ordinator.Master" AutoEventWireup="true" CodeFile="TakeAttendance.aspx.cs" Inherits="Attendance_management_system.Co_ordinator.TakeAttendance1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row container ms-0 bg-white p-2 mb-2 rounded">

    <div class="col col-12 col-lg-12">
        <div class="">
            <asp:Label runat="server" Text="Lecture Topic"></asp:Label>
            <asp:TextBox ID="Lecture_Topic" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>

    <div class="col col-12 col-lg-12">
        <div class="">
            <asp:Label runat="server" Text="Lecture Time"></asp:Label>
            <asp:TextBox ID="time" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
        </div>
    </div>

</div>

<asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered table-striped table-hover" AutoGenerateColumns="False">
    <Columns>
        <asp:TemplateField HeaderText="ID">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("id") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Student Name">
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("StudentName") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Department Name">
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Eval("DepartmentName") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Course Name">
            <ItemTemplate>
                <asp:Label ID="Label4" runat="server" Text='<%# Eval("CourseName") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Attendance mark">
            <ItemTemplate>
                <asp:CheckBox ID="CheckBox1" runat="server" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>

<div>
    <asp:Button runat="server" Text="Submit" CssClass="btn btn-success" OnClick="TakeAttendances" />
</div>

</asp:Content>
