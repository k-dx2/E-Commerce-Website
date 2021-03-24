using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmazonRetail.Web.Helpers;
using AmazonWeb.Core.Entities;
using AmazonRetail.Web.Data;
//using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace AmazonRetail.Web.Controllers
{
    public class CheckoutsController : Controller
    {   
        [Authorize]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetOnjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(i => i.Product.UnitPrice * i.Quantity);

            return View();
        }
    }
}
