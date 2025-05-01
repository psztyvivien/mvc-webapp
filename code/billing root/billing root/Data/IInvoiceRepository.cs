using billing_root.Models;
namespace billing_root.Data
{
    public interface IInvoiceRepository
    {
        void Create(Invoice inv);
        void Delete(int id);
        IEnumerable<Invoice> Read();
        Invoice? Read(int id);
        void Update(Invoice inv);
        void MarkAsPaid(int id);
    }
}