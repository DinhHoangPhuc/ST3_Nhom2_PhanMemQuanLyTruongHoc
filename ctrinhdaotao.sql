create database QL_TruongDH
go
use QL_TruongDH
go
CREATE TABLE Khoa (
    id INT PRIMARY KEY IDENTITY(1,1), 
    TenKhoa VARCHAR(255) NOT NULL
);
CREATE TABLE Nganh (
    id INT PRIMARY KEY IDENTITY(1,1), 
    TenNganh VARCHAR(255) NOT NULL,
    id_khoa INT,
    FOREIGN KEY (id_khoa) REFERENCES Khoa(id)
);
CREATE TABLE ChuongTrinhDaoTao (
    id INT PRIMARY KEY IDENTITY(1,1), 
    id_nganh INT,
    TenHocPhan VARCHAR(255),
    SoTinChi INT,
    GhiChu VARCHAR(255),
    Diem1 int,
	Diem2 int,
    HocKy INT,
    FOREIGN KEY (id_nganh) REFERENCES Nganh(id)
);
INSERT INTO Khoa (TenKhoa) VALUES 
('Công nghệ thông tin'), 
('Quản trị kinh doanh');
INSERT INTO Nganh (TenNganh, id_khoa) VALUES 
('Ngành CNTT', 1),
('Ngành ATTT', 1),
('Ngành KHDL', 1),
('Ngành QTKD', 2),
('Ngành KDQT', 2),
('Marketing', 2),
('TMDT', 2),
('Logistics', 2);

INSERT INTO ChuongTrinhDaoTao (id_nganh, TenHocPhan, SoTinChi, GhiChu, Diem1, Diem2, HocKy) VALUES
-------------------------------------------------Ngành CNTT----------------------------------
---------------------------------------------------------------------------------------------
--Học kỳ 1
(1, N'Triết học Mác-Lênin', 3, NULL,3,7, 1),
(1, N'Kinh tế chính trị Mác-Lênin', 2, NULL, 3,7, 1),
(1, N'Đại số tuyến tính', 2, NULL, 3,7, 1),
(1, N'Kỹ năng ứng dụng công nghệ thông tin', 3, NULL, 3,7, 1),
(1, N'Xác xuất và thống kê trong sản xuất, công nghệ, kỹ thuật', 2, NULL, 3,7, 1),
(1, N'Giáo dục quốc phòng - an ninh 1', 3, N'Không tích lũy', 4,6, 1),
(1, N'Nguyên lý ngôn ngữ lập trình', 2, NULL, 3,7, 1),
(1, N'Thực hành nguyên lý ngôn ngữ lập trình', 2, NULL, 3,7, 1),
-- Học kỳ 2
(1, N'Tư tưởng Hồ Chí Minh', 2, NULL, 3,7, 2),
(1, N'Anh văn 1', 3, NULL, 5,5, 2),
(1, N'Giáo dục thể chất 1', 2, N'Không tích lũy', 3,7, 2),
(1, N'Giáo dục quốc phòng - an ninh 2', 2, N'Không tích lũy', 3,7, 2),
(1, N'Mạng máy tính', 3, NULL, 3,7, 2),
(1, N'Thực hành Mạng máy tính', 1, NULL, 3,7, 2),
(1, N'Cấu trúc dữ liệu và giải thuật', 2, NULL, 3,7, 2),
(1, N'Thực hành cấu trúc dữ liệu và giải thuật', 1, NULL, 3,7, 2),
--Học phần tự chọn
(1, N'Giải tích', 3, NULL, 3,7, 2),
(1, N'Quy hoạch thực nghiệm', 2, NULL, 3,7, 2),
(1, N'Logic học', 2, NULL, 3,7, 2),
(1, N'Đổi mới sáng tạo và khởi nghiệp', 2, NULL, 3,7, 2),
(1, N'Phương pháp nghiên cứu khoa học', 2, NULL, 3,7, 2),
-- Học kỳ 3
(1, N'Chủ nghĩa xã hội khoa học', 2, NULL, 3,7, 3),
(1, N'Anh văn 2', 3, NULL,3,7 , 3),
(1, N'Giáo dục thể chất 2', 2, N'Không tích lũy', 4,6, 3),
(1, N'Giáo dục quốc phòng - an ninh 3', 1, N'Không tích lũy', 4,6, 3),
(1, N'Giáo dục quốc phòng - an ninh 4', 2, N'Không tích lũy', 4,6, 3),
(1, N'Kiến trúc máy tính', 3, NULL, 4,6, 3),
(1, N'Hệ điều hành', 3, NULL, 3,7, 3),
(1, N'Cấu trúc rời rạc', 3, NULL, 3,7, 3),
(1, N'Kỹ thuật lập trình', 2, NULL, 3,7, 3),
(1, N'Thực hành kỹ thuật lập trình', 1, NULL, 3,7, 3),
-- Học kỳ 4
(1, N'Lịch sử Đảng Cộng sản Việt Nam', 2, NULL, 3,7, 4),
(1, N'Anh văn 3', 3, NULL, 5,5, 4),
(1, N'Giáo dục thể chất 3', 1, N'Không tích lũy', 4,6, 4),
(1, N'Hệ cơ sở dữ liệu', 3, NULL, 5,5, 4),
(1, N'Thực hành hệ cơ sở dữ liệu', 1, NULL, 3,7, 4),
(1, N'Lập trình hướng đối tượng', 3, NULL, 3,7, 4),
(1, N'Thực hành lập trình hướng đối tượng', 1, NULL, 3,7, 4),
(1, N'Bảo mật máy tính', 2, NULL, 3,7, 4),
--Học phần tự chọn
(1, N'Lập trình Python', 3, NULL, 3,7, 4),
(1, N'Thiết kế Web', 3, NULL, 3,7, 4),
(1, N'Mã hóa và ứng dụng', 3, NULL, 3,7, 4),
-- Học kỳ 5
(1, N'Trí tuệ nhân tạo', 3, NULL, 3,7, 5),
(1, N'Thực hành trí tuệ nhân tạo', 1, NULL, 3,7, 5),
(1, N'Công nghệ phần mềm', 3, NULL, 3,7, 5),
(1, N'Hệ quản trị cơ sở dữ liệu', 3, NULL, 3,7, 5),
(1, N'Lập trình Web', 3, NULL, 3,7, 5),
--Học phần tự chọn
(1, N'Phân tích thiết kế thuật toán', 3, NULL, 3,7, 5),
(1, N'Lập trình mạng', 3, NULL, 3,7, 5),
(1, N'Ảo hóa và điện toán đám mây', 3, NULL, 3,7, 5),
(1, N'Công nghệ Java', 3, NULL, 3,7, 5),
(1, N'Bảo mật Cơ sở dữ liệu', 3, NULL, 3,7, 5),
(1, N'Xử lý ảnh', 3, NULL, 3,7, 5),
-- Học kỳ 6
(1, N'Lập trình di động', 3, NULL, 3,7, 6),
(1, N'Deep learning', 3, NULL, 3,7, 6),
(1, N'Thực hành Deep learning', 1, NULL, 3,7, 6),
(1, N'Khai phá dữ liệu', 3, NULL, 3,7, 6),
(1, N'Quản trị hệ thống mạng', 3, NULL, 3,7, 6),
(1, N'Thực hành Quản trị hệ thống mạng', 1, NULL, 3,7, 6),
(1, N'Phân tích thiết kế hệ thống', 2, NULL, 3,7, 6),
(1, N'Thực hành phân tích thiết kế hệ thống', 1, NULL, 3,7, 6),
-- Học phần tự chọn Học kỳ 6
(1, N'Công nghệ .NET', 3, NULL, 3,7, 6),
(1, N'Công nghệ phần mềm nâng cao', 3, NULL, 3,7, 6),
(1, N'Kiểm định phần mềm', 3, NULL, 3,7, 6),
(1, N'Thương mại điện tử', 3, NULL, 3,7, 6),
-- Học kỳ 7
(1, N'Nhập môn Big Data', 2, NULL, 3,7, 7),
(1, N'Thực hành nhập môn Big Data', 1, NULL, 3,7, 7),
(1, N'Internet of Things', 3, NULL, 3,7, 7),
(1, N'Thực tập nghề nghiệp', 2, NULL, 3,7, 7),
(1, N'Khóa luận cử nhân', 4, NULL, 3,7, 7),
-- Học phần tự chọn Học kỳ 7
(1, N'Lập trình mã nguồn mở', 2, NULL, 3,7, 7),
(1, N'Dữ liệu NoSQL', 2, NULL, 3,7, 7),
(1, N'An toàn mạng máy tính', 2, NULL, 3,7, 7),
(1, N'Thực hành An toàn mạng máy tính', 2, NULL, 3,7, 7),
-- Học kỳ 8
(1, N'Công tác kỹ sư', 2, NULL, 3,7, 8),
(1, N'Chuyên đề công nghệ mới và chuyển đổi số', 3, NULL, 3,7, 8),
(1, N'Học máy nâng cao', 3, NULL, 3,7, 8),
(1, N'Thực tập kỹ sư', 8, NULL, 3,7, 8),
(1, N'Khóa luận kỹ sư', 14, NULL, 3,7, 8),
----------------------------------------------------Ngành ATTT------------------------------------------------
--------------------------------------------------------------------------------------------------------------
-- Học kỳ 1
(2, N'Triết học Mác-Lênin', 3, NULL, 3,7, 1),
(2, N'Kinh tế chính trị Mác-Lênin', 2, NULL, 3,7, 1),
(2, N'Đại số tuyến tính', 2, NULL, 3,7, 1),
(2, N'Kỹ năng ứng dụng công nghệ thông tin', 3, NULL, 3,7, 1),
(2, N'Xác xuất và thống kê trong sản xuất, công nghệ, kỹ thuật', 2, NULL, 3,7, 1),
(2, N'Giáo dục quốc phòng - an ninh 1', 3, N'Không tích lũy', 4,6, 1),
(2, N'Nguyên lý ngôn ngữ lập trình', 2, NULL, 3,7, 1),
(2, N'Thực hành nguyên lý ngôn ngữ lập trình', 2, NULL, 4,6, 1),
-- Học kỳ 2
(2, N'Tư tưởng Hồ Chí Minh', 2, NULL, 3,7, 2),
(2, N'Anh văn 1', 3, NULL, 5,5, 2),
(2, N'Giáo dục thể chất 1', 2, N'Không tích lũy', 4,6, 2),
(2, N'Giáo dục quốc phòng - an ninh 2', 2, N'Không tích lũy', 4,6, 2),
(2, N'Mạng máy tính', 3, NULL, 4,6, 2),
(2, N'Thực hành Mạng máy tính', 1, NULL, 3,7, 2),
(2, N'Cấu trúc dữ liệu và giải thuật', 2, NULL, 3,7, 2),
(2, N'Thực hành cấu trúc dữ liệu và giải thuật', 1, NULL, 3,7, 2),
-- Học phần tự chọn Học kỳ 2
(2, N'Giải tích', 3, NULL, 3,7, 2),
(2, N'Quy hoạch thực nghiệm', 2, NULL, 3,7, 2),
(2, N'Logic học', 2, NULL, 3,7, 2),
(2, N'Đổi mới sáng tạo và khởi nghiệp', 2, NULL, 3,7, 2),
(2, N'Phương pháp nghiên cứu khoa học', 2, NULL, 3,7, 2),
-- Học kỳ 3
(2, N'Chủ nghĩa xã hội khoa học', 2, NULL, 3,7, 3),
(2, N'Anh văn 2', 3, NULL, 5,5, 3),
(2, N'Giáo dục thể chất 2', 2, N'Không tích lũy', 4,6, 3),
(2, N'Giáo dục quốc phòng - an ninh 3', 1, N'Không tích lũy', 4,6, 3),
(2, N'Giáo dục quốc phòng - an ninh 4', 2, N'Không tích lũy', 4,6, 3),
(2, N'Kiến trúc máy tính', 3, NULL, 3,7, 3),
(2, N'Hệ điều hành', 3, NULL, 3,7, 3),
(2, N'Cấu trúc rời rạc', 3, NULL, 3,7, 3),
(2, N'Lập trình hướng đối tượng', 2, NULL, 3,7, 3),
(2, N'Thực hành lập trình hướng đối tượng', 1, NULL, 3,7, 3),
-- Học kỳ 4
(2, N'Lịch sử Đảng Cộng sản Việt Nam', 2, NULL, 3,7, 4),
(2, N'Anh văn 3', 3, NULL, 5,5, 4),
(2, N'Giáo dục thể chất 3', 1, NULL, 4,6, 4),
(2, N'Hệ cơ sở dữ liệu', 3, NULL, 5,5, 4),
(2, N'Thực hành hệ cơ sở dữ liệu', 1, NULL, 3,7, 4),
(2, N'Công nghệ phần mềm', 3, NULL, 3,7, 4),
(2, N'Bảo mật máy tính', 2, NULL, 3,7, 4),
-- Học phần tự chọn Học kỳ 4
(2, N'Lập trình Python', 3, NULL, 3,7, 4),
(2, N'Thiết kế Web', 3, NULL, 3,7, 4),
-- Học kỳ 5
(2, N'Trí tuệ nhân tạo', 3, NULL, 3,7, 5),
(2, N'Thực hành trí tuệ nhân tạo', 1, NULL, 3,7, 5),
(2, N'Bảo mật Cơ sở dữ liệu', 3, NULL, 3,7, 5),
(2, N'Mã hóa và ứng dụng', 3, NULL, 3,7, 5),
(2, N'Quản trị hệ thống mạng', 3, NULL, 3,7, 5),
(2, N'Thực hành quản trị hệ thống mạng', 1, NULL, 3,7, 5),
-- Học phần tự chọn Học kỳ 5
(2, N'Phân tích thiết kế thuật toán', 3, NULL, 3,7, 5),
(2, N'Lập trình mạng', 3, NULL, 3,7, 5),
(2, N'Ảo hóa và điện toán đám mây', 3, NULL, 3,7, 5),
(2, N'Bảo mật sinh trắc', 3, NULL, 3,7, 5),
(2, N'Kỹ thuật dịch ngược', 3, NULL, 3,7, 5),
-- Học kỳ 6
(2, N'An toàn mạng máy tính', 2, NULL, 3,7, 6),
(2, N'Thực hành An toàn mạng máy tính', 1, NULL, 3,7, 6),
(2, N'Hạ tầng mạng', 3, NULL, 3,7, 6),
(2, N'Thực hành Hạ tầng mạng', 1, NULL, 3,7, 6),
(2, N'Phân tích lỗ hổng và kiểm thử', 2, NULL, 3,7, 6),
(2, N'Thực hành phân tích lỗ hổng và kiểm thử', 2, NULL, 3,7, 6),
(2, N'Bảo mật web và ứng dụng', 3, NULL, 3,7, 6),
-- Học phần tự chọn Học kỳ 6
(2, N'Lập trình mã nguồn mở', 2, NULL, 3,7, 6),
(2, N'Bằng chứng số', 3, NULL, 3,7, 6),
(2, N'Hệ thống phát hiện và ngăn ngừa xâm nhập', 2, NULL, 3,7, 6),
(2, N'Thực hành hệ thống phát hiện và ngăn ngừa xâm nhập', 1, NULL, 3,7, 6),
(2, N'Nhập môn Big Data', 2, NULL, 3,7, 6),
(2, N'Thực hành nhập môn Big Data', 1, NULL, 3,7, 6),
(2, N'An toàn và bảo mật Thương mại điện tử', 2, NULL, 3,7, 6),
-- Học kỳ 7
(2, N'Học máy cho bảo mật', 3, NULL, 3,7, 7),
(2, N'Thực hành học máy cho bảo mật', 1, NULL, 3,7, 7),
(2, N'Internet of Things', 3, NULL, 3,7, 7),
(2, N'Thực tập nghề nghiệp', 2, NULL, 3,7, 7),
(2, N'Khóa luận cử nhân', 4, NULL, 3,7, 7),
-- Học phần tự chọn Học kỳ 7
(2, N'An toàn mạng không dây và di động', 2, NULL, 3,7, 7),
(2, N'Thực hành an toàn mạng không dây và di động', 1, NULL, 3,7, 7),
(2, N'Phân tích và xử lý mã độc', 2, NULL, 3,7, 7),
(2, N'Thực hành phân tích và xử lý mã độc', 1, NULL, 3,7, 7),
(2, N'Bảo mật thông tin cho nhà quản lý', 2, NULL, 3,7, 7),
(2, N'Thực hành bảo mật thông tin cho nhà quản lý', 1, NULL, 3,7, 7),
-- Học kỳ 8
(2, N'Công tác kỹ sư', 2, NULL, 3,7, 8),
(2, N'Chuyên đề công nghệ mới và chuyển đổi số', 3, NULL, 3,7, 8),
(2, N'Học máy nâng cao', 3, NULL, 3,7, 8),
(2, N'Thực tập kỹ sư', 8, NULL, 3,7, 8),
(2, N'Khóa luận kỹ sư', 14, NULL, 3,7, 8),
------------------------------------------------------------------Ngành Khoa học dữ liệu-------------------------------
-----------------------------------------------------------------------------------------------------------------------
-- Học kỳ 1
(3, N'Triết học Mác-Lênin', 3, NULL, 3,7, 1),
(3, N'Tư tưởng Hồ Chí Minh', 2, NULL, 3,7, 1),
(3, N'Kỹ năng ứng dụng công nghệ thông tin', 3, NULL, 3,7, 1),
(3, N'Giải tích', 3, NULL, 3,7, 1),
(3, N'Giáo dục quốc phòng - an ninh 1', 3, N'Không tích lũy', 4,6, 1),
(3, N'Nhập môn Khoa học dữ liệu', 2, NULL, 3,7, 1),
(3, N'Cơ sở lập trình', 3, NULL, 3,7, 1),

-- Học kỳ 2
(3, N'Anh văn 1', 3, NULL, 5,5, 2),
(3, N'Đại số tuyến tính', 2, NULL, 3,7, 2),
(3, N'Giáo dục thể chất 1', 2, N'Không tích lũy', 4,6, 2),
(3, N'Giáo dục quốc phòng - an ninh 2', 2, N'Không tích lũy', 4,6, 2),
(3, N'Xác suất và thống kê trong sản xuất, công nghệ, kỹ thuật', 2, NULL, 3,7, 2),
(3, N'Cấu trúc dữ liệu và giải thuật', 2, NULL, 3,7, 2),
(3, N'Thực hành cấu trúc dữ liệu và giải thuật', 1, NULL, 3,7, 2),
(3, N'Lập trình hướng đối tượng', 2, NULL, 3,7, 2),
(3, N'Thực hành lập trình hướng đối tượng', 1, NULL, 3,7, 2),

-- Học kỳ 3
(3, N'Anh văn 2', 3, NULL, 5,5, 3),
(3, N'Giáo dục thể chất 2', 2, N'Không tích lũy', 4,6, 3),
(3, N'Giáo dục quốc phòng - an ninh 3', 1, N'Không tích lũy', 4,6, 3),
(3, N'Quy hoạch thực nghiệm', 2, NULL, 3,7, 3),
(3, N'Hệ điều hành', 3, NULL, 3,7, 3),
(3, N'Cấu trúc rời rạc', 3, NULL, 3,7, 3),
(3, N'Hạ tầng hệ thống', 3, NULL, 3,7, 3),
(3, N'Lập trình phân tích dữ liệu', 3, NULL, 3,7, 3),

-- Học kỳ 4
(3, N'Kinh tế chính trị Mác - Lênin', 2, NULL, 3,7, 4),
(3, N'Anh văn 3', 3, NULL, 5,5, 4),
(3, N'Giáo dục thể chất 3', 1, N'Không tích lũy', 4,6, 4),
(3, N'Giáo dục quốc phòng - an ninh 4', 2, N'Không tích lũy', 4,6, 4),
(3, N'Hệ cơ sở dữ liệu', 3, NULL, 5,5, 4),
(3, N'Thực hành hệ cơ sở dữ liệu', 1, NULL, 3,7, 4),
(3, N'Lập trình IoT', 3, NULL, 3,7, 4),

-- Học phần tự chọn học kỳ 4
(3, N'Trí tuệ nhân tạo cho Khoa học dữ liệu', 3, NULL, 3,7, 4),
(3, N'Thiết kế Web', 3, NULL, 3,7, 4),
(3, N'Mã hóa và ứng dụng', 3, NULL, 3,7, 4),
(3, N'Lập trình di động', 3, NULL, 3,7, 4),
(3, N'Học máy cho bảo mật', 3, NULL, 3,7, 4),
(3, N'Mạng máy tính', 3, NULL, 3,7, 4),

-- Học kỳ 5
(3, N'Chủ nghĩa xã hội khoa học', 2, NULL, 3,7, 5),
(3, N'Xây dựng kho dữ liệu', 3, NULL, 3,7, 5),
(3, N'Lập trình Web', 3, NULL, 3,7, 5),
(3, N'Khai phá dữ liệu', 3, NULL, 3,7, 5),
(3, N'Nhập môn HTTT quản lý', 3, NULL, 3,7, 5),

-- Học phần tự chọn (nhóm A) học kỳ 5
(3, N'Ứng dụng trí tuệ nhân tạo', 3, NULL, 3,7, 5),
(3, N'Công nghệ Java', 3, NULL, 3,7, 5),
(3, N'Bảo mật Cơ sở dữ liệu', 3, NULL, 3,7, 5),
(3, N'Xử lý ảnh', 3, NULL, 3,7, 5),
(3, N'Tin sinh học', 3, NULL, 3,7, 5),

-- Học kỳ 6
(3, N'Lịch sử Đảng Cộng Sản Việt Nam', 2, NULL, 3,7, 6),
(3, N'Deep learning', 3, NULL, 3,7, 6),
(3, N'Thực hành Deep learning', 1, NULL, 3,7, 6),
(3, N'Kỹ thuật phân tích dữ liệu', 3, NULL, 3,7, 6),
(3, N'Thực hành Kỹ thuật phân tích dữ liệu', 1, NULL, 3,7, 6),
(3, N'Phân tích dữ liệu doanh nghiệp', 3, NULL, 3,7, 6),

-- Học phần tự chọn (nhóm A và B) học kỳ 6
(3, N'Công nghệ .NET', 3, NULL, 3,7, 6),
(3, N'Thương mại điện tử', 3, NULL, 3,7, 6),
(3, N'Bảo mật web và ứng dụng', 3, NULL, 3,7, 6),
(3, N'Dữ liệu NoSQL', 2, NULL, 3,7, 6),
(3, N'Bảo mật sinh trắc', 2, NULL, 3,7, 6),
(3, N'Lập trình mã nguồn mở', 2, NULL, 3,7, 6),

-- Học kỳ 7
(3, N'Dữ liệu lớn cho Khoa học dữ liệu', 2, NULL, 3,7, 7),
(3, N'Thực hành dữ liệu lớn cho Khoa học dữ liệu', 1, NULL, 3,7, 7),
(3, N'Xử lý ngôn ngữ tự nhiên', 2, NULL, 3,7, 7),
(3, N'Thực hành xử lý ngôn ngữ tự nhiên', 1, NULL, 3,7, 7),
(3, N'Tính riêng tư trong phân tích dữ liệu', 3, NULL, 3,7, 7),
(3, N'Thực tập nghề nghiệp', 2, NULL, 3,7, 7),
(3, N'Khóa luận cử nhân', 4, NULL, 3,7, 7),

-- Học kỳ 8
(3, N'Công tác kỹ sư', 2, NULL, 3,7, 8),
(3, N'Chuyên đề công nghệ mới và chuyển đổi số', 3, NULL, 3,7, 8),
(3, N'Học máy nâng cao', 3, NULL, 3,7, 8),
(3, N'Thực tập kỹ sư', 8, NULL, 3,7, 8),
(3, N'Khóa luận kỹ sư', 14, NULL, 3,7, 8),
----------------------------------------------------------Ngành QTKD------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------
--Học kỳ 1
(4, N'Triết học Mác - Lênin', 3, NULL, 3,7, 1),
(4, N'Kinh tế vi mô', 3, NULL, 3,7, 1),
(4, N'Kỹ năng ứng dụng công nghệ thông tin', 3, NULL, 3,7, 1),
(4, N'Kinh tế chính trị Mác - Lênin', 2, NULL, 4,6, 1),
(4, N'Quản trị học', 2, NULL, 4,6, 1),
(4, N'Giáo dục quốc phòng - an ninh 1', 3, N'Không tích lũy', 4,6, 1),
--Học phần tự chọn
(4, N'Toán cao cấp C1', 3, NULL, 3,7, 1),
(4, N'Kinh tế lượng', 3, NULL, 3,7 , 1),
--Học kỳ 2
(4, N'Giáo dục thể chất 1', 2, N'Không tích lũy', 4,6, 2),
(4, N'Lịch sử Đảng Cộng sản Việt Nam', 2, NULL, 4,6, 2),
(4, N'Pháp luật đại cương', 2, NULL, 3,7, 2),
(4, N'Giáo dục quốc phòng - an ninh 2', 2, N'Không tích lũy', 4,6, 2),
(4, N'Marketing căn bản', 2, NULL, 3,7, 2),
(4, N'Anh văn 1', 3, NULL, 5,5, 2),
(4, N'Kinh tế vi mô', 3, NULL, 3,7, 2),
--Học phần tự chọn
(4, N'Xác suất và thống kê trong kinh tế, dịch vụ', 2, NULL, 3,7, 2),
(4, N'Toán cao cấp C2', 2, NULL, 3,7, 2),
--Học kỳ 3
(4, N'Anh văn 2', 3, NULL, 5,5, 3),
(4, N'Giáo dục thể chất 2', 2, N'Không tích lũy', 4,6, 3),
(4, N'Giáo dục quốc phòng - an ninh 3', 1, N'Không tích lũy', 4,6, 3),
(4, N'Tư tưởng Hồ Chí Minh', 2, NULL, 3,7, 3),
(4, N'Nguyên lý kế toán', 3, NULL, 3,7, 3),
(4, N'Hành vi người tiêu dùng', 3, NULL, 3,7, 3),
(4, N'Hành vi tổ chức', NULL, NULL, 3,7, 3),
--Học phần tự chọn
(4, N'Tâm lý học kinh doanh', 2, NULL, 3,7, 3),
(4, N'Kỹ năng giao tiếp', 2, NULL, 3,7, 3),
(4, N'Lý thuyết tài chính tiền tệ', 3, NULL, 3,7, 3),
(4, N'Thị trường tài chính', 3, NULL, 3,7, 3),
--Học kỳ 4
(4, N'Anh văn 3', 3, NULL, 5,5, 4),
(4, N'Giáo dục thể chất 3', 1, N'Không tích lũy', 4,6, 4),
(4, N'Giáo dục quốc phòng - an ninh 4', 2, N'Không tích lũy', 4,6, 4),
(4, N'Thống kê ứng dụng', 3, NULL, 3,7, 4),
(4, N'Internet marketing', 3, NULL, 3,7, 4),
(4, N'Nghiên cứu thị trường', 3, NULL, 3,7, 4),
(4, N'Phân tích hoạt động kinh doanh', 3, NULL, 3,7, 4),
--Học phần tự chọn
(4, N'Đạo đức kinh doanh và văn hóa doanh nghiệp', 2, NULL, 3,7, 4),
(4, N'Kỹ năng đàm phán', 2, NULL, 3,7, 4),
(4, N'Quan hệ công chúng', 2, NULL, 3,7, 4),
--Học kỳ 5
(4, N'Kế toán quản trị', 3, NULL, 3,7, 5),
(4, N'Quản trị tài chính', 3, NULL, 3,7, 5),
(4, N'Quản trị nguồn nhân lực', 3, NULL, 3,7, 5),
(4, N'Quản trị chất lượng', 3, NULL, 3,7, 5),
(4, N'Quản trị bán hàng', 3, NULL, 3,7, 5),
(4, N'Quản trị dự án đầu tư', 3, NULL, 3,7, 5),
--Học phần tự chọn
(4, N'Nghệ thuật lãnh đạo', 2, NULL, 3,7, 5),
(4, N'Tổ chức tiền lương trong doanh nghiệp', 2, NULL, 3,7, 5),
(4, N'Thư tín thương mại trong kinh doanh', 2, NULL, 3,7, 5),
--Học kỳ 6
(4, N'Quản trị chiến lược', 3, NULL, 3,7, 6),
(4, N'Quản trị thương hiệu', 2, NULL, 3,7, 6),
(4, N'Lập kế hoạch kinh doanh', 3, NULL, 3,7, 6),
(4, N'Quản trị kinh doanh quốc tế', 2, NULL, 3,7, 6),
(4, N'Quản trị vận hành', 3, NULL, 3,7, 6),
(4, N'Quản trị xuất nhập khẩu', 3, NULL, 3,7, 6),
(4, N'Logistics', 3, NULL, 3,7, 6),
--Học kỳ 7
(4, N'Kiến tập', 2, NULL, 3,7, 7),
(4, N'Thực tập nghề nghiệp', 5, NULL, 3,7, 7),
(4, N'Khóa luận tốt nghiệp', 8, NULL, 3,7, 7),
-------------------------------------------------------Ngành KDQT---------------------------------------------
--------------------------------------------------------------------------------------------------------------
-- Học kỳ 1: 16 tín chỉ tích lũy + 3 tín chỉ không tích lũy
(5, N'Giáo dục quốc phòng an ninh 1', 3, N'Không tích lũy', 4,6, 1),
(5, N'Pháp luật đại cương', 2, NULL, 3,7, 1),
(5, N'Triết học Mác - Lênin', 3, NULL, 3,7, 1),
(5, N'Kỹ năng ứng dụng CNTT', 3, NULL, 3,7, 1),
(5, N'Kinh tế vi mô', 3, NULL, 3,7, 1),
(5, N'Quản trị học', 2, NULL, 3,7, 1),
(5, N'Toán cao cấp C1', 3, NULL, 3,7, 1),

-- Học kỳ 2: 15 tín chỉ tích lũy + 4 tín chỉ không tích lũy
(5, N'Kinh tế chính trị Mác - Lênin', 2, NULL, 3,7, 2),
(5, N'Giáo dục quốc phòng - an ninh 2', 2, N'Không tích lũy', 4,6, 2),
(5, N'Giáo dục thể chất 1', 2, N'Không tích lũy', 4,6, 2),
(5, N'Anh văn 1', 3, NULL, 5,5, 2),
(5, N'Marketing căn bản', 2, NULL, 3,7, 2),
(5, N'Kinh tế viĩ mô', 3, NULL, 3,7, 2),
(5, N'Nguyên lý kế toán', 3, NULL, 3,7, 2),
--Học phần tự chọn
(5, N'Toán cao cấp C2', 2, NULL, 3,7, 2),
(5, N'Xác suất và thống kê trong kinh tế, dịch vụ', 2, NULL, 3,7, 2),

-- Học kỳ 3: 16 tín chỉ tích lũy + 3 tín chỉ không tích lũy
(5, N'Giáo dục quốc phòng - an ninh 3', 1, N'Không tích lũy', 4,6, 3),
(5, N'Giáo dục thể chất 2', 2, N'Không tích lũy', 4,6, 3),
(5, N'Tài chính quốc tế', 3, NULL, 3,7, 3),
(5, N'Chủ nghĩa xã hội khoa học', 2, NULL, 3,7, 3),
(5, N'Thống kê ứng dụng', 3, NULL, 3,7, 3),
(5, N'Anh văn 2', 3, NULL, 5,5, 3),
--Học phần tự chọn
(5, N'Tài chính doanh nghiệp', 3, NULL, 3,7, 3),
(5, N'Lý thuyết tài chính tiền tệ', 3, NULL, 3,7, 3),
(5, N'Tâm lý học kinh doanh', 2, NULL, 3,7, 3),
(5, N'Kỹ năng giao tiếp', 2, NULL, 3,7, 3),
(5, N'Logic học', 2, NULL, 3,7, 3),

-- Học kỳ 4: 18 tín chỉ tích lũy + 3 tín chỉ không tích lũy
(5, N'Giáo dục quốc phòng - an ninh 4', 2, N'Không tích lũy', 4,6, 4),
(5, N'Giáo dục thể chất 3', 1, N'Không tích lũy', 4,6, 4),
(5, N'Lịch sử Đảng Cộng sản Việt Nam', 2, NULL, 3,7, 4),
(5, N'Anh văn 3', 3, NULL, 5,5, 4),
(5, N'Quản trị nguồn nhân lực', 3, NULL, 3,7, 4),
(5, N'Quản trị chiến lược', 3, NULL, 3,7, 4),
(5, N'Kinh tế quốc tế', 3, NULL, 3,7, 4),
--Học phần tự chọn
(5, N'Luật kinh tế', 2, NULL, 3,7, 4),
(5, N'Chính sách thương mại quốc tế', 2, NULL, 3,7, 4),
(5, N'Luật thương mại quốc tế', 2, NULL, 3,7, 4),
(5, N'Doanh nghiệp xã hội', 2, NULL, 3,7, 4),
(5, N'Phương pháp nghiên cứu khoa học trong kinh doanh', 2, NULL, 3,7, 4),
(5, N'Hành vi tổ chức', 2, NULL, 3,7, 4),

-- Học kỳ 5: 21 tín chỉ tích lũy + 0 tín chỉ không tích lũy
(5, N'Tư tưởng Hồ Chí Minh', 2, NULL, 3,7, 5),
(5, N'Thanh toán quốc tế', 2, NULL, 3,7, 5),
(5, N'Quản trị rủi ro kinh doanh quốc tế', 3, NULL, 3,7, 5),
(5, N'Đầu tư quốc tế', 3, NULL, 3,7, 5),
(5, N'Quản trị dự án đầu tư', 3, NULL, 3,7, 5),
(5, N'Truyền thông marketing tích hợp', 3, NULL, 3,7, 5),
(5, N'Logistics', 3, NULL, 3,7, 5),
--Học phần tự chọn
(5, N'Đạo đức kinh doanh và văn hóa doanh nghiệp', 2, NULL, 3,7, 5),
(5, N'Quản trị quan hệ khách hàng', 2, NULL, 3,7, 5),

-- Học kỳ 6: 20 tín chỉ tích lũy + 0 tín chỉ không tích lũy
(5, N'Quản trị thương hiệu', 2, NULL, 3,7, 6),
(5, N'Đàm phán trong thương mại quốc tế', 2, NULL, 3,7, 6),
(5, N'Vận tải và giao nhận hàng quốc tế', 3, NULL, 3,7, 6),
(5, N'Quản trị chuỗi cung ứng', 3, NULL, 3,7, 6),
(5, N'Quản trị xuất nhập khẩu', 3, NULL, 3,7, 6),
(5, N'Khai báo hải quan', 3, NULL, 3,7, 6),
(5, N'Marketing quốc tế', 2, NULL, 3,7, 6),
--Học phần tự chọn
(5, N'Quản trị đa văn hóa', 2, NULL, 3,7, 6),
(5, N'Bảo hiểm trong kinh doanh', 2, NULL, 3,7, 6),
(5, N'Thư tín thương mại trong kinh doanh', 2, NULL, 3,7, 6),

-- Học kỳ 7: 15 tín chỉ tích lũy + 0 tín chỉ không tích lũy
(5, N'Kiến tập', 2, NULL, 3,7, 7),
(5, N'Thực tập nghề nghiệp', 5, NULL, 3,7, 7),
(5, N'Khóa luận tốt nghiệp', 8, NULL, 3,7, 7),
--------------------------------------------------------Marketing-------------------------------------------
------------------------------------------------------------------------------------------------------------
--Học kỳ 1
(6, N'Triết học Mác-Lênin', 3, NULL, 3,7, 1),
(6, N'Kinh tế vi mô', 3, NULL, 3,7, 1),
(6, N'Kỹ năng ứng dụng công nghệ thông tin', 3, NULL, 3,7, 1),
(6, N'Kinh tế chính trị Mác-Lênin', 2, NULL, 3,7, 1),
(6, N'Quản trị học', 2, NULL, 3,7, 1),
(6, N'Giáo dục quốc phòng - an ninh 1', 3, N'Không tích lũy', 4,6, 1),
--Tự chọn
(6, N'Toán cao cấp C1', 3, NULL, 3,7, 1),
(6, N'Kinh tế lượng', 3, NULL, 3,7, 1),
--Học kỳ 2
(6, N'Chủ nghĩa xã hội khoa học', 2, NULL, 3,7, 2),
(6, N'Giáo dục quốc phòng - an ninh 2', 2, N'Không tích lũy', 4,6, 2),
(6, N'Giáo dục thể chất 1', 2, N'Không tích lũy', 4,6, 2),
(6, N'Anh văn 1', 3, NULL, 5,5, 2),
(6, N'Marketing căn bản', 2, NULL, 3,7, 2),
(6, N'Kinh tế vĩ mô', 3, NULL, 3,7, 2),
(6, N'Pháp luật đại cương', 2, NULL, 3,7, 2),
(6, N'Lịch sử Đảng Cộng sản Việt Nam', 2, NULL, 3,7, 2),
--Tự chọn
(6, N'Toán cao cấp C2', 2, NULL, 3,7, 2),
(6, N'Xác suất và thống kê trong kinh tế, dịch vụ', 2, NULL, 3,7, 2),
--Học kỳ 3
(6, N'Giáo dục quốc phòng - an ninh 3', 1, N'Không tích lũy', 4,6, 3),
(6, N'Giáo dục thể chất 2', 2, N'Không tích lũy', 4,6, 3),
(6, N'Anh văn 2', 3, NULL, 5,5, 3),
(6, N'Nghiên cứu thị trường', 3, NULL, 3,7, 3),
(6, N'Marketing dịch vụ', 3, NULL, 3,7, 3),
(6, N'Nguyên lý kế toán', 3, NULL, 3,7, 3),
--Tự chọn
(6, N'Tài chính doanh nghiệp', 3, NULL, 3,7, 3),
(6, N'Lý thuyết tài chính tiền tệ', 3, NULL, 3,7, 3),
(6, N'Phân tích hoạt động kinh doanh', 3, NULL, 3,7, 3),
(6, N'Tâm lý học kinh doanh', 2, NULL, 3,7, 3),
(6, N'Kỹ năng giao tiếp', 2, NULL, 3,7, 3),
(6, N'Logic học', 2, NULL, 3,7, 3),
--Học kỳ 4
(6, N'Giáo dục quốc phòng - an ninh 4', 2, N'Không tích lũy', 4,6, 4),
(6, N'Giáo dục thể chất 3', 1, N'Không tích lũy', 4,6, 4),
(6, N'Anh văn 3', 3, N'Không tích lũy', 5,5, 4),
(6, N'Quản trị nguồn nhân lực', 3, NULL, 3,7, 4),
(6, N'Quản trị chiến lược', 3, NULL, 3,7, 4),
(6, N'Thống kê ứng dụng', 3, NULL, 3,7, 4),
(6, N'Thực hành quảng cáo', 2, NULL, 3,7, 4),
--Tự chọn
(6, N'Luật kinh tế', 2, NULL, 3,7, 4),
(6, N'Luật thương mại quốc tế', 2, NULL, 3,7, 4),
(6, N'Quản trị kênh phân phối', 2, NULL, 3,7, 4),
(6, N'Quản trị quan hệ khách hàng', 2, NULL, 3,7, 4),
(6, N'Quan hệ công chúng', 2, NULL, 3,7, 4),
--Học kỳ 5
(6, N'Tư tưởng Hồ Chí Minh', 2, NULL, 3,7, 5),
(6, N'Marketing thương mại', 2, NULL, 3,7, 5),
(6, N'Marketing kỹ thuật số', 3, NULL, 3,7, 5),
(6, N'Hành vi người tiêu dùng', 3, NULL, 3,7, 5),
(6, N'Marketing công cụ tìm kiếm', 3, NULL, 3,7, 5),
(6, N'Truyền thông marketing tích hợp', 3, NULL, 3,7, 5),
(6, N'Quản trị chuỗi cung ứng', 3, NULL, 3,7, 5),
--Tự chọn
(6, N'Quản trị thương hiệu', 2, NULL, 3,7, 5),
(6, N'Đạo đức kinh doanh và văn hóa doanh nghiệp', 2, NULL, 3,7, 5),
(6, N'Marketing quốc tế', 2, NULL, 3,7, 5),
(6, N'Truyền thông trong kinh doanh', 2, NULL, 3,7, 5),
(6, N'Kỹ năng đàm phán', 2, NULL, 3,7, 5),
--Học kỳ 6
(6, N'Quản trị bán hàng', 3, NULL, 3,7, 6),
(6, N'Marketing truyền thông mạng xã hội và di động', 3, NULL, 3,7, 6),
(6, N'Marketing trực tiếp', 3, NULL, 3,7, 6),
(6, N'Sáng tạo nội dung số', 3, NULL, 3,7, 6),
(6, N'B2B marketing', 3, NULL, 3,7, 6),
(6, N'Xây dựng kế hoạch marketing', 3, NULL, 3,7, 6),
--Học kỳ 7
(6, N'Kiến tập', 2, NULL, 3,7, 7),
(6, N'Thực tập nghề nghiệp', 5, NULL, 3,7, 7),
(6, N'Khóa luận tốt nghiệp', 8, NULL, 3,7, 7),
---------------------------------------------------------TMDT---------------------------------------------
----------------------------------------------------------------------------------------------------------
--Học kỳ 1
(7, N'Triết học Mác-Lênin', 3, NULL, 3,7, 1),
(7, N'Kinh tế vi mô', 3, NULL, 3,7, 1),
(7, N'Kỹ năng ứng dụng công nghệ thông tin', 3, NULL, 3,7, 1),
(7, N'Kinh tế chính trị Mác-Lênin', 2, NULL, 3,7, 1),
(7, N'Quản trị học', 2, NULL, 3,7, 1),
(7, N'Giáo dục quốc phòng - an ninh 1', 3, N'Không tích lũy', 4,6, 1),
--Tự chọn
(7, N'Toán cao cấp C1', 3, NULL, 3,7, 1),
(7, N'Kinh tế lượng', 3, NULL, 3,7, 1),
--Học kỳ 2
(7, N'Chủ nghĩa xã hội khoa học', 2, NULL, 3,7, 2),
(7, N'Giáo dục quốc phòng - an ninh 2', 2, N'Không tích lũy', 4,6, 2),
(7, N'Giáo dục thể chất 1', 2, N'Không tích lũy', 4,6, 2),
(7, N'Anh văn 1', 3, NULL, 5,5, 2),
(7, N'Marketing căn bản', 2, NULL, 3,7, 2),
(7, N'Kinh tế vĩ mô', 3, NULL, 3,7, 2),
(7, N'Pháp luật đại cương', 2, NULL, 3,7, 2),
(7, N'Lịch sử Đảng Cộng sản Việt Nam', 2, NULL, 3,7, 2),
--Tự chọn
(7, N'Toán cao cấp C2', 2, NULL, 3,7, 2),
(7, N'Xác suất và thống kê trong kinh tế, dịch vụ', 2, NULL, 3,7, 2),
--Học kỳ 3
(7, N'Giáo dục thể chất 2', 2, N'Không tích lũy', 4,6, 3),
(7, N'Giáo dục quốc phòng - an ninh 3', 1, N'Không tích lũy', 4,6, 3),
(7, N'Anh văn 2', 3, NULL, 5,5, 3),
(7, N'Thống kê ứng dụng', 3, NULL, 3,7, 3),
(7, N'Điện toán đám mây', 3, NULL, 3,7, 3),
(7, N'Cơ sở lập trình', 3, NULL, 3,7, 3),
--Tự chọn
(7, N'Tâm lý học kinh doanh', 2, NULL, 3,7, 3),
(7, N'Kỹ năng giao tiếp', 2, NULL, 3,7, 3),
(7, N'Sáng tạo nội dung số', 3, NULL, 3,7, 3),
(7, N'Nghiên cứu thị trường', 3, NULL, 3,7, 3),
--Học kỳ 4
(7, N'Giáo dục quốc phòng - an ninh 4', 2, N'Không tích lũy', 4,6, 4),
(7, N'Giáo dục thể chất 3', 1, N'Không tích lũy', 4,6, 4),
(7, N'Anh văn 3', 3, NULL, 5,5, 4),
(7, N'Nguyên lý kế toán', 3, NULL, 3,7, 4),
(7, N'Thương mại điện tử', 3, NULL, 3,7, 4),
(7, N'Cơ sở dữ liệu trong vận hành doanh nghiệp', 4, NULL, 3,7, 4),
(7, N'Tư tưởng Hồ Chí Minh', 2, NULL, 3,7, 4),
--Tự chọn
(7, N'Khởi nghiệp kinh doanh', 3, NULL, 3,7, 4),
(7, N'Quản trị bán hàng', 3, NULL, 3,7, 4),
--Học kỳ 5
(7, N'Pháp luật thương mại điện tử', 3, NULL, 3,7, 5),
(7, N'Marketing kỹ thuật số', 3, NULL, 3,7, 5),
(7, N'Thanh toán điện tử', 3, NULL, 3,7, 5),
(7, N'Quản trị chất lượng', 3, NULL, 3,7, 5),
(7, N'Phân tích dữ liệu', 3, NULL, 3,7, 5),
(7, N'Thiết kế web', 3, NULL, 3,7, 5),
(7, N'Bảo mật thương mại điện tử', 3, NULL, 3,7, 5),
--Học kỳ 6
(7, N'Quản trị tác nghiệp thương mại điện tử', 3, NULL, 3,7, 6),
(7, N'Quản trị chuỗi cung ứng', 3, NULL, 3,7, 6),
(7, N'Chiến lược kinh doanh thương mại điện tử', 3, NULL, 3,7, 6),
(7, N'Phân tích dữ liệu lớn', 3, NULL, 3,7, 6),
(7, N'Khai phá dữ liệu', 3, NULL, 3,7, 6),
--Tự chọn
(7, N'Phát triển ứng dụng di động', 3, NULL, 3,7, 6),
(7, N'Phân tích ngôn ngữ tự nhiên', 3, NULL, 3,7, 6),
(7, N'Trực quan hóa', 3, NULL, 3,7, 6),
--Học kỳ 7
(7, N'Kiến tập', 2, NULL, 3,7, 7),
(7, N'Thực tập nghề nghiệp', 5, NULL, 3,7, 7),
(7, N'Khóa luận tốt nghiệp', 8, NULL, 3,7, 7),
-----------------------------------------------------Logistics-------------------------------------
---------------------------------------------------------------------------------------------------
--Học kỳ 1
(8, N'Triết học Mác - Lênin', 3, NULL, 3,7, 1),
(8, N'Kinh tế vi mô', 3, NULL, 3,7, 1),
(8, N'Quản trị học', 3, NULL, 3,7, 1),
(8, N'Nguyên lý kế toán', 3, NULL, 3,7, 1),
(8, N'Anh văn 1', 2, NULL, 5,5, 1),
(8, N'Toán cao cấp C1', 3, NULL, 3,7, 1),
--Học kỳ 2
(8, N'Giáo dục thể chất 1', 2, N'Không tích lũy', 4,6, 2),
(8, N'Giáo dục quốc phòng - an ninh 1', 3, N'Không tích lũy', 4,6, 2),
(8, N'Giáo dục quốc phòng - an ninh 2', 2, N'Không tích lũy', 4,6, 2),
(8, N'Giáo dục quốc phòng - an ninh 3', 1, N'Không tích lũy', 4,6, 2),
(8, N'Giáo dục quốc phòng - an ninh 4', 2, N'Không tích lũy', 4,6, 2),
(8, N'Kinh tế chính trị Mác - Lênin', 2, NULL, 3,7, 2),
(8, N'Pháp luật đại cương', 2, NULL, 3,7, 2),
(8, N'Anh văn 2', 2, NULL, 5,5, 2),
(8, N'Kinh tế vĩ mô', 3, NULL, 5,5, 2),
--Tự chọn
(8, N'Toán cao cấp C2', 2, NULL, 3,7, 2),
(8, N'Xác suất và thống kê', 3, NULL, 3,7, 2),
--Học kỳ 3
(8, N'Giáo dục thể chất 2', 2, N'Không tích lũy', 4,6, 3),
(8, N'Chủ nghĩa xã hội khoa học', 2, NULL, 3,7, 3),
(8, N'Marketing căn bản', 3, NULL, 3,7, 3),
(8, N'Thống kê ứng dụng', 3, NULL, 3,7, 3),
(8, N'Anh văn 3', 2, NULL, 5,5, 3),
--Tự chọn
(8, N'Tâm lý học kinh doanh', 2, NULL, 3,7, 3),
(8, N'Kỹ năng giao tiếp', 2, NULL, 3,7, 3),
(8, N'Tài chính doanh nghiệp', 3, NULL, 3,7, 3),
(8, N'Lý thuyết tài chính tiền tệ', 3, NULL, 3,7, 3),
(8, N'Marketing kỹ thuật số', 3, NULL, 3,7, 3),
(8, N'Marketing quốc tế', 3, NULL, 3,7, 3),
(8, N'Marketing toàn cầu', 3, NULL, 3,7, 3),
(8, N'Mô hình kinh doanh số', 3, NULL, 3,7, 3),
--Học kỳ 4
(8, N'Giáo dục thể chất 3', 1, N'Không tích lũy', 4,6, 4),
(8, N'Lịch sử Đảng Cộng sản Việt Nam', 2, NULL, 3,7, 4),
(8, N'Quản trị vận hành', 3, NULL, 3,7, 4),
(8, N'Quản trị chất lượng', 3, NULL, 3,7, 4),
(8, N'Quản trị Logistics', 3, NULL, 3,7, 4),
(8, N'Quản trị chuỗi cung ứng', 3, NULL, 3,7, 4),
--Tự chọn
(8, N'Luật kinh tế', 2, NULL, 3,7, 4),
(8, N'Luật thương mại quốc tế', 2, NULL, 3,7, 4),
(8, N'Kinh tế quốc tế', 3, NULL, 3,7, 4),
(8, N'Đầu tư quốc tế', 3, NULL, 3,7, 4),
(8, N'Đạo đức kinh doanh và văn hóa doanh nghiệp', 3, NULL, 3,7, 4),
--Học kỳ 5
(8, N'Tư tưởng Hồ Chí Minh', 2, NULL, 3,7, 5),
(8, N'Quản trị nguồn nhân lực', 3, NULL, 3,7, 5),
(8, N'Quản trị chiến lược', 3, NULL, 3,7, 5),
(8, N'Quản trị xuất nhập khẩu', 3, NULL, 3,7, 5),
(8, N'Quản trị kho hàng và tồn kho', 3, NULL, 3,7, 5),
--tự chọn
(8, N'Thương mại điện tử', 3, NULL, 3,7, 5),
(8, N'Khởi nghiệp kinh doanh', 3, NULL, 3,7, 5),
(8, N'Quản trị dự án logistics và chuỗi cung ứng', 3, NULL, 3,7, 5),
(8, N'Quản trị rủi ro kinh doanh quốc tế', 3, NULL, 3,7, 5),
--Học kỳ 6
(8, N'Vận tải và giao nhận hàng hóa quốc tế', 3, NULL, 3,7, 6),
(8, N'Khai báo hải quan', 3, NULL, 3,7, 6),
(8, N'Đàm phán trong thương mại quốc tế', 3, NULL, 3,7, 6),
(8, N'Quản trị thu mua toàn cầu', 3, NULL, 3,7, 6),
(8, N'Hệ thống thông tin logistics', 3, NULL, 3,7, 6),
(8, N'Tiếng Anh chuyên ngành', 3, NULL, 3,7, 6),
--Tự chọn
(8, N'Quản trị trung tâm phân phối', 3, NULL, 3,7, 6),
(8, N'Quản trị vận tải đa phương thức', 3, NULL, 3,7, 6),
--Học kỳ 7
(8, N'Kiến tập', 2, NULL, 3,7, 7),
(8, N'Thực tập tốt nghiệp', 4, NULL, 3,7, 7),
(8, N'Khóa luận tốt nghiệp', 6, NULL, 3,7, 7),
(8, N'Thiết kế giải pháp logistics và chuỗi cung ứng', 3, NULL, 3,7, 7);

