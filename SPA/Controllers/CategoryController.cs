using SPA.DAL;
using SPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace SPA.Controllers
{
    public class CategoryController : ApiController
    {
        public IEnumerable<Category> Get()
        {
            using(ProductContext cat = new ProductContext())
            {
                return cat.category.ToList();
            }
        } 
    }
}
