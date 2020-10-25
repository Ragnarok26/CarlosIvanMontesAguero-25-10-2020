using Entity.Music;
using Entity.Response;
using System;
using System.Collections.Generic;

namespace Logic.Music.Interface
{
    public interface IMusic : IDisposable
    {
        Response<IEnumerable<Album>> GetAlbumList();
        Response<IEnumerable<Photo>> GetPhotoListByAlbum(int idAlbum);
        Response<IEnumerable<Comment>> GetCommentListByPhoto(int idPhoto);
    }
}
