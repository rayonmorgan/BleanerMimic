using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using GleanerMimic.Domain.Entities;
using System.Web.Mvc;

namespace GleanerMimic.WebUi.Models
{
    public class ArticleModel
    {
        public IEnumerable<Article> article { get; set; }
        public Article singleArticle { get; set; }
        public List<SelectListItem> articleType { get; set; }
    }
}