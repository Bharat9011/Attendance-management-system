﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/principal.Master" AutoEventWireup="true" CodeBehind="CreateDepartment.aspx.cs" Inherits="Attendance_management_system.Principal.CreateDepartment_aspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset class="border p-3 bg-white rounded">
        <legend class="w-auto">Create Department</legend>
        <div class="form-group">
            <label for="exampleInputEmail1">Department Name</label>
            <asp:TextBox runat="server" TextMode="SingleLine" ID="NameDepartment" class="form-control"></asp:TextBox>
        </div>
        <asp:Button runat="server" CssClass="btn btn-primary mt-3 align-items-center" Text="Submit" OnClick="Unnamed_Click" />
    </fieldset>
</asp:Content>
