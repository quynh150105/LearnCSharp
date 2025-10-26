using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai9XayDungWebApi.Controllers
{
    public class DanhMucController : ApiController
    {
        [HttpGet]
        public List<DanhMuc> getAllDanhMuc() { 
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<DanhMuc> ds = context.DanhMucs.ToList();
            
            foreach(DanhMuc dm in ds)
            {
                dm.SanPhams.Clear();
            }
            return ds;
        
        }
        [HttpGet]
        public DanhMuc getDanhMuc(int id)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            DanhMuc dm = context.DanhMucs
                .First(x => x.MaDanhMuc == id);
            if(dm!=null)
            {
                dm.SanPhams.Clear();
            }
            return dm;
        }
    }
}
