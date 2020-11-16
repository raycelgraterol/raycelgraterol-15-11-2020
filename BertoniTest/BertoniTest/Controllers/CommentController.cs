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
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Get all comments by photo id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("commentsByPhotos")]
        [HttpGet()]
        public JsonResult GetCommentByPhotos([FromQuery(Name = "Id")] int Id)
        {
            var commentsResult = new List<Comment>();

            try
            {
                //Get all comments by photos id
                commentsResult = CommentServices.GetCommentsByPhotoId(Id);

                return Json(new { message = MessagesHelper.TextMsg, type = MessagesHelper.success, commentsResult });
            }
            catch (Exception ex)
            {
                return Json(new { message = MessagesHelper.TextMsg, type = MessagesHelper.warning, commentsResult });

            }
        }
    }
}