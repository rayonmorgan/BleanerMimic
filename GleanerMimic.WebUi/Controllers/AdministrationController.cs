using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GleanerMimic.Domain.Abstract;
using GleanerMimic.Domain.Entities;
using GleanerMimic.WebUi.Models;
using System.Web.Security;


namespace GleanerMimic.WebUi.Controllers
{
    [Authorize]    
    public class AdministrationController : Controller
    {
        private IArticleRepository articleRepository;
        
        public AdministrationController(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }

        //
        // GET: /Administration/

        public ActionResult Admin()
        {
            return View();
        }
        public ActionResult List()
        {
            return View(articleRepository.article);
        }

   

        //
        // GET: /Administration/Create
        public ActionResult Create()
        {
            ViewBag.edit_create = "Add New Article";
            ArticleModel articleModel = new ArticleModel()
            {
                 
                articleType = article_list(), //assign the populated article_list to the model property articleType
                
            };
           
            return View(articleModel);
        }

        //
        // POST: /Administration/Create

        [HttpPost]
        public ActionResult Create(ArticleModel article)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    article.singleArticle.submittedBy = "morganr";
                    article.singleArticle.submitTime = DateTime.Now;

                    articleRepository.SaveArticle(article.singleArticle);
                    return RedirectToAction("Admin");
                }
                else
                {
                    ViewBag.edit_create = "Add New Post Article";
                    article.articleType = article_list(); 
                    return View(article);
                }
                
                
            }
            catch(Exception ex)
            {
                TempData["message"] = ex.Message;
                return View(article);
            }
        }

        //
        // GET: /Administration/Edit/5

        public ActionResult Edit(int id)
        {
            ViewBag.edit_create = "Edit Article";
            var get_edit_item = articleRepository.article.Where(x=>x.itemId == id).First();
            ArticleModel edit_model = new ArticleModel
            {
                singleArticle = get_edit_item,
                articleType = article_list()
            };

            return View("create",edit_model);
        }

        //
        // POST: /Administration/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Administration/Delete/5

        //public ActionResult Delete(int id)
        //{
        //    return View("create");
        //}

        //
        // POST: /Administration/Delete/5

        [HttpPost]
        public ActionResult Delete(int itemId, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                articleRepository.DeleteArticle(itemId);
                return RedirectToAction("Admin");
            }
            catch
            {
                return View();
            }
        }

        public List<SelectListItem> article_list()
        {
             //create a list of type SelectListItem to use for the article type dropdownlist
            List<SelectListItem> article_list = new List<SelectListItem>();

            //traverse the data set for article type coming from the DB
            //and assign the values to the article list variable
            foreach(var items in articleRepository.articleType)
            {
                article_list.Add(
                    new SelectListItem
                    {
                        Value = items.articletype.ToString(),
                        Text = items.articletype
                    }
                );
            }
            return article_list;
        }
    }
}
