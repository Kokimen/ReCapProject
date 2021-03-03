using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        private readonly ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpPost("Add")]
        public IActionResult Add(CarImage carImage)
        {
            var result = _carImageService.Add( carImage);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(CarImage carImage)
        {
            var result = _carImageService.Update(carImage);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(CarImage carImage)
        {
            var result = _carImageService.Delete(carImage);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int carImageId)
        {
            var result = _carImageService.GetById(carImageId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }
    }
}
