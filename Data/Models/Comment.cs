namespace DonutsShopApp.Data.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public int? ProductId { get; set; }
        public Item Product { get; set; }

        public int? ResourceId { get; set; }
        public Resource Resource { get; set; }

        public string Text { get; set; }
    }
}
