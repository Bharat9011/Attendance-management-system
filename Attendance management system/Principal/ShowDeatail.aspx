<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/principal.Master" AutoEventWireup="true" CodeFile="ShowDeatail.aspx.cs" Inherits="Attendance_management_system.Principal.ShowDeatail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="mt-5 ms-3 me-3 bg-white rounded shadow">

        <div class="h1 text-center mt-2 mb-3">HOD Login List</div>
            <asp:GridView ID="GridView1" CssClass="table table-striped table-hover shadow table-bordered"  runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                    <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
                    <asp:BoundField DataField="role1" HeaderText="role1" SortExpression="role1" />
                    <asp:BoundField DataField="role2" HeaderText="role2" SortExpression="role2" />
                    <asp:BoundField DataField="DepatmentName" HeaderText="DepatmentName" SortExpression="DepatmentName" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AMSConnectionString2 %>" SelectCommand="SELECT * FROM [TeacherstaffDetail]"></asp:SqlDataSource>
        </div>

</asp:Content>
