<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Tacher.Master" AutoEventWireup="true" CodeFile="DashBoard.aspx.cs" Inherits="Attendance_management_system.Teacher.DashBoard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css" integrity="sha512-DTOQO9RWCH3ppGqcWaEA1BIZOC6xxalwEsw9c2QQeAIftl+Vegovlnee1c9QX4TctnWMn13TZye+giMm8e2LwA==" crossorigin="anonymous" referrerpolicy="no-referrer" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="container mt-2" style="height: 100px; background-color: white; border-radius: 10px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);">
    <div class="row">
        <div class="col-6 border-end d-flex border-primary">
            <div class="col-2">
                <img style="width: 100px; height: 100px;" src="../Image/graduate.png" id="graduateimg" runat="server" />
            </div>

            <div class="row-1 ps-5 m-auto text-center fs-5">
                <span>Total Present</span>
                <br />
                <span>10000</span>
            </div>
        </div>

        <div class="col-6 d-flex">
            <div class="col-2">

                <img style="width: 100px; height: 100px;" src="../Image/graduate.png" id="Img1" runat="server" />
            </div>

            <div class="row-1 ps-5 m-auto text-center fs-5">
                <span>Total Absent</span>
                <br />
                <span>10000</span>
            </div>

        </div>

    </div>
</section>

    <section class="mt-4">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-striped table-responsive table-hover" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
        <Columns>
            <asp:TemplateField HeaderText="Id">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Subject Name">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("SubjectName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Year">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("Year") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Semter">
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("Semister") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField SelectText="Take" ShowSelectButton="True" HeaderText="Take Attendance"></asp:CommandField>
        </Columns>
    </asp:GridView>
        </section>
</asp:Content>