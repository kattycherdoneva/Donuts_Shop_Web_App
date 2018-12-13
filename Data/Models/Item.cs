namespace DonutsShopApp.Data.Models
{
    using Enum;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Item
    {
        public Item()
        {
            this.Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public FoodType FoodType { get; set; }

        public ProductType ProductType { get; set; }

        public string Description { get; set; }

        public int? Rating { get; set; }

        public byte[] Image { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
