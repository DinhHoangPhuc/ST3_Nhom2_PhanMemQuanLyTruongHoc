# Lecturer Attendance Management System 

## Overview
This project is a **WinForms desktop application** designed to manage lecturer attendance in a university setting. The application provides functionalities for calculating lecturer salaries, managing emulation points, exporting reports in Excel format, and displaying data analysis through charts. It also includes authentication and authorization features to ensure secure access.

## Features
- **Lecturer Salary Calculation**: Automatically calculates the salary of lecturers based on their attendance and other factors.
- **Management of Lecturer Emulation Points**: Tracks and manages the emulation points of lecturers.
- **Export Reports in Excel Format**: Allows users to export various reports in Excel format using Syncfusion.
- **Dashboard with Data Analysis**: Provides a dashboard that displays data analysis in chart format using LiveCharts.
- **Authentication and Authorization**: Ensures secure access to the application with user authentication and role-based authorization.

## Technologies Used
- **Syncfusion**: Used for exporting reports in Excel format.
- **LiveCharts**: Used for displaying charts and data analysis.
- **MaterialSkin**: Used for enhancing the UI with Material Design.
- **.NET Framework 4.5**: The application is built on the .NET Framework 4.5.
- **SQL Server**: Used as the database to store and manage data.

## Pictures demo of the project
- Login:
![login](https://github.com/DinhHoangPhuc/ST3_Nhom2_PhanMemQuanLyTruongHoc/blob/main/demo_picture/dang_nhap.png "Login")
- Dashboard:
![Dashboard](https://github.com/DinhHoangPhuc/ST3_Nhom2_PhanMemQuanLyTruongHoc/blob/main/demo_picture/dashboard.png "Dashboard")
- Caculates salary:
![Dashboard](https://github.com/DinhHoangPhuc/ST3_Nhom2_PhanMemQuanLyTruongHoc/blob/main/demo_picture/tinh_luong.png "Caculates salary")
- Export excel salary report:
![Dashboard](https://github.com/DinhHoangPhuc/ST3_Nhom2_PhanMemQuanLyTruongHoc/blob/main/demo_picture/luong_excel.png "Caculates salary")
- Management of Lecturer Emulation Points:
![Dashboard](https://github.com/DinhHoangPhuc/ST3_Nhom2_PhanMemQuanLyTruongHoc/blob/main/demo_picture/quan_ly_vi_pham.png "Caculates salary")
- Views salary for lecturer:
![Dashboard](https://github.com/DinhHoangPhuc/ST3_Nhom2_PhanMemQuanLyTruongHoc/blob/main/demo_picture/xem_tien_luong.png "Caculates salary")
- Authorization:
![Dashboard](https://github.com/DinhHoangPhuc/ST3_Nhom2_PhanMemQuanLyTruongHoc/blob/main/demo_picture/phan_quyen.png "Caculates salary")

## How to Run
To run this WinForms project, follow these steps:

1. **Clone the Repository**:  
   ```bash
   git clone https://github.com/DinhHoangPhuc/ST3_Nhom2_PhanMemQuanLyTruongHoc.git
2. **Open the Solution**:
- Open `QuanLyTruongDaiHoc.sln` in Visual Studio 2022.
3. **Restore NuGet Packages**:
- In Visual Studio, go to `Tools > NuGet Package Manager > Package Manager Console`.
- Run the following command to restore the required packages:
  ```bash
  Update-Package -reinstall
4. **Build the Solution**:
- Build the solution by clicking on `Build > Build Solution` in Visual Studio.
5. **Run the Application**:
- Set the startup project to `GUI` (right-click on the GUI project in Solution Explorer and select Set as Startup Project).
- Press F5 or click on the Start button to run the application.
