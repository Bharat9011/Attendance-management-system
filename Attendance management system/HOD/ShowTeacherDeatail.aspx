<%@ Page Title="" Language="C#" MasterPageFile="~/HOD/HOD.Master" AutoEventWireup="true" CodeFile="ShowTeacherDeatail.aspx.cs" Inherits="Attendance_management_system.HOD.ShowTeacherDeatail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="bg-white rounded text-black">
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanging="GridView2_SelectedIndexChanging" CssClass="table table-striped table-hover shadow">
            <Columns>
                <asp:TemplateField HeaderText="id">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("email") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Password">
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("password") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Role">
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("role1") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Department">
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("DepatmentName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Permission">
                    <ItemTemplate>
                        <asp:Label ID="Label7" runat="server" Text='<%# Eval("permission") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField HeaderText="View" SelectText="View" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
