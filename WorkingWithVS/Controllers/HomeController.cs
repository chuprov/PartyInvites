﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkingWithVS.Models;

namespace WorkingWithVS.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
            => View(SimpleRepository.SharedRepository.Products.Where(p=>p.Price<50));
    }
}
