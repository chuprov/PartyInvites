﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            Product myProduct=new Product()
            {
                ProductId = 1, Name = "Kayak",Description = "A boat for one person", Category = "Watersport",Price = 275M
            };

            ViewBag.StockLevel = 2;
            return View(myProduct);
        }
    }
}
