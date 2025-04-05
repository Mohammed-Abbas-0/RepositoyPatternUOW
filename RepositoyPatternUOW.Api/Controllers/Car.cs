using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternWithUOW.Core.IRepository;
using RepositoryPatternWithUOW.Core.Models;
using RepositoryPatternWithUOW.EF;
using RepositoryPatternWithUOW.EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoyPatternUOW.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IVehicleGeneric<Car> _vehicleGeneric;
        public CarController(IVehicleGeneric<Car> vehicleGeneric)
        {
            _vehicleGeneric = vehicleGeneric;
        }


        [HttpGet("CarDetail")]
        public async Task<IActionResult> GetDetail(int Id)
        {
            if (Id == 0 || string.IsNullOrEmpty(Id.ToString())) 
                return NotFound();
            return Ok(await _vehicleGeneric.GetDetails(Id));
        }
    }
}
