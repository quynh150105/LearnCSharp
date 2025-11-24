using BaiThucHanhTrenLopBuoi6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BaiThucHanhTrenLopBuoi6.Controllers
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
        public List<SanPham> getByMaSanPham(int maSanPham)
        {
            return db.SanPhams.Where(x => x.MaSanPham == maSanPham).ToList();
        }

        [HttpGet]
        public List<SanPham> getByMaDanhMuc(int maDanhMuc)
        {
            return db.SanPhams.Where(x => x.MaDanhMuc == maDanhMuc).ToList();
        }

        [HttpPost]
        public bool CreateSanPham(int ma, string ten, int dongia, int madanhmuc)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.MaSanPham == ma);
            if (sp == null)
            {
                sp = new SanPham();
                sp.MaSanPham = ma;
                sp.TenSanPham = ten;
                sp.DonGia = dongia;
                sp.MaDanhMuc = madanhmuc;
                db.SanPhams.Add(sp);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        [HttpPut]
        public bool UpdateSanPham(int ma, string ten, int dongia, int madanhmuc)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.MaSanPham == ma);
            if(sp!=null)
            {
                sp.TenSanPham = ten;
                sp.DonGia = dongia;
                sp.MaDanhMuc = madanhmuc;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        [HttpDelete]
        public bool DeleteSanPham(int maSanPham)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.MaSanPham == maSanPham);
            if (db != null)
            {
                db.SanPhams.Remove(sp);
                db.SaveChanges();
                return true;
            }
            return false;
        }



    }
}
