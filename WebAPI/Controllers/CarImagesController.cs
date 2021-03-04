using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.Drawing;
using System.Net.Mime;
using System.Text;
using Core.Utilities.Helpers;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }
        [HttpPost("Add")]
        public IActionResult Add([FromForm(Name = "Image")]IFormFile image, [FromForm]CarImage carImage)
        {
            var result = _carImageService.Add(image, carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getcarpictures")]
        public IActionResult Get(int carId)
        {
            var result = _carImageService.GetSameCars(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = "Image")] IFormFile image, [FromForm]CarImage carImage)
        {
            var data = _carImageService.GetById(carImage);
            var result = _carImageService.Update(image, data.Data);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(CarImage carImage)
        {
            var data = _carImageService.GetById(carImage);
            var result = _carImageService.Delete(data.Data);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
