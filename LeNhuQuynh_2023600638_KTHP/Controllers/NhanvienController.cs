using LeNhuQuynh_2023600638_KTHP.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web.Http;

namespace LeNhuQuynh_2023600638_KTHP.Controllers
{
    public class NhanvienController : ApiController
    {
        QLNVEntities1 db = new QLNVEntities1();

        [HttpGet]
        public List<Nhanvien> DanhsachNV()
        {
            return db.Nhanviens.ToList();
        }

        [HttpPost]
        public bool ThemNhanVien(int ma, string ten, string trinhdo, int luong)
        {
            Nhanvien nv = db.Nhanviens.FirstOrDefault(x => x.MaNV == ma);
            if (nv == null)
            {
                nv = new Nhanvien();
                nv.MaNV = ma;
                nv.HoTen = ten;
                nv.TrinhDo = trinhdo;
                nv.Luong = luong;
                db.Nhanviens.Add(nv);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        [HttpDelete]
        public bool XoaNhanVien(int ma)
        {
            Nhanvien nv = db.Nhanviens.FirstOrDefault(x => x.MaNV == ma);
            if(nv  != null)
            {
                db.Nhanviens.Remove(nv);
                db.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
