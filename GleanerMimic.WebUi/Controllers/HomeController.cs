using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GleanerMimic.Domain.Abstract;
using GleanerMimic.WebUi.Models;


namespace GleanerMimic.WebUi.Controllers
{
    public class HomeController : Controller
    {
           
        private IArticleRepository article;
        public HomeController(IArticleRepository article)
        {
            this.article = article;
            
        }
        //
        // GET: /Home/

        public ActionResult Home()
        {
           ArticleModel localArticle = new  ArticleModel
            {
                article = article.article                 
                .OrderBy(x=>x.articleType)
                 
            };
            
            return View(localArticle);
        }

    }
}
