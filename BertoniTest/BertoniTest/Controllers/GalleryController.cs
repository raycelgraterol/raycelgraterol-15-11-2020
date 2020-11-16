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
    public class GalleryController : Controller
    {
        /// <summary>
        /// Init view to show the ddl
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            try
            {
                //Get all albums from the service
                var albumsResult = AlbumServices.GetAlbums();

                ViewBag.Albums = albumsResult;

                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Albums = new List<Album>();

                return View();
            }
            
        }
                
    }
}