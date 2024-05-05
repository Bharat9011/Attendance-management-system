<%@ Page Title="" Language="C#" MasterPageFile="~/HOD/HOD.Master" AutoEventWireup="true" CodeFile="AllAttendance.aspx.cs" Inherits="Attendance_management_system.HOD.AllAttendance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css" integrity="sha512-DTOQO9RWCH3ppGqcWaEA1BIZOC6xxalwEsw9c2QQeAIftl+Vegovlnee1c9QX4TctnWMn13TZye+giMm8e2LwA==" crossorigin="anonymous" referrerpolicy="no-referrer" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered table-striped table-hover" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField HeaderText="Student Name">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("StudentName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Attendance">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("Attendance") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Lecture Topic">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("Time") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Lecture Topic">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("LectureTopic") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Course">
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("course") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Department">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("Department") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Student Year">
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Eval("studentYear") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Semister">
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%# Eval("semister") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Teacher Name">
                <ItemTemplate>
                    <asp:Label ID="Label8" runat="server" Text='<%# Eval("AttendanBy") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Subject Name">
                <ItemTemplate>
                    <asp:Label ID="Label9" runat="server" Text='<%# Eval("SubjectName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>

</asp:Content>
