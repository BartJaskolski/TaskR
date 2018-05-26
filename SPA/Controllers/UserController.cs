using SPA.DAL;
using SPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace SPA.Controllers
{
    public class UserController : ApiController
    {
        private ProductContext db = new ProductContext();

        public JsonResult UserLogin(LoginData data)
        {
            var user = db.loginData.Where(a => a.UserName.Equals(data.UserName) &&
                a.Password.Equals(data.Password)).FirstOrDefault();
            return new JsonResult { Data = user, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}
