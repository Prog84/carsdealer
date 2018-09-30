using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using carsdealer.Controllers.Resources;
using carsdealer.Models;
using carsdealer.Persistence;

namespace carsdealer.Controllers
{
    public class FeaturesController
    {
        private readonly CarsDealerDbContext context;
        private readonly IMapper mapper;
        public FeaturesController(CarsDealerDbContext context, IMapper mapper)
    {
      this.mapper = mapper;
      this.context = context;
    }

    [HttpGet("/api/features")]
    public async Task<IEnumerable<KeyValuePairResource>> GetFeatures()
    {
      var features = await context.Features.ToListAsync();
      
      return mapper.Map<List<Feature>, List<KeyValuePairResource>>(features); 
    }
    }
}