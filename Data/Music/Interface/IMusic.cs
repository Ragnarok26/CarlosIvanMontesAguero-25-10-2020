using Entity.Music;
using Entity.Response;
using System;
using System.Collections.Generic;

namespace Data.Music.Interface
{
    public interface IMusic : IDisposable
    {
        Response<IEnumerable<Album>> GetAlbumList();
        Response<IEnumerable<Photo>> GetPhotoList();
        Response<IEnumerable<Comment>> GetCommentList();
    }
}
