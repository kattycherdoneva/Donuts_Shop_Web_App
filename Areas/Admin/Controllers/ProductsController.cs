using DonutsShopApp.Admin.ViewModels;
using DonutsShopApp.Controllers;
using DonutsShopApp.Data;
using DonutsShopApp.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DonutsShopApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : BaseController
    {
        public ProductsController(ApplicationDbContext context)
            : base(context)
        {
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductInputModel model)
        {
            if (this.ModelState.IsValid)
            {
                var product = new Item
                {
                    Title = model.Title,
                    SubTitle = model.SubTitle,
                    Price = model.Price,
                    ProductType = model.ProductType,
                    FoodType = model.FoodType,
                    Description = model.Description,
                };

                using (var memoryStream = new MemoryStream())
                {
                    await model.Image.CopyToAsync(memoryStream);
                    product.Image = memoryStream.ToArray();
                }

                this.Context.Items.Add(product);
                this.Context.SaveChanges();

                return RedirectToAction("Products", "Home");
            }
            else
            {
                return this.View(model);
            }
        }
    }
}
