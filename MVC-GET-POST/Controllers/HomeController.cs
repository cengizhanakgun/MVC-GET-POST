using MVC_GET_POST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_GET_POST.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kitap()
        {
            Books books = new Books();
            books.kitapAdi = "Borland C++ GUI";
            books.seriNo = 098021553;
            books.yazarAdi = "George W.A";
            books.yas = 48;








            return View(books);

        }
        [HttpPost]  
        public ActionResult Kitap(Books model)
        {
        







            return View(model);

        }


    }
}