using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TinhLuong
    {
        private QLTLDataContext qltl;
        public TinhLuong()
        {
            qltl = new QLTLDataContext();
        }
        public List<dynamic> GetLuongTheoThangByMaGiangVien(string maGiangVien)
        {
            return qltl.TIENLUONGTHEOTHANGs
                       .Where(t => t.MAGIANGVIEN == maGiangVien)
                       .Select(t => new
                       {
                           t.MAGIANGVIEN,
                           t.THANGLUONG,
                           t.TONGTIETDAY,
                           t.TIENLUONG
                       }).ToList<dynamic>();
        }
        public List<GIANGVIEN> GetDanhSachGiangVien()
        {
            var gvlist = qltl.GIANGVIENs.ToList();
            return gvlist;
        }
        public List<TIENTIETVUOT> GetTienTietVuotByMaGiangVien(string maGiangVien)
        {
            var tblTietVuots = qltl.TIENTIETVUOTs
                                   .Where(tv => tv.MAGIANGVIEN == maGiangVien)
                                   .ToList();
            return tblTietVuots;
        }
        public int LayDiemThiDua(string maGiangVien, DateTime thangLuong)
        {
            return qltl.DIEMTHIDUATHEOTHANGs
                       .Where(d => d.MAGIANGVIEN == maGiangVien &&
                                   d.THANG.Year == thangLuong.Year &&
                                   d.THANG.Month == thangLuong.Month)
                       .Select(d => d.DIEMTHIDUA)
                       .FirstOrDefault() ?? 0;
        }
        public decimal LayMucTroCapChucVu(string maChucVu)
        {
            return (decimal)(qltl.CHUCVUs
                            .Where(cv => cv.MACHUCVU == maChucVu)
                            .Select(cv => cv.MUCTROCAPCHUCVU)
                            .FirstOrDefault() ?? 0);
        }
        public int LayDiemThiDuaTheoThang(string maGiangVien, DateTime thangLuong)
        {
            var diemThiDua = qltl.DIEMTHIDUATHEOTHANGs
                                 .Where(d => d.MAGIANGVIEN == maGiangVien &&
                                             d.THANG.Year == thangLuong.Year &&
                                             d.THANG.Month == thangLuong.Month)
                                 .Select(d => d.DIEMTHIDUA)
                                 .FirstOrDefault();

            return diemThiDua ?? 0;
        }
        public float LayHeSoChucVu(string maChucVu)
        {
            return (float)(qltl.CHUCVUs
                            .Where(cv => cv.MACHUCVU == maChucVu)
                            .Select(cv => cv.HESOCHUCVU)
                            .FirstOrDefault() ?? 0);
        }
        public float LayDonGiaTietVuot(string maGiangVien)
        {
            var bangCap = qltl.GV_BCs
                              .Where(gvbc => gvbc.MAGIANGVIEN == maGiangVien)
                              .Select(gvbc => gvbc.BANGCAP.DONGIATIETVUOT)
                              .FirstOrDefault();

            return (float)(bangCap ?? 0);
        }
        public string LayMaNamHoc(int namHoc)
        {
            return qltl.NAMHOCs
                       .Where(nh => nh.NAMBATDAU == namHoc)
                       .Select(nh => nh.MANAMHOC)
                       .FirstOrDefault();
        }
        public int LayTietLyThuyet(string maGiangVien, string maNamHoc)
        {
            var TietLT = qltl.THUCDAYs
                       .Where(td => td.MAGIANGVIEN == maGiangVien && td.MANAMHOC == maNamHoc)
                       .Select(td => td.SOTIETLYTHUYET)
                       .FirstOrDefault();
            return TietLT ?? 0;
        }
        public int LayTietThucHanh(string maGiangVien, string maNamHoc)
        {
            var TietTH = qltl.THUCDAYs
                       .Where(td => td.MAGIANGVIEN == maGiangVien && td.MANAMHOC == maNamHoc)
                       .Select(td => td.SOTIETTHUCHANH)
                       .FirstOrDefault();
            return TietTH ?? 0;
        }
        public float LayPhuCapThamNien(int thamNien)
        {
            if (thamNien < 5)
                return 0;
            return 0.05f + (thamNien - 5) * 0.01f;
        }

        public float TinhPhuCapThamNien(int? thamNienCongTac)
        {
            return LayPhuCapThamNien(thamNienCongTac ?? 0);
        }

        public float TinhLuongCung(float heSoLuong, float heSoChucVu, float mucLuongCoBan, float phuCapDungLop, float phuCapThamNien)
        {
            return (heSoLuong + heSoChucVu) * mucLuongCoBan * (1 + phuCapDungLop + phuCapThamNien)
                   - (heSoLuong + heSoChucVu) * mucLuongCoBan * (1 + phuCapThamNien) * 0.105f;
        }

        public decimal TinhTroCapThem(decimal mucTroCapChucVu, int diemThiDua)
        {
            decimal tyLeTroCap = (diemThiDua >= 8) ? 1 : (diemThiDua >= 6) ? 0.7m : (diemThiDua >= 4) ? 0.5m : 0.3m;
            return mucTroCapChucVu * tyLeTroCap;
        }

        public decimal TinhTongLuong(float luongCung, decimal troCapThem)
        {
            return (decimal)luongCung + troCapThem;
        }
        public string GetNamHoc(int year)
        {
            var namHoc = qltl.NAMHOCs.FirstOrDefault(nh => nh.NAMBATDAU == year);
            if (namHoc != null)
            {
                return namHoc.MANAMHOC;
            }
            else
            {
                return null;
            }
        }
        public void LuuLuongVaTietVuot(GIANGVIEN selectedGV, DateTime selectThang, string maNamHoc, float tongLuong, int tongTietDay, float donGiaTietVuotLyThuyet, float donGiaTietVuotThucHanh)
        {
            try
            {
                // Kiểm tra xem giảng viên đã có dữ liệu lương cho tháng này chưa
                var existingLuongRecord = qltl.TIENLUONGTHEOTHANGs
                                              .FirstOrDefault(t => t.MAGIANGVIEN == selectedGV.MAGIANGVIEN &&
                                                                   t.THANGLUONG.Year == selectThang.Year &&
                                                                   t.THANGLUONG.Month == selectThang.Month);

                if (existingLuongRecord != null)
                {
                    // Cập nhật nếu đã có bản ghi
                    existingLuongRecord.TONGTIETDAY = tongTietDay;
                    existingLuongRecord.TIENLUONG = tongLuong;
                }
                else
                {
                    // Thêm mới nếu chưa có bản ghi
                    TIENLUONGTHEOTHANG newLuongRecord = new TIENLUONGTHEOTHANG
                    {
                        MAGIANGVIEN = selectedGV.MAGIANGVIEN,
                        THANGLUONG = selectThang,
                        TONGTIETDAY = tongTietDay,
                        TIENLUONG = tongLuong
                    };
                    qltl.TIENLUONGTHEOTHANGs.InsertOnSubmit(newLuongRecord);
                }

                // Lưu vào cơ sở dữ liệu
                qltl.SubmitChanges();

                // Tính tiền tiết vượt
                int soTietLyThuyet = LayTietLyThuyet(selectedGV.MAGIANGVIEN, maNamHoc);
                int soTietThucHanh = LayTietThucHanh(selectedGV.MAGIANGVIEN, maNamHoc);

                // Tính số tiết vượt chuẩn
                int soTietVuotLyThuyet = Math.Max(0, soTietLyThuyet - 100);
                float soTietVuotThucHanh = Math.Max(0, soTietThucHanh - 200);
                float tienTietVuotLyThuyet = soTietVuotLyThuyet * donGiaTietVuotLyThuyet;
                float tienTietVuotThucHanh = soTietVuotThucHanh * donGiaTietVuotThucHanh;
                float tongTienTietVuot = tienTietVuotLyThuyet + tienTietVuotThucHanh;

                // Lưu vào bảng TIENTIETVUOT
                var existingTietVuotRecord = qltl.TIENTIETVUOTs
                                                 .FirstOrDefault(t => t.MAGIANGVIEN == selectedGV.MAGIANGVIEN &&
                                                                      t.MANAMHOC == maNamHoc);

                if (existingTietVuotRecord != null)
                {
                    // Cập nhật nếu đã có bản ghi
                    existingTietVuotRecord.SOTIETVUOTLYTHUYET = soTietVuotLyThuyet;
                    existingTietVuotRecord.SOTIETVUOTTHUCHANH = soTietVuotThucHanh;
                    existingTietVuotRecord.SOTIEN = tongTienTietVuot;
                }
                else
                {
                    // Thêm mới nếu chưa có bản ghi
                    TIENTIETVUOT newTietVuotRecord = new TIENTIETVUOT
                    {
                        MAGIANGVIEN = selectedGV.MAGIANGVIEN,
                        SOTIETVUOTLYTHUYET = soTietVuotLyThuyet,
                        SOTIETVUOTTHUCHANH = soTietVuotThucHanh,
                        SOTIEN = tongTienTietVuot,
                        MANAMHOC = maNamHoc
                    };
                    qltl.TIENTIETVUOTs.InsertOnSubmit(newTietVuotRecord);
                }

                // Lưu vào cơ sở dữ liệu
                qltl.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Có lỗi khi lưu dữ liệu: {ex.Message}");
            }
        }
        public void XoaLuongTheoThang(string maGiangVien)
        {
            try
            {
                var existingLuongRecord = qltl.TIENLUONGTHEOTHANGs.FirstOrDefault(t => t.MAGIANGVIEN == maGiangVien);
                if (existingLuongRecord != null)
                {
                    qltl.TIENLUONGTHEOTHANGs.DeleteOnSubmit(existingLuongRecord);
                    qltl.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Có lỗi khi xóa dữ liệu lương theo tháng: {ex.Message}");
            }
        }

        public void XoaTietVuot(string maGiangVien)
        {
            try
            {
                var existingTietVuotRecord = qltl.TIENTIETVUOTs.FirstOrDefault(t => t.MAGIANGVIEN == maGiangVien);
                if (existingTietVuotRecord != null)
                {
                    qltl.TIENTIETVUOTs.DeleteOnSubmit(existingTietVuotRecord);
                    qltl.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Có lỗi khi xóa dữ liệu tiết vượt: {ex.Message}");
            }
        }
    }
}
