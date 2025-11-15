using BaiThucHanhTrenLopBuoi5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BaiThucHanhTrenLopBuoi5.Controllers
{
    public class SanPhamController : ApiController
    {

        CSDLTestEntities db = new CSDLTestEntities();

        [HttpGet]
        public List<SanPham> getAll()
        {
            return db.SanPhams.ToList();
        }

        [HttpGet]
        public List<SanPham> GetByMaDanhMuc(int madm)
        {
            return db.SanPhams.Where(x => x.MaDanhMuc == madm).ToList();
        }

        [HttpGet]
        public SanPham getSanPham(int ma)
        {
            return db.SanPhams.Where(x=> x.Ma == ma).FirstOrDefault();
        }

        [HttpPost]
        public bool ThenSanPham(int ma, string ten, int gia, int madm)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == ma);

            if(sp == null)
            {
                SanPham sp1 = new SanPham();
                sp1.Ma = ma;
                sp1.Ten = ten;
                sp1.DonGia = gia;
                sp1.MaDanhMuc = madm;
                db.SanPhams.Add(sp1);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        [HttpPut]
        public bool CapNhat(int ma, string ten, int gia, int madm)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == ma);
            if(sp != null)
            {
                sp.Ma = ma;
                sp.Ten = ten;
                sp.DonGia = gia;
                sp.MaDanhMuc = madm;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        [HttpDelete]
        public bool Xoa(int ma)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == ma);
            if(sp!=null)
            {
                db.SanPhams.Remove(sp);
                db.SaveChanges();
                return true;
            }
            return false;
        }


    }
}
