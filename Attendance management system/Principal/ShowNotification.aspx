﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/principal.Master" AutoEventWireup="true" CodeFile="ShowNotification.aspx.cs" Inherits="Attendance_management_system.Principal.ShowNotification" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="mt-3 ms-3 me-3 bg-white rounded shadow">

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CssClass="table table-bordered table-striped table-hover table-responsive rounded" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
            <Columns>
                <asp:TemplateField HeaderText="id">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Notification Title">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("NotificationTitle") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Notification Descirption">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Notification_Desciption") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Notification To">
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("Notofication_To") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowSelectButton="True" SelectText="View" HeaderText="View Notification" />
            </Columns>
        </asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AMSConnectionString %>" SelectCommand="SELECT [id], [NotificationTitle], [Notification_Desciption], [Notofication_To] FROM [Notification] WHERE ([Notification_From] = @Notification_From)">
            <SelectParameters>
                <asp:SessionParameter Name="Notification_From" SessionField="AccountID" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>


    </div>


</asp:Content>
