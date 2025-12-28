using On_KTHP_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Common;

namespace On_KTHP_Server.Controllers
{
    public class NhanVienController : ApiController
    {
        QLNVEntities db = new QLNVEntities();

        [HttpGet]
        public List<Nhanvien> getAllNhanVien()
        {
            return db.Nhanviens.ToList();
        }

        [HttpPost]
        public bool ThemNhanVien(int manv, string hoten, string trinhdo, int luong)
        {
            Nhanvien nv = db.Nhanviens.FirstOrDefault(x => x.MaNV == manv);
            if (nv == null)
            {
                nv = new Nhanvien();
                nv.MaNV = manv;
                nv.HoTen = hoten;
                nv.TrinhDo = trinhdo;
                nv.Luong = luong;
                db.Nhanviens.Add(nv);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        [HttpPatch]
        public bool SuaNhanvien(int manv, string hoten, string trinhdo, int luong)
        {
            Nhanvien nhanvien = db.Nhanviens.FirstOrDefault(x => x.MaNV == manv);
            if(nhanvien == null)
            {
                return false;
            }
            else
            {
                nhanvien.HoTen = hoten;
                nhanvien.TrinhDo = trinhdo;
                nhanvien.Luong = luong;
                db.SaveChanges();
                return true;
            }

        }

        [HttpDelete]
        public bool XoaNhanVien(int manv)
        {
            Nhanvien nhanvien = db.Nhanviens.FirstOrDefault(x => x.MaNV == manv);

            if(nhanvien != null)
            {
                db.Nhanviens.Remove(nhanvien);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public Nhanvien getNhanVienByCriteria(int manv)
        {
            Nhanvien nhanvien = db.Nhanviens.FirstOrDefault(x => x.MaNV == manv);
            if(nhanvien == null)
            {
                return null;
            }
            else
            {
                return nhanvien;
            }

        }   

    }

}
