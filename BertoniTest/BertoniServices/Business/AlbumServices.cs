using BertoniServices.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BertoniServices.Business
{
    public static class AlbumServices
    {
        /// <summary>
        /// Get All Albums from the services
        /// </summary>
        /// <returns></returns>
        public static List<Album> GetAlbums()
        {
            try
            {
                HttpClientHelper apiRequest = new HttpClientHelper();
                
                var result = apiRequest.GetUnAuthorized("albums").Result;

                var convertResult = JsonConvert.DeserializeObject<List<Album>>(result);

                #region for test
                /*
                var convertResult = new List<Album>() { 
                    new Album(){Id = 1, Name = "Alb1"},
                    new Album(){Id = 2, Name = "Alb2"},
                    new Album(){Id = 3, Name = "Alb3"},
                    new Album(){Id = 4, Name = "Alb4"},
                    new Album(){Id = 5, Name = "Alb5"},
                    new Album(){Id = 6, Name = "Alb6"}
                };
                */
                #endregion

                return convertResult;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
