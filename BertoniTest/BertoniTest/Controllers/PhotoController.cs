using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BertoniServices.Business;
using BertoniServices.Entities;
using BertoniTest.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace BertoniTest.Controllers
{
    [Route("[controller]")]
    public class PhotoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Get all photos by album id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("photosByAlbum")]
        [HttpGet()]
        public JsonResult GetPhotosByAlbumId([FromQuery(Name = "Id")] int Id)
        {
            var photosResult = new List<Photo>();

            try
            {
                //Get all photos from the services by album
                photosResult = PhotoServices.GetPhotosByAlbumId(Id);

                return Json(new { message = MessagesHelper.TextMsg, type = MessagesHelper.success, photosResult });
            }
            catch (Exception ex)
            {
                return Json(new { message = MessagesHelper.TextMsg, type = MessagesHelper.warning, photosResult });

            }
        }
    }
}