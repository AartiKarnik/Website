using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class ArticleFormController : SurfaceController
    {
        // GET: ArticleForm
        public ActionResult Render()
        {
            var articleModel = new ArticleModel();
            return PartialView("ArticleForm", articleModel);
        }
        [HttpPost]
        [ValidateUmbracoFormRouteString]
        public ActionResult Submit(ArticleModel model)
        {
            return RedirectToCurrentUmbracoPage();
        }
    }
}