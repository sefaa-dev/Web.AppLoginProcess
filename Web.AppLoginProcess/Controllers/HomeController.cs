using LoginProcess.BusinessLayer;
using LoginProcess.BusinessLayer.Test;
using LoginProcess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Web.AppLoginProcess.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            PostManager post = new PostManager();
            ViewBag.GetPost = post.GetPosts();
            return View(ViewBag.GetPost);
        }
        public ActionResult GetTag(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TagManager tg = new TagManager();
            Tag tgm = tg.GetTag(id.Value);
            if (tgm == null)
            {
                return HttpNotFound();
            }
            return View("Index", tgm.Posts);
        }
    }
}