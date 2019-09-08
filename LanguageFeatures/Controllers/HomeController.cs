using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            //return View(new string[] {"C#","Language","Features"});

            List<string> results = new List<string>();

            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name??"<No Name>";
                decimal? price = p?.Price??0;
                string category = p?.Category??"<None>";
                string relatedName = p?.Related?.Name??"<None>";
                string instock = p?.InStock.ToString()??"<None ";

                results.Add(string.Format("Name: {0}, Category:{1}, Price: {2}, Related: {3}, InStock {4}", name, category, price, relatedName,instock));
            }
            
            return View(results);
        }
    }
}
 