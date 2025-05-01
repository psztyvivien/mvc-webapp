using billing_root.Models;
namespace billing_root.Data
{
    public class InvoiceRepository : IInvoiceRepository
    {
        public List<Invoice> invoices;
        public InvoiceRepository()
        {
            invoices = new List<Invoice>();
        }

        public void Create(Invoice inv)
        {
            this.invoices.Add(inv);
        }

        public IEnumerable<Invoice> Read()
        {
            return this.invoices;
        }

        public Invoice? Read(int id)
        {
            return this.invoices.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Invoice inv) 
        {
            //mindent property-t átveszünk
            Invoice toUpdate = this.Read(inv.Id);

            toUpdate.PayerName = inv.PayerName;
            toUpdate.Amount = inv.Amount;
            toUpdate.IsPaid = inv.IsPaid;
        }

        public void Delete(int id) 
        { 
            Invoice toDelete = this.Read(id);
            this.invoices.Remove(toDelete);
        }

        public void MarkAsPaid(int id)
        {
            Invoice inv = Read(id);
            if (inv != null)
            {
                inv.IsPaid = true;
            }
        }
    }
}
