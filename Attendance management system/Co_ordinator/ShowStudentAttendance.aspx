<%@ Page Title="" Language="C#" MasterPageFile="~/Co_ordinator/Co_ordinator.Master" AutoEventWireup="true" CodeFile="ShowStudentAttendance.aspx.cs" Inherits="Attendance_management_system.Co_ordinator.ShowStudentAttendance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
        <asp:TemplateField HeaderText="Date">
            <ItemTemplate>
                <asp:Label ID="label3" runat="server" Text='<%# Eval("Time") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Attendance">
            <ItemTemplate>
                <asp:Label ID="label3" runat="server" Text='<%# Eval("Attendance") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Subject Name">
            <ItemTemplate>
                <asp:Label ID="label4" runat="server" Text='<%# Eval("SubjectName") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Lecture Topic">
        <itemtemplate>
            <asp:Label ID="label5" runat="server" Text='<%# Eval("LectureTopic") %>'></asp:Label>
        </itemtemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>

</asp:Content>
