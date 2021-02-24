using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentsController : ControllerBase
    {
        private readonly IRentService _rentService;

        public RentsController(IRentService rentService)
        {
            _rentService = rentService;
        }

        [HttpPost("Add")]
        public IActionResult Add(Rent rent)
        {
            var result = _rentService.Add(rent);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(Rent rent)
        {
            var result = _rentService.Update(rent);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Rent rent)
        {
            var result = _rentService.Delete(rent);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }
        
        [HttpGet("GetById")]
        public IActionResult GetById(int rentId)
        {
            var result = _rentService.GetById(rentId);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _rentService.GetAll();
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }
    }
}

