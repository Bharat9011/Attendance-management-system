<%@ Page Title="" Language="C#" MasterPageFile="~/HOD/HOD.Master" AutoEventWireup="true" CodeFile="DashBoard.aspx.cs" Inherits="Attendance_management_system.HOD.DashBoard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/chart.min.js"></script>
    <script src="../Scripts/chart.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css" integrity="sha512-DTOQO9RWCH3ppGqcWaEA1BIZOC6xxalwEsw9c2QQeAIftl+Vegovlnee1c9QX4TctnWMn13TZye+giMm8e2LwA==" crossorigin="anonymous" referrerpolicy="no-referrer" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="container mt-2" style="height: 100px; background-color: white; border-radius: 10px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);">
        <div class="row">
            <div class="col-3 border-end d-flex border-primary">
                <div class="col-2">
                    <img style="width: 100px; height: 100px;" src="../Image/graduate.png" id="graduateimg" runat="server" />
                </div>

                <div class="row-1 ps-5 m-auto text-center fs-5">
                    <span>Total Present</span>
                    <br />
                    <span>10000</span>
                </div>
            </div>

            <div class="col-3 border-end d-flex border-primary">
                <div class="col-2">

                    <img style="width: 100px; height: 100px;" src="../Image/graduate.png" id="Img1" runat="server" />
                </div>

                <div class="row-1 ps-5 m-auto text-center fs-5">
                    <span>Total Absent</span>
                    <br />
                    <span>10000</span>
                </div>

            </div>

            <div class="col-3 border-end d-flex border-primary">
                <div class="col-2">
                    <img style="width: 100px; height: 100px;" src="../Image/graduate.png" id="Img2" runat="server" />
                </div>

                <div class="row-1 ps-5 m-auto text-center fs-5">
                    <span>Total Course</span>
                    <br />
                    <asp:Label runat="server" ID="DepartmentCount" Text="Label"></asp:Label>
                </div>

            </div>

            <div class="col-3 d-flex">
                <div class="col-2">
                    <img style="width: 100px; height: 100px;" src="../Image/graduate.png" id="Img3" runat="server" />
                </div>

                <div class="row-1 ps-5 m-auto text-center fs-5">
                    <span>Total Teacher</span>
                    <br />
                    <asp:Label runat="server" ID="tacherCount" Text="Label"></asp:Label>
                </div>
            </div>
        </div>
    </section>

    <section runat="server" class="mt-3" style="width: fit-content; height: fit-content; display: flex;">

        <!-- chart for present by course -->

        <div id="chartContainer" class="w-50 h-25">

            <div id="Present" class="border p-2 border-primary-subtle" style="width: 400px; height: 210px;">
                <canvas id="PChart"></canvas>
            </div>

            <div id="Absent" class="mt-3 border p-2 border-primary-subtle" style="width: 400px; height: 210px;">
                <canvas id="AChart"></canvas>
            </div>
        </div>

        <!-- Notification -->

        <div style="width: 800px;" class="border border-1 border-primary ms-2">

            <div style="height: 50px; line-height: 50px; font-size: 20px; display: flex;" class="border border-top-0 border-end-0 border-start-0 border-1 border-black ps-3">
                Notification
                <div style="position: relative; left: 170px; right: 0; color: white; cursor: pointer;" class="bg-primary ps-2 pe-2">
                    <span class="" style="font-size: 15px; line-height: 50px;"><a class="text-white text-decoration-none" href="Notification.aspx">View More</a></span>
                </div>
           </div>

            <div class="container mt-2">

                <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered table-hover table-responsive table-striped" ShowHeader="false" DataSourceID="SqlDataSource1"></asp:GridView>

                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:AMSConnectionString %>' SelectCommand="SELECT [NotificationTitle] FROM [Notification] WHERE (([Notofication_To] = @Notofication_To) OR ([Notofication_To] = @Notofication_To2))">
                    <selectparameters>
                        <asp:Parameter DefaultValue="All (HOD,Teacher,Co-ordinator, Student)" Name="Notofication_To" Type="String"></asp:Parameter>
                        <asp:Parameter DefaultValue="HOD" Name="Notofication_To2" Type="String"></asp:Parameter>
                    </selectparameters>
                </asp:SqlDataSource>

            </div>
        </div>

        <div class="w-100 ms-5 mt-5">
            <div style="display: flex;">
                <a class="text-decoration-none text-black" href="CreateCourse.aspx">
                    <div style="width: 150px; height: 150px; padding-top: 40px;" class="border border-1 border-primary bg-white rounded">
                        <div class="ms-5 me-5 bg-black p-2 rounded" style="text-align: center;">
                            <span><i class="fa-solid fa-plus" style="color: #ffffff;"></i></span>
                        </div>
                        <div class="mt-3 text-center">
                            Add Course
                        </div>

                    </div>
                </a>
                <a class="text-decoration-none text-black" style="cursor: pointer;" href="TeacherAccountCreate.aspx">
                    <div style="width: 150px; height: 150px; padding-top: 40px;" class="border border-1 border-primary bg-white rounded ms-3">
                        <div class="ms-5 me-5 bg-black p-2 rounded" style="text-align: center;">
                            <span><i class="fa-solid fa-chalkboard-user" style="color: #ffffff;"></i></span>
                        </div>
                        <div class="mt-3 text-center">
                            Create Teacher ID
                        </div>
                    </div>
                </a>
            </div>

            <div style="display: flex;" class="mt-3">
                <a class="text-decoration-none text-black" href="ShowTeacherDeatail.aspx">
                    <div style="width: 150px; height: 150px; padding-top: 40px;" class="border border-1 border-primary bg-white rounded">
                        <div class="ms-5 me-5 bg-black p-2 rounded" style="text-align: center;">
                            <span><i class="fa-solid fa-person" style="color: #ffffff;"></i><i class="fa-solid fa-clipboard-list" style="color: #ffffff;"></i></span>
                        </div>
                        <div class="mt-3 text-center">
                            Show Teacher List
                        </div>
                    </div>
                </a>

                <a href="CourseList.aspx" style="cursor: pointer;" class="text-decoration-none text-black">
                    <div style="width: 150px; height: 150px; padding-top: 40px;" class="border border-1 border-primary bg-white rounded ms-3">
                        <div class="ms-5 me-5 bg-black p-2 rounded" style="text-align: center;">
                            <span><i class="fa-solid fa-clipboard-list" style="color: #ffffff;"></i></span>
                        </div>
                        <div class="mt-3 text-center">
                            Show Course List
                        </div>
                    </div>
                </a>
            </div>
        </div>
    </section>

    <script>

        const ctx = document.getElementById('PChart');

        new Chart(ctx, {
            type: 'bar',
            data: {

                datasets: [{
                    label: 'Total Present',
                    backgroundColor: ["red", "blue", "green", "blue", "red", "blue"],

                    data: [
                        { x: '1', y: 1 },
                        { x: '2', y: 2 },
                        { x: '3', y: 3 },
                        { x: '4', y: 4 },
                        { x: '5', y: 5 },
                        { x: '6', y: 6 },
                        { x: '7', y: 7 },
                        { x: '8', y: 8 },
                        { x: '9', y: 9 },
                        { x: '10', y: 10 },
                        { x: '11', y: 11 },
                    ],
                    borderWidth: 1
                }]
            },
            options: {
                scales: {
                    y: {
                        beginAtZero: true
                    }
                }
            }
        });

        const ctx1 = document.getElementById('AChart');

        new Chart(ctx1, {
            type: 'bar',
            data: {
                labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
                datasets: [{
                    label: 'Total absent',
                    backgroundColor: ["red", "blue", "green", "blue", "red", "blue"],
                    data: [12, 19, 3, 5, 2, 3],
                    borderWidth: 1
                }]
            },
            options: {
                scales: {
                    y: {
                        beginAtZero: true
                    }
                }
            }
        });

        ctx1.canvas.parentNode.style.height = '100px';

    </script>

</asp:Content>
