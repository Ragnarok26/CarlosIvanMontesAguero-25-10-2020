using Entity.Music;
using Entity.Response;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic.Music
{
    public class Music : Interface.IMusic
    {
        public void Dispose()
        {
        }

        public Response<IEnumerable<Album>> GetAlbumList()
        {
            using (var data = new Data.Music.Music())
            {
                return data.GetAlbumList();
            }
        }

        public Response<IEnumerable<Comment>> GetCommentListByPhoto(int idPhoto)
        {
            Response<IEnumerable<Comment>> response = new Response<IEnumerable<Comment>>();
            using (var data = new Data.Music.Music())
            {
                response = data.GetCommentList();
            }
            if (response.Success)
            {
                try
                {
                    response.Data = response.Data.Where(comment => comment.PostId == idPhoto);
                }
                catch (Exception ex)
                {
                    response.Data = null;
                    response.Success = false;
                    response.Message = ex.Message;
                }
            }
            return response;
        }

        public Response<IEnumerable<Photo>> GetPhotoListByAlbum(int idAlbum)
        {
            Response<IEnumerable<Photo>> response = new Response<IEnumerable<Photo>>();
            using (var data = new Data.Music.Music())
            {
                response = data.GetPhotoList();
            }
            if (response.Success)
            {
                try
                {
                    response.Data = response.Data.Where(comment => comment.AlbumId == idAlbum);
                }
                catch (Exception ex)
                {
                    response.Data = null;
                    response.Success = false;
                    response.Message = ex.Message;
                }
            }
            return response;
        }
    }
}
