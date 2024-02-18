using SignaturPADAPI.DAL;
using SignaturPADAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace SignaturPADAPI.Controllers
{
    public class signController : Controller
    {
        // GET: api/sign
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/sign/5
        public JsonResult getemplst(int id)
        {
            Class1 dl = new Class1();
            var onj = dl.getemplst();
            return Json(onj, JsonRequestBehavior.AllowGet);
        }

        // POST: api/sign
        public JsonResult submit(Models.ModelClass emp)
        {
            Class1 dl = new Class1();
            //int x = dl.Add(productList);

            return Json(dl.Add(emp), JsonRequestBehavior.AllowGet);

        }

        // PUT: api/sign/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/sign/5
        public void Delete(int id)
        {
        }
    }
}
