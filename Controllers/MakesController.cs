using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using carsdealer.Controllers.Resources;
using carsdealer.Models;
using carsdealer.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace carsdealer.Controllers
{
    public class MakesController : Controller
    {
        private readonly CarsDealerDbContext context;
        private readonly IMapper mapper;
        public MakesController(CarsDealerDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}