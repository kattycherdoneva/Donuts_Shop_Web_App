using System.ComponentModel.DataAnnotations.Schema;

namespace DonutsShopApp.Data.Models
{
    public class Donation
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public int? TotalNumberOfDonuts { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ТotalАmountОfМoney { get; set; }

        public bool DonationThroughCompany { get; set; }
    }
}
