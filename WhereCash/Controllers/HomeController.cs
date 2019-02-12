using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WhereCash.Models;

namespace WhereCash.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.CurrentDate = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            return View("MyView");
        }
    }
}
