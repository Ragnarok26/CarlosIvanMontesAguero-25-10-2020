using System.Collections.Generic;
using Entity.Music;
using Entity.Response;
using Microsoft.AspNetCore.Mvc;

namespace Front.Controllers
{
    public class MusicController : Controller
    {
        public IActionResult Index()
        {
            Response<IEnumerable<Album>> response = new Response<IEnumerable<Album>>();
            using (var logic = new Logic.Music.Music())
            {
                response = logic.GetAlbumList();
            }
            if (response.Success)
            {
                return View(response.Data);
            }
            else
            {
                return StatusCode(500, response.Message);
            }
        }

        public IActionResult Photos(int id)
        {
            Response<IEnumerable<Photo>> response = new Response<IEnumerable<Photo>>();
            using (var logic = new Logic.Music.Music())
            {
                response = logic.GetPhotoListByAlbum(id);
            }
            if (response.Success)
            {
                return View(response.Data);
            }
            else
            {
                return StatusCode(500, response.Message);
            }
        }

        public IActionResult Comments(int id)
        {
            Response<IEnumerable<Comment>> response = new Response<IEnumerable<Comment>>();
            using (var logic = new Logic.Music.Music())
            {
                response = logic.GetCommentListByPhoto(id);
            }
            if (response.Success)
            {
                return PartialView(response.Data);
            }
            else
            {
                return StatusCode(500, response.Message);
            }
        }
    }
}
