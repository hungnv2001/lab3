using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bai1.Models;
using Bai1.Service;

namespace Bai1.Controllers
{
    public class ProductViewModelsController : Controller
    {
        private readonly IProduct _context;

        public ProductViewModelsController(IProduct context)
        {
            _context = context;
        }

        // GET: ProductViewModels
        public async Task<IActionResult> Index()
        {
            return View(_context.GetALl());
        }

        // GET: ProductViewModels/Details/5
      
    }
}
