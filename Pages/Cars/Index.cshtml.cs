using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarSpecs.Data;
using CarSpecs.Models;

namespace CarSpecs.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly CarSpecs.Data.CarContext _context;

        public IndexModel(CarSpecs.Data.CarContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Cars != null)
            {
                Car = await _context.Cars.ToListAsync();
            }
        }
    }
}
