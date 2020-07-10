using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using A3DRestaurant.Web.Models;

namespace A3DRestaurant.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Menu()
        {

            return View(FoodMenuItems());
        }
        [HttpPost]
        public IActionResult Menu(mFoodMenuItems mFoodMenuItems)
        {

            return View(FoodMenuItems());
        }

        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private List<mFoodMenuItems> FoodMenuItems()
        {
            List<mFoodMenuItems> LstFoodMenuItems = new List<mFoodMenuItems>();

            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "AG", FoodMenuItemDesc = "Aloo gobi", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "AT", FoodMenuItemDesc = "Aloo tikki", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "AM", FoodMenuItemDesc = "Aloo matar", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "AP", FoodMenuItemDesc = "Aloo methi", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "AS", FoodMenuItemDesc = "Aloo shimla mirch", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "BH", FoodMenuItemDesc = "Bhatura", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "PP", FoodMenuItemDesc = "Paneer paratha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });

            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "OP", FoodMenuItemDesc = "Onion paratha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "MP", FoodMenuItemDesc = "mint paratha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "CSP", FoodMenuItemDesc = "carom seeds paratha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "CDP", FoodMenuItemDesc = "Chana dal paratha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "DAP", FoodMenuItemDesc = "Dhaba style aloo paratha.", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });



            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 80, FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "OP", FoodMenuItemDesc = "Onion paratha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 90, FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "MP", FoodMenuItemDesc = "mint paratha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 10, FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "CSP", FoodMenuItemDesc = "carom seeds paratha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 10, FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "CDP", FoodMenuItemDesc = "Chana dal paratha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 10, FoodMenuItemGroupCode = "Special", FoodMenuItemCode = "DAP", FoodMenuItemDesc = "Dhaba style aloo paratha.", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });

            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PHK", FoodMenuItemDesc = "Phulka ", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PPL", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PBM", FoodMenuItemDesc = "Paneer Butter Masala", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "SDL", FoodMenuItemDesc = "Spinach Dal", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "SHP", FoodMenuItemDesc = "Shahi Paneer", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PEAP", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });

            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PHK", FoodMenuItemDesc = "Phulka ", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PPL", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PBM", FoodMenuItemDesc = "Paneer Butter Masala", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "SDL", FoodMenuItemDesc = "Spinach Dal", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "SHP", FoodMenuItemDesc = "Shahi Paneer", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PEAP", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });

            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PHK", FoodMenuItemDesc = "Phulka ", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PPL", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PBM", FoodMenuItemDesc = "Paneer Butter Masala", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "SDL", FoodMenuItemDesc = "Spinach Dal", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "SHP", FoodMenuItemDesc = "Shahi Paneer", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PEAP", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });

            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PHK", FoodMenuItemDesc = "Phulka ", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PPL", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PBM", FoodMenuItemDesc = "Paneer Butter Masala", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "SDL", FoodMenuItemDesc = "Spinach Dal", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "SHP", FoodMenuItemDesc = "Shahi Paneer", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PEAP", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });

            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PHK", FoodMenuItemDesc = "Phulka ", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PPL", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PBM", FoodMenuItemDesc = "Paneer Butter Masala", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "SDL", FoodMenuItemDesc = "Spinach Dal", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "SHP", FoodMenuItemDesc = "Shahi Paneer", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Breakfast", FoodMenuItemCode = "PEAP", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });



            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Launch", FoodMenuItemCode = "PHK", FoodMenuItemDesc = "Phulka ", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Launch", FoodMenuItemCode = "PPL", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Launch", FoodMenuItemCode = "PBM", FoodMenuItemDesc = "Paneer Butter Masala", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Launch", FoodMenuItemCode = "SDL", FoodMenuItemDesc = "Spinach Dal", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Launch", FoodMenuItemCode = "SHP", FoodMenuItemDesc = "Shahi Paneer", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Launch", FoodMenuItemCode = "PEAP", FoodMenuItemDesc = "Peas Pulao", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });


            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Dinner", FoodMenuItemCode = "PTM", FoodMenuItemDesc = "Paneer Tikka Masala", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Dinner", FoodMenuItemCode = "TR", FoodMenuItemDesc = "Tandoori Roti, Tandoori Roti On A Tava", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Dinner", FoodMenuItemCode = "PMD", FoodMenuItemDesc = "Paneer Makhani", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Dinner", FoodMenuItemCode = "KUL", FoodMenuItemDesc = "Kulcha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Dinner", FoodMenuItemCode = "PRP", FoodMenuItemDesc = "Punjabi Reshmi Paratha", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Dinner", FoodMenuItemCode = "CBH", FoodMenuItemDesc = "Chole Bhature", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });


            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "JBL", FoodMenuItemDesc = "Jalebi", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "MDK", FoodMenuItemDesc = "Moong Dal Kachori", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "KKR", FoodMenuItemDesc = "Kathi Kebab Roll", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "DPC", FoodMenuItemDesc = "Dahi Papdi Chaat", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "PNP", FoodMenuItemDesc = "Paneer Pakora", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "DHK", FoodMenuItemDesc = "Dhokla", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });

            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "JBL", FoodMenuItemDesc = "Jalebi", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "MDK", FoodMenuItemDesc = "Moong Dal Kachori", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "KKR", FoodMenuItemDesc = "Kathi Kebab Roll", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "DPC", FoodMenuItemDesc = "Dahi Papdi Chaat", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "PNP", FoodMenuItemDesc = "Paneer Pakora", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "DHK", FoodMenuItemDesc = "Dhokla", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 }); LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "JBL", FoodMenuItemDesc = "Jalebi", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "MDK", FoodMenuItemDesc = "Moong Dal Kachori", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "KKR", FoodMenuItemDesc = "Kathi Kebab Roll", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "DPC", FoodMenuItemDesc = "Dahi Papdi Chaat", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "PNP", FoodMenuItemDesc = "Paneer Pakora", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "DHK", FoodMenuItemDesc = "Dhokla", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 }); LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "JBL", FoodMenuItemDesc = "Jalebi", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "MDK", FoodMenuItemDesc = "Moong Dal Kachori", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "KKR", FoodMenuItemDesc = "Kathi Kebab Roll", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "DPC", FoodMenuItemDesc = "Dahi Papdi Chaat", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "PNP", FoodMenuItemDesc = "Paneer Pakora", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "DHK", FoodMenuItemDesc = "Dhokla", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 }); LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "JBL", FoodMenuItemDesc = "Jalebi", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "MDK", FoodMenuItemDesc = "Moong Dal Kachori", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "KKR", FoodMenuItemDesc = "Kathi Kebab Roll", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "DPC", FoodMenuItemDesc = "Dahi Papdi Chaat", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "PNP", FoodMenuItemDesc = "Paneer Pakora", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            LstFoodMenuItems.Add(new mFoodMenuItems() { iID = 0, FoodMenuItemGroupCode = "Sneaks", FoodMenuItemCode = "DHK", FoodMenuItemDesc = "Dhokla", FoodMenuItemPrice = 40, FoodMenuItemQty = 0 });
            int iCount = 0;
            foreach (var item in LstFoodMenuItems)
            {
                iCount++;
                item.iID = iCount;
            }

            return LstFoodMenuItems;
        }
    }
}
