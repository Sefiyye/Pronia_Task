using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Pronia_start.DAL;
using Pronia_start.Models;
using Pronia_start.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_start.Controllers
{
    public class PlantController : Controller
    {
        private readonly AppDbContext _context;

        public PlantController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> AddBasket(int id)
        {
            Plant plant = await _context.Plants.FirstOrDefaultAsync(p => p.Id == id);
            if(plant==null) return NotFound();
            string basketStr = HttpContext.Request.Cookies["Basket"];
            List<BasketCookieItemVM> basket;
            if (string.IsNullOrEmpty(basketStr))
            {
                basket= new List<BasketCookieItemVM>();
                BasketCookieItemVM cookie = new BasketCookieItemVM
                {
                    Id = plant.Id,
                    Count = 1
                };
                basket.Add(cookie);
                basketStr = JsonConvert.SerializeObject(basket);
            }
            else
            {
                basket = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basketStr);
                BasketCookieItemVM existedCookie = basket.FirstOrDefault(c => c.Id == plant.Id);
                if (existedCookie == null)
                {
                    BasketCookieItemVM cookie = new BasketCookieItemVM
                    {
                        Id = plant.Id,
                        Count = 1
                    };
                    basket.Add(cookie);
                }
                else
                {
                    existedCookie.Count++;
                }
                basketStr = JsonConvert.SerializeObject(basket);

            }
            HttpContext.Response.Cookies.Append("Basket", basketStr);
            return RedirectToAction("Index", "Home");
           
        }
        public ActionResult ShowBasket()
        {
            return Content(HttpContext.Request.Cookies["Basket"]);
        }

    }
}
