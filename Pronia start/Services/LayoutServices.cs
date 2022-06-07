using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Pronia_start.DAL;
using Pronia_start.Models;
using Pronia_start.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_start.Services
{
    public class LayoutServices
    {
            private readonly AppDbContext _context;
            private readonly IHttpContextAccessor _httpContext;

            public LayoutServices(AppDbContext context, IHttpContextAccessor _httpContext)
            {
                _context = context;
                this._httpContext = _httpContext;
            }
            public async Task<Setting> GetDatas()
            {
            Setting setting = await _context.Settings.FirstOrDefaultAsync();
            return setting;

            }
        public async Task<BasketVM> GetBasket()
        {
            string basketStr = _httpContext.HttpContext.Request.Cookies["Basket"];
            BasketVM basketData = new BasketVM();
            if (!string.IsNullOrEmpty(basketStr))
            {
                List<BasketCookieItemVM> basket = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basketStr);

                var query = _context.Plants.Include(p => p.PlantImages).AsQueryable();

               foreach (BasketCookieItemVM item in basket)
                {
                    Plant existedPlant= await _context.Plants.FirstOrDefaultAsync(p=>p.Id==item.Id);
                    if(existedPlant!= null)
                    {
                        BasketItemVM basketItem = new BasketItemVM
                        {
                            Plant = existedPlant,
                            Count = item.Count
                        };
                        basketData.BasketItemVMs.Add(basketItem);

                    }
                }
                decimal total = default;

                foreach (BasketItemVM item in basketData.BasketItemVMs)
                {
                    total += item.Plant.Price * item.Count;
                }
                basketData.TotalPrice=total;
                basketData.Count = basketData.BasketItemVMs.Count;
                return basketData;
            }
            else
            {
                return null;
            }
        }


    }

    }

