using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GleanerMimic.Domain.Entities;

namespace GleanerMimic.Domain.Abstract
{
    public interface IArticleRepository
    {
       IQueryable<Article> article { get; } //Queryable property of the article class

       IQueryable<articleType> articleType { get; } //get articletype from database

       void SaveArticle(Article article);    //save article to the underline database
       int DeleteArticle(int id);   //delete article from the system
    }
}
