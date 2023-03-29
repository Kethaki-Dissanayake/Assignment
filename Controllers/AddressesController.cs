using Assignment.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Controllers
{
    public class AddressesController : Controller


    {
        //Inject AppDbcontext
        private readonly AppDbContext _context;

        public AddressesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var alladdresses = await _context.Addresses.ToListAsync();
            return View(alladdresses);
        }
    }
}
