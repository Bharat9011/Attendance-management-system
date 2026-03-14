<%@ Page Title="" Language="C#" MasterPageFile="~/HOD/HOD.Master" AutoEventWireup="true" CodeFile="StudentList.aspx.cs" Inherits="Attendance_management_system.HOD.StudentList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-bordered table-hover table-responsive" AutoGenerateColumns="false">
        <Columns>
            <asp:TemplateField HeaderText="Id">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# Eval("id") %>' />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# Eval("StudentName") %>' />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Email">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# Eval("StudentEmail") %>' />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Password">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# Eval("StudentContactNumber") %>' />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Role">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# Eval("DepartmentName") %>' />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Department Name">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# Eval("CourseName") %>' />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Permission">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# Eval("StudentClass") %>' />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Permission">
                <itemtemplate>
                    <asp:Label runat="server" Text='<%# Eval("StudentSeesionYear") %>' />
                </itemtemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Permission">
                <itemtemplate>
                    <asp:Label runat="server" Text='<%# Eval("StudentPassword") %>' />
                </itemtemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Permission">
                <itemtemplate>
                    <asp:Label runat="server" Text='<%# Eval("Semister") %>' />
                </itemtemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
