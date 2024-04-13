<%@ Page Title="Teacher Permission" Language="C#" MasterPageFile="~/HOD/HOD.Master" AutoEventWireup="true" CodeFile="TeacherPermission.aspx.cs" Inherits="Attendance_management_system.HOD.TeacherPermission" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid bg-white p-2">

        <asp:Label runat="server" Text="select Teacher Name" CssClass="p" />
        
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control mt-1"></asp:DropDownList>

        <asp:Button runat="server" Text="Search" ID="FindTeacher" OnClick="FindTeacher_Click" CssClass="btn btn-success mt-2"  />

        <div>

            <asp:GridView runat="server" ID="GridView1" AutoGenerateColumns="False" DataKeyNames="id" CssClass="table mt-2 table-bordered table-striped table-hover table-responsive">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="permission" HeaderText="permission" SortExpression="permission" />
                </Columns>
            </asp:GridView>

        </div>

        <div class="mt-3">
            <asp:Button runat="server" OnClientClick="false" Text="Not Allow" CssClass="btn btn-danger" ID="NotAllow" OnClick="NotAllow_Click" Visible="false" />
            <asp:Button runat="server" OnClientClick="false" Text="Allow" CssClass="btn btn-success" ID="Allow" OnClick="Allow_Click" Visible="false" />
        </div>

    </div>

</asp:Content>