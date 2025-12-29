using KTHP_SERVER_p2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Common;

namespace KTHP_SERVER_p2.Controllers
{
    public class SanPhamController : ApiController
    {
        CSDLTestEntities db = new CSDLTestEntities();

        [HttpGet]
        public List<SanPham> getAllSanPham()
        {
            return db.SanPhams.ToList();
        }

        [HttpGet]
        public List<SanPham> getByMaSanPham(int ma)
        {
            return db.SanPhams.Where(x => x.MaSanPham == ma).ToList();
        }

        [HttpPost]
        public bool createSanPham(int ma, string ten, int gia, int madm)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x=> x.MaSanPham == ma);
            if(sp != null)
            {
                return false;
            }
            else
            {
                sp = new SanPham();
                sp.MaSanPham = ma;
                sp.TenSanPham = ten;
                sp.DonGia = gia;
                sp.MaDanhMuc = madm;
                db.SanPhams.Add(sp);
                db.SaveChanges();
                return true;
            }
        }

        [HttpDelete]
        public bool deleteSanPham(int ma)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.MaSanPham == ma);
            if (sp == null)
            {
                return false;
            }
            else
            {
                db.SanPhams.Remove(sp);                
                db.SaveChanges();
                return true;
            }
        }

        [HttpPatch]
        public bool updateSanPham(int ma, string ten, int gia, int madm)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.MaSanPham == ma);
            if(sp == null)
            {
                return false;
            }
            else
            {
                sp.TenSanPham = ten;
                sp.DonGia = gia;
                sp.MaDanhMuc = madm;
                db.SaveChanges();
                return true;
            }
        }



    }
}
