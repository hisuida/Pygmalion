using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.App.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(string text)
        {
            var repo = new OrderRepository();
            Order order = new Order();
            order = repo.GetBySerial(text);
            return View(order);
        }

        
    }
}
