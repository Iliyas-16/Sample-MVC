﻿using Microsoft.AspNetCore.Mvc;
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
            var items = await _context.Items.ToListAsync();  // Check if this returns data
            return View(items);
        }

    }
}

