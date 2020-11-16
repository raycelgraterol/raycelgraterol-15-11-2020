using BertoniServices.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BertoniServices.Business
{
    public class PhotoServices
    {
        /// <summary>
        /// Get All Photos by Album Id
        /// Assuming the service allow photos/album/id 
        /// </summary>
        /// <param name="albumId"></param>
        /// <returns></returns>
        public static List<Photo> GetPhotosByAlbumId(int albumId)
        {
            try
            {
                HttpClientHelper apiRequest = new HttpClientHelper();
                
                var result = apiRequest.GetUnAuthorized("photos/album/" + albumId).Result;

                var convertResult = JsonConvert.DeserializeObject<List<Photo>>(result);

                #region for test
                /*
                var convertResult = new List<Photo>() {
                    new Photo(){Id = 11, Title = "pho1", PhotoPath="path1", AlbumId = 2},
                    new Photo(){Id = 12, Title = "pho2", PhotoPath="path2",AlbumId = 2},
                    new Photo(){Id = 13, Title = "pho3", PhotoPath="path3",AlbumId = 2},
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
