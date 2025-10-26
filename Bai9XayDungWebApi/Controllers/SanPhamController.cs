using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai9XayDungWebApi.Controllers
{
    public class SanPhamController : ApiController
    {
        [HttpGet]
        public List<SanPham> getAllSanPham() {

            CSDLTestDataContext context = new CSDLTestDataContext();
            List<SanPham> dsSanPham = context.SanPhams.ToList();
            foreach(SanPham sp in dsSanPham)
            {
                sp.DanhMuc = null;
            }
            return dsSanPham;

        }
        [HttpGet]
        public SanPham getSanPham(int id)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            SanPham sp = context.SanPhams
                .First(x => x.Ma == id);
            if(sp!= null)
            {
                sp.DanhMuc = null;
            }
            return sp;
        }
        [HttpGet]
        public List<SanPham> getSanPhamByMaDanhMuc(int maDanhMuc)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<SanPham> ds = context.SanPhams
                .Where(x => x.MaDanhMuc == maDanhMuc)
                .ToList();
            foreach (SanPham sp in ds)
                sp.DanhMuc = null;
            return ds;

        }
        [HttpGet]
        public List<SanPham> getByCost(int a, int b)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<SanPham> ds = context.SanPhams
                .Where(x => x.DonGia > a && x.DonGia <= b)
                .ToList();
            foreach (SanPham sp in ds)
                sp.DanhMuc = null;
            return ds;
        }



    }
}
