using System.ComponentModel.DataAnnotations;

namespace billing_root.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string PayerName { get; set; }

        public int Amount { get; set; }

        public bool IsPaid { get; set; }
    }
}
