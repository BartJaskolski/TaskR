using SPA.DAL;
using SPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPA.Controllers
{
    public class HomeController : Controller
    {

        private ProductContext db = new ProductContext();

        public ActionResult AutoComplete(string term)
        {
            var model =
                db.product
                .Where(r => r.productName.StartsWith(term))
                .Take(10)
                .Select(r => new
                {
                    label = r.productName
                });
            return Json(model, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index(string SearchProduct = null, int SearchCategory =0)
        {
            
            if (SearchCategory != 0)
            {
                var model =
                    db.product
                    .Where(r => SearchProduct == null || r.productName.StartsWith(SearchProduct)
                            && r.categoryID == SearchCategory)
                    .Select(r => new ProductListViewModel
                    {
                        categoryID = r.categoryID,
                        productsID = r.productsID,
                        productsPrice = r.priceProduct,
                        productName = r.productName,
                        productDesctription = r.productDesctription
                    }
                            );
                return View(model);
            }
            else
            {
                 var model =
                    db.product
                    .Where(r => SearchProduct == null || r.productName.StartsWith(SearchProduct))
                    .Select(r => new ProductListViewModel
                    {
                        categoryID = r.categoryID,
                        productsID = r.productsID,
                        productsPrice = r.priceProduct,
                        productName = r.productName,
                        productDesctription = r.productDesctription
                    }
                            );
                 return View(model);
            }   
        }
        public JsonResult UserLogin(LoginData data)
        {
            using (ProductContext uData = new ProductContext())
            {
                var user = uData.loginData.Where(a => a.UserName.Equals(data.UserName) &&
                    a.Password.Equals(data.Password)).FirstOrDefault();
                return new JsonResult { Data = user, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            }
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult getByAngular()
        {
            return View();
        }
    }
}
