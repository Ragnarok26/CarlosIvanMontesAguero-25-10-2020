using Entity.Music;
using Entity.Response;
using System;
using System.Collections.Generic;

namespace Data.Music
{
    public class Music : Interface.IMusic
    {
        public void Dispose()
        {
        }

        public Response<IEnumerable<Album>> GetAlbumList()
        {
            Response<IEnumerable<Album>> response = new Response<IEnumerable<Album>>();
            try
            {
                using (var client = new ClientService.Client())
                {
                    response.Success = true;
                    response.Data = client.GetServiceData<List<Album>>("https://jsonplaceholder.typicode.com/albums");
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                response.Data = null;
            }
            return response;
        }

        public Response<IEnumerable<Comment>> GetCommentList()
        {
            Response<IEnumerable<Comment>> response = new Response<IEnumerable<Comment>>();
            try
            {
                using (var client = new ClientService.Client())
                {
                    response.Success = true;
                    response.Data = client.GetServiceData<List<Comment>>("https://jsonplaceholder.typicode.com/comments");
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public Response<IEnumerable<Photo>> GetPhotoList()
        {
            Response<IEnumerable<Photo>> response = new Response<IEnumerable<Photo>>();
            try
            {
                using (var client = new ClientService.Client())
                {
                    response.Success = true;
                    response.Data = client.GetServiceData<List<Photo>>("https://jsonplaceholder.typicode.com/photos");
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
