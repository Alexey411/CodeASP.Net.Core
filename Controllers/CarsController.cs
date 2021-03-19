using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WA20.interfaces;
using WA20.Models;
using WA20.ViewModels;

namespace WA12.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllRealty _allRealty;
        private readonly IRealtyCategory _allCategories;

        public CarsController(IAllRealty iAllRealty, IRealtyCategory iRealtyCat)
        {
            _allRealty = iAllRealty;
            _allCategories = iRealtyCat;
        }

        public ViewResult Index()
        {
            ViewBag.Title = "Недвижимость";
            RealtyListViewModel obj = new RealtyListViewModel();
            obj.allRealty = _allRealty.Realty;
            obj.currCategory = "Недвижимость";

            return View(obj);
        }
    }
}