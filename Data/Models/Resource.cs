namespace DonutsShopApp.Data.Models
{
    using Enum;
    using System.Collections.Generic;

    public class Resource
    {
        public Resource()
        {
            this.Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public ResourceType ResourceType { get; set; }

        public PeopleType PeopleType { get; set; }

        public string Description { get; set; }

        public int? Rating { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
