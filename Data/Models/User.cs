namespace DonutsShopApp.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;

    public class User : IdentityUser
    {
        public User()
        {
            this.Donations = new HashSet<Donation>();
            this.Shippings = new HashSet<Shipping>();
            this.Resources = new HashSet<Resource>();
            this.Comments = new HashSet<Comment>();
        }

        public int BasketId { get; set; }
        public Basket Basket { get; set; }

        public int Points { get; set; }

        public ICollection<Donation> Donations { get; set; }

        public ICollection<Shipping> Shippings { get; set; }

        public ICollection<Resource> Resources { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
