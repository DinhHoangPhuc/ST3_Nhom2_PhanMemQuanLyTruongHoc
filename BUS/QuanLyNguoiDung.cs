﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuanLyNguoiDung
    {
        QLTLDataContext qltl;

        public QuanLyNguoiDung()
        {
            qltl = new QLTLDataContext();
        }

        public List<NGUOIDUNG> GetListNguoiDung()
        {
            return qltl.NGUOIDUNGs.ToList();
        }

        public NGUOIDUNG GetNguoiDungByUsername(string username)
        {
            return qltl.NGUOIDUNGs.Where(nd => nd.TENDANGNHAP == username).FirstOrDefault();
        }

        public List<NGUOIDUNG> GetListNguoiDungByUsername(string username)
        {
            return qltl.NGUOIDUNGs.Where(nd => nd.TENDANGNHAP.Contains(username)).ToList();
        }

        public void AddNguoiDung(NGUOIDUNG nguoiDung)
        {
            qltl.NGUOIDUNGs.InsertOnSubmit(nguoiDung);
            qltl.SubmitChanges();
        }

        public void UpdateNguoiDung(NGUOIDUNG nguoiDung)
        {
            NGUOIDUNG nd = qltl.NGUOIDUNGs.Where(n => n.TENDANGNHAP == nguoiDung.TENDANGNHAP).FirstOrDefault();
            if (nd != null)
            {
                nd.MATKHAU = nguoiDung.MATKHAU;
                nd.HOATDONG = nguoiDung.HOATDONG;
                qltl.SubmitChanges();
            }
        }

        public string GetAutoGeneratedUsername()
        {
            string username = "ND";
            int max = 0;
            foreach (NGUOIDUNG nd in qltl.NGUOIDUNGs)
            {
                string[] parts = nd.TENDANGNHAP.Split(new string[] { "ND" }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    int num = 0;
                    if (int.TryParse(parts[1], out num))
                    {
                        if (num > max)
                        {
                            max = num;
                        }
                    }
                }
            }
            max++;
            username += max.ToString();
            return username;
        }

        public string GetAutoGeneratedPassword()
        {
            return "password123";
        }

        public bool InsertNguoiDung(string tenDangNhap, string matKhau, bool hoatDong)
        {
            try
            {
                NGUOIDUNG nGUOIDUNG = new NGUOIDUNG();
                nGUOIDUNG.TENDANGNHAP = tenDangNhap;
                nGUOIDUNG.MATKHAU = matKhau;
                nGUOIDUNG.HOATDONG = hoatDong;

                qltl.NGUOIDUNGs.InsertOnSubmit(nGUOIDUNG);
                qltl.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}