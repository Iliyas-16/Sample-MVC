//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using MyApp.Data;
//using MyApp.Models;

//namespace MyApp.Controllers
//{
//    public class ItemsController : Controller
//    {
//        private readonly MyAppContext _context;
//        public ItemsController(MyAppContext context)
//        {
//            _context = context;

//        }
//        public async Task<IActionResult> Index()
//        {
//            var items = await _context.Items.ToListAsync();  // Check if this returns data
//            return View(items);
//        }

//        public IActionResult Details()
//        {
//            return View();
//        }

//    }
//}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApp.Data;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class ItemsController : Controller
    {
        private readonly MyAppContext _context;

        public ItemsController(MyAppContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _context.Items.ToListAsync();
            return View(items);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Item item)
        {
            if (ModelState.IsValid)
            {
                _context.Items.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}





