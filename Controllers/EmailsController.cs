using Assignment.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Controllers
{
    public class EmailsController : Controller
    {
        private readonly AppDbContext _context;

        public EmailsController(AppDbContext context)
        {
            _context = context;
        }

        public  async Task<IActionResult> Index()
        {
            var allemails = await _context.Emails.ToListAsync();
            return View(allemails);
        }
    }
}
