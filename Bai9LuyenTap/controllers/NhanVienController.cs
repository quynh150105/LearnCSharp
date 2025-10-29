using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai9LuyenTap.controllers
{
    public class NhanVienController : ApiController
    {
        [HttpGet]
        public List<NhanVien> DanhsachNV()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<NhanVien> ds = context.NhanViens.ToList();
            return ds;
        }
        [HttpPost]
        public bool ThemNhanVien([FromBody] NhanVien nv)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            context.NhanViens.InsertOnSubmit(nv);
            context.SubmitChanges();
            return true;
        }
        [HttpDelete]
        public bool XoaNhanvien(string id)
        {
            try
            {
                CSDLTestDataContext context = new CSDLTestDataContext();
                NhanVien nv = context.NhanViens.FirstOrDefault(x => x.MaNV == id);
                if (nv == null) return false;

                context.NhanViens.DeleteOnSubmit(nv);
                context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        
        }

    }
}
