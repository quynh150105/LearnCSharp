using BaiThucHanhTrenLopBuoi6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BaiThucHanhTrenLopBuoi6.Controllers
{
    public class DanhMucController : ApiController
    {
        CSDLTestEntities db = new CSDLTestEntities();
        
        [HttpGet]
        public List<DanhMuc> getAllDanhMuc()
        {
            return db.DanhMucs.ToList();
        }

    }
}
