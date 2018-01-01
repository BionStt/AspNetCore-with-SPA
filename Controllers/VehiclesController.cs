using Microsoft.AspNetCore.Mvc;
using S.model;

namespace S.Controllers
{ 
    [Route("api/vehicles")]
    public class VehiclesController : Controller
    {
        [HttpPost]
        public IActionResult GetAllvehicles([FromBody] Vehicle vehicle){ 
            return Ok(vehicle);
        }
        
    }
}