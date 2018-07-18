using System.Collections.Generic;
using System.Threading.Tasks;
using carsdealer.Models;
using carsdealer.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace carsdealer.Controllers
{
    public class MakesController : Controller
    {
        private readonly CarsDealerDbContext context;
        public MakesController(CarsDealerDbContext context)
        {
            this.context = context;

        }
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            return await context.Makes.Include(m => m.Models).ToListAsync();
        }
    }
}