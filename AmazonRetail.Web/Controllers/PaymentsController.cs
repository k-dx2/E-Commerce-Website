using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonRetail.Web.Controllers
{
    public class PaymentsController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.Remove("cart");
            return View();
        }
    }
}
