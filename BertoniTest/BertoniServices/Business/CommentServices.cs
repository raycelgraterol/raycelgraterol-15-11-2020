using BertoniServices.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BertoniServices.Business
{
    public class CommentServices
    {
        /// <summary>
        /// Get all comments by photo id
        /// Assuming the service allow comments/photos/id 
        /// </summary>
        /// <param name="photoId"></param>
        /// <returns></returns>
        public static List<Comment> GetCommentsByPhotoId(int photoId)
        {
            try
            {
                HttpClientHelper apiRequest = new HttpClientHelper();
                
                var result = apiRequest.GetUnAuthorized("comments").Result;

                var convertResult = JsonConvert.DeserializeObject<List<Comment>>(result);

                convertResult = convertResult.Where(x => x.PhotoId == photoId).ToList();

                #region for test
                /*
                var convertResult = new List<Comment>() {
                    new Comment(){Id = 22, Messsage = "messss1", PhotoId = 2},
                    new Comment(){Id = 23, Messsage = "messss2", PhotoId = 2},
                    new Comment(){Id = 24, Messsage = "messss3", PhotoId = 2},
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
