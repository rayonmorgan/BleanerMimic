using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GleanerMimic.Domain.Entities;
using GleanerMimic.Domain.Abstract;


namespace GleanerMimic.Domain.Concrete
{
    public class CArticleRepository : IArticleRepository
    {  

        private DbArticleContext context = new DbArticleContext();

        public IQueryable<Article> article
        {

            get { return context.article ; }
        }

        public IQueryable<articleType> articleType
        {
            get { return context.articleType; }
        }



        public void SaveArticle(Article article)
        {
            if (article.itemId == 0 || article.itemId == null)
            {
                context.article.Add(article);
            }
            else
            {
                Article dataEntry = context.article.Find(article.itemId);
                if(dataEntry != null)
                {
                    dataEntry.headerText = article.headerText;
                    dataEntry.bodyText = article.bodyText;
                    dataEntry.article_option = article.article_option;
                    dataEntry.articleType = article.articleType;
                    dataEntry.imageFolder = article.imageFolder;
                    dataEntry.imageName = article.imageName;
                    dataEntry.submittedBy = article.submittedBy;
                    dataEntry.submitTime = article.submitTime;
                }
            }
            context.SaveChanges();
        }

        public int DeleteArticle(int id)
        {
            if(id != 0)
            {
                context.article.Remove(context.article.Where(x => x.itemId == id).First());               
            }
            return context.SaveChanges();
        }
    }
}
