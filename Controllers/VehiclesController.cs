using System.Threading.Tasks;
using AutoMapper;
using dotnetCore.Persistent;
using Microsoft.AspNetCore.Mvc;
using S.Controllers.Resources;
using S.model;

namespace S.Controllers
{
    [Route("api/vehicles")]
    public class VehiclesController : Controller
    {
        private readonly IMapper mapper;
        private readonly AppDbContext context;
        public VehiclesController(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;

        }


        [HttpPost]
        public async Task<IActionResult> GetAllvehicles([FromBody] VehicleResource vehicleResource)
        {
            var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            context.Vehicles.Add(vehicle);
            await context.SaveChangesAsync();
            
            var result = Mapper.Map<Vehicle, VehicleResource>(vehicle);
            return Ok(result);
        }

    }
}