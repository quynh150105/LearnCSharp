using BaiThucHanhTrenLopBuoi5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BaiThucHanhTrenLopBuoi5.Controllers
{
    public class DanhMucController : ApiController
    {
        CSDLTestEntities db = new CSDLTestEntities();

        [HttpGet]
        public List<DanhMuc> getAll()
        {
            return db.DanhMucs.ToList();
        }


    }
}
