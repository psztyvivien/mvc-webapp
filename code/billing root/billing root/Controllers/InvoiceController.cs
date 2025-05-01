using billing_root.Data;
using Microsoft.AspNetCore.Mvc;
using billing_root.Models;

namespace billing_root.Controllers
{
    public class InvoiceController : Controller
    {
        IInvoiceRepository repo;
        public InvoiceController(IInvoiceRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View(this.repo.Read());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Invoice inv)
        {
            this.repo.Create(inv);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            this.repo.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Invoice inv = this.repo.Read(id);
            return View(inv);
        }

        [HttpPost]
        public IActionResult Update(Invoice inv)
        {
            this.repo.Update(inv);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult MarkAsPaid(int id)
        {
            this.repo.MarkAsPaid(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
