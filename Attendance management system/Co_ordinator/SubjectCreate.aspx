<%@ Page Title="" Language="C#" MasterPageFile="~/Co_ordinator/Co_ordinator.Master" AutoEventWireup="true" CodeFile="SubjectCreate.aspx.cs" Inherits="Attendance_management_system.Co_ordinator.SubjectCreate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="bg-white shadow pt-2 pb-2 rounded">

        <div class="col ps-4 border rounded ms-5 me-5">

            <div class="row col-12 col-lx-12 mt-3">
                <div class="form-group">
                    <asp:Label Text="Enter the Course name" runat="server" />
                    <asp:TextBox runat="server" ID="SubjectName" TextMode="SingleLine" CssClass="form-control mt-1" />
                </div>
            </div>

            <div class="row col-12 col-lx-12 mt-3">
                <div class="form-group">
                    <asp:Label Text="Select Subject Teacher" runat="server" />
                    <asp:DropDownList ID="SubjectTeacher" runat="server" CssClass="form-control" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="id">
                    </asp:DropDownList>
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:AMSConnectionString %>' SelectCommand="SELECT [id], [name] FROM [TeacherstaffDetail] WHERE ([DepatmentName] = @DepatmentName)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="Department" PropertyName="Text" Name="DepatmentName" Type="String"></asp:ControlParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
                </div>
            </div>

            <div class="row col-12 col-lx-12 mt-3">
                <div class="form-group">
                    <asp:Label Text="Select Department" runat="server" />
                    <asp:TextBox runat="server" ID="Department" TextMode="SingleLine" CssClass="form-control mt-1" Enabled="false" />
                </div>
            </div>

            <div class="row col-12 col-lx-12 mt-3">
                <div class="form-grom">
                    <asp:Label runat="server" Text="Select Year" />
                    <asp:DropDownList ID="Year" runat="server" CssClass="form-control">
                        <asp:ListItem Value="1 Year">1 Year</asp:ListItem>
                        <asp:ListItem Value="2 Year">2 Year</asp:ListItem>
                        <asp:ListItem Value="3 Year">3 Year</asp:ListItem>
                        <asp:ListItem Value="4 Year">4 Year</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <div class="row col-12 col-lx-12 mt-3">
                <div class="form-grom">
                    <asp:Label runat="server" Text="Select Year" />
                    <asp:DropDownList ID="Semister" runat="server" CssClass="form-control">
                        <asp:ListItem Value="1 Semister">1 Semister</asp:ListItem>
                        <asp:ListItem Value="2 Semister">2 Semister</asp:ListItem>
                        <asp:ListItem Value="3 Semister">3 Semister</asp:ListItem>
                        <asp:ListItem Value="4 Semister">4 Semister</asp:ListItem>
                        <asp:ListItem Value="5 Semister">5 Semister</asp:ListItem>
                        <asp:ListItem Value="6 Semister">6 Semister</asp:ListItem>
                        <asp:ListItem Value="7 Semister">7 Semister</asp:ListItem>
                        <asp:ListItem Value="8 Semister">8 Semister</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <div class="row col-12 col-lx-12 mt-3">
                <div class="form-group">
                    <asp:Label runat="server" Text="Select Course" CssClass="from-control" />
                    <asp:TextBox runat="server" ID="course" TextMode="SingleLine" CssClass="form-control mt-1" Enabled="false" />
                </div>
            </div>

            <asp:Button runat="server" Text="Create Subject" ID="createSubject" OnClick="createSubject_Click" CssClass="btn btn-info mt-3 mb-3" />

        </div>
    </div>

</asp:Content>
