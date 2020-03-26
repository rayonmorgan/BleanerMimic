using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using GleanerMimic.Domain.Abstract;
using GleanerMimic.WebUi.Models;

namespace GleanerMimic.WebUi.Controllers
{
    public class ViewArticleController : Controller
    {
        IArticleRepository articleRepository;

        public ViewArticleController(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }
         
        public ActionResult Details(int id)
        {
            ArticleModel detailsModel = new ArticleModel
            {
                singleArticle = articleRepository.article.Where(x=>x.itemId==id).First()
            };

            return View(detailsModel);
        }
         
        
    }
}
