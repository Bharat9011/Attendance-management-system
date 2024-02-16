<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/principal.Master" AutoEventWireup="true" CodeFile="ShowDeatail.aspx.cs" Inherits="Attendance_management_system.Principal.ShowDeatail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg-white rounded shadow">

        <div class="h1 text-center mb-2">HOD Details</div>
        <div class="p-2">
            <asp:GridView ID="GridView1" CssClass="table table-striped table-hover shadow table-bordered" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
                    <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                    <asp:BoundField DataField="password" HeaderText="Password" SortExpression="password" />
                    <asp:BoundField DataField="role1" HeaderText="Role1" SortExpression="role1" />
                    <asp:BoundField DataField="role2" HeaderText="Role2" SortExpression="role2" />
                    <asp:BoundField DataField="DepatmentName" HeaderText="DepatmentName" SortExpression="DepatmentName" />
                    <asp:CommandField ShowEditButton="True" HeaderText="Edit" ButtonType="Button" ControlStyle-CssClass="bg-success border-0 btn text-white" CancelText="Cancel" DeleteText="" InsertText="" NewText="" SelectText="" UpdateText="Update">
                        <ControlStyle CssClass="bg-success border-0 btn text-white"></ControlStyle>
                    </asp:CommandField>
                    <asp:CommandField ShowSelectButton="True" HeaderText="View" ButtonType="Button" ControlStyle-CssClass="bg-info border-0 btn text-white" SelectText="View">
                        <ControlStyle CssClass="bg-info border-0 btn text-white"></ControlStyle>
                    </asp:CommandField>
                    <asp:CommandField ShowDeleteButton="True" HeaderText="Delete" ButtonType="Button" ControlStyle-CssClass="bg-danger border-0 btn text-white">
                        <ControlStyle CssClass="bg-danger border-0 btn text-white"></ControlStyle>
                    </asp:CommandField>
                </Columns>
            </asp:GridView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AMSConnectionString2 %>" SelectCommand="SELECT [name], [email], [password], [role1], [role2], [DepatmentName] FROM [TeacherstaffDetail] WHERE ([role1] = @role1)">
            <SelectParameters>
                <asp:Parameter DefaultValue="HOD" Name="role1" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>

</asp:Content>
