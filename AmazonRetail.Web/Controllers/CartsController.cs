using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmazonRetail.Web.Helpers;
using AmazonWeb.Core.Entities;
using AmazonRetail.Web.Data;
using Microsoft.EntityFrameworkCore;


namespace AmazonRetail.Web.Controllers
{
    public class CartsController : Controller
    {
        private readonly AmazonRetailWebDbContext _context;

      
        public CartsController(AmazonRetailWebDbContext context)
        {
            _context = context;
           
        }
        public IActionResult Index()
        {  
           var cart = SessionHelper.GetOnjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
           if(cart==null)
            {
                return View("Index1");
            }
           ViewBag.cart = cart;
           ViewBag.total = cart.Sum(x => x.Product.UnitPrice * x.Quantity);
           return View();
        }
        private int isExist (int id)
        {
            List<CartItem> cart = SessionHelper.GetOnjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
           // var prod = await _context.Product.FirstOrDefault(i => i.Id == id);
            for (int i=0;i<cart.Count; i++)
            {
               // var prod = _context.Product.Find(id);
                if (cart[i].ProductId ==id)
                {
                    return i;
                }
               
            }
            return -1;

        }
        public IActionResult Buy(int id)
        {
            if(SessionHelper.GetOnjectFromJson<List<CartItem>>(HttpContext.Session,"cart")==null)
            {
                List<CartItem> cart = new List<CartItem>();
                var prod = _context.Product.Find(id);
                cart.Add(new CartItem { ProductId=prod.Id, Product = prod , Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart",cart);

            }
            else
            {
                List<CartItem> cart = SessionHelper.GetOnjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if(index!=-1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    var prod = _context.Product.Find(id);
                    cart.Add(new CartItem { ProductId = prod.Id, Product = prod, Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

                
            }
            return RedirectToAction("Index");


        }

        public IActionResult Remove(int id)
        {
            List<CartItem> cart = SessionHelper.GetOnjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            int index = isExist(id);
            if(cart[index].Quantity==1)
            {
                cart.RemoveAt(index);
                if (cart.Count == 0)
                    return View("Index1");
            }
            else
            {
                cart[index].Quantity--;
                
            }
           
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart",cart);
            return RedirectToAction("Index");



        }

    }
}
