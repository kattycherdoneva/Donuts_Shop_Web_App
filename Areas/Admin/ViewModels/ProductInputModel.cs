namespace DonutsShopApp.Admin.ViewModels
{
    using Data.Models.Enum;
    using Microsoft.AspNetCore.Http;

    public class ProductInputModel
    {
        public string Title { get; set; }

        public string SubTitle { get; set; }

        public decimal Price { get; set; }

        public FoodType FoodType { get; set; }

        public ProductType ProductType { get; set; }

        public string Description { get; set; }

        public IFormFile Image { get; set; }
    }
}


