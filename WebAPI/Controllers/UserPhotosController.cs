using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPhotosController : ControllerBase
    {
        IUserPhotoService _userPhotoService;
        public UserPhotosController(IUserPhotoService userPhotoService)
        {
            _userPhotoService = userPhotoService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name =("ImagePath"))]IFormFile file,[FromForm]UserPhoto photo)
        {
            var result = _userPhotoService.Add(file, photo);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(IFormFile file,int id)
        {
            var photo = _userPhotoService.Get(id);
            var result = _userPhotoService.Delete(file,photo.Data);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
