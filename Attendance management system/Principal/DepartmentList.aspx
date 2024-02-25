<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/principal.Master" AutoEventWireup="true" CodeBehind="DepartmentList.aspx.cs" Inherits="Attendance_management_system.Principal.DepartmentList_aspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 class="text-center mt-3 mb-2">Department List</h1>

    <asp:GridView CssClass="table table-striped table-hover shadow" ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="DepartmentName" HeaderText="DepartmentName" SortExpression="DepartmentName" />

            <asp:TemplateField HeaderText="Edit">
                <ItemTemplate>
                    <asp:Button ID="edit" runat="server" CssClass="btn btn-info text-white" Text="Edit" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="View">
                <ItemTemplate>
                    <asp:Button ID="view" runat="server" CssClass="btn btn-success text-white" Text="View" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                    <asp:Button ID="delete" runat="server" CssClass="btn btn-danger text-white" Text="Delete" />
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AMSConnectionString2 %>" SelectCommand="SELECT * FROM [DepartmentDetail]" ProviderName="<%$ ConnectionStrings:AMSConnectionString2.ProviderName %>"></asp:SqlDataSource>
</asp:Content>