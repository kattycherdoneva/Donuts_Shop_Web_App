using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonutsShopApp.Data.Models
{
    public class Receipt
    {
        public Receipt()
        {
            this.ProductForReceipts = new HashSet<ProductForReceipt>();
        }

        public int Id { get; set; }

        public ICollection<ProductForReceipt> ProductForReceipts { get; set; }
    }
}
