using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.Mvc;
using System.Web.Security;

namespace GleanerMimic.WebUi.Helpers
{
    public static class GleanerPageHelper
    {
        public static MvcHtmlString TopMenu(this HtmlHelper helper)
        {
            StringBuilder result = new StringBuilder();
            var menu = new List<string> {"Home","Lead Stories","News","Sports","Entertainment","Business","Letters","Commentary","Flair","Health","Food" };
            TagBuilder unlist = new TagBuilder("ul");
            unlist.AddCssClass("nav navbar-nav");
            foreach (var item in menu)
            {
                TagBuilder tag = new TagBuilder("li");
                TagBuilder anchor = new TagBuilder("a");
                anchor.InnerHtml = item;
                switch(item)
                {
                    case "Home":
                        anchor.MergeAttribute("href", "/");
                        break;
                    default:
                        anchor.MergeAttribute("href","/Maintainance/maintain");
                        break;
                }
                
                anchor.AddCssClass("text-colour");
               
                tag.InnerHtml = anchor.ToString();               
                result.Append(tag.ToString());
                
            }
            unlist.InnerHtml = result.ToString() ;
            result.Clear();
            result.Append(unlist.ToString());
            
            return MvcHtmlString.Create(result.ToString());
        } //end of TopMenu


        public static MvcHtmlString SecondaryMenu(this HtmlHelper helper)
        {
            StringBuilder result = new StringBuilder();
            var secondarmenu = new List<string> {"World News","Lifestyle","In Focus","Auto","Social","Outlook","Shipping","Western Focus","Art & Leisure" };
            var thirdMenu = new List<string> {"Jobs","Power 106","Classifieds" };
            TagBuilder unlist = new TagBuilder("ul");
            unlist.AddCssClass("nav navbar-nav");

            TagBuilder span = new TagBuilder("span");
            foreach(var item in secondarmenu)
            {
                TagBuilder list = new TagBuilder("li");
                TagBuilder anchor = new TagBuilder("a");
                anchor.InnerHtml = item;
                anchor.MergeAttribute("href", "/maintainance/maintain");
                anchor.AddCssClass("text-colour");

                list.InnerHtml = anchor.ToString();
                result.Append(list.ToString());
            }
          

            foreach(var item in thirdMenu)
            {
                TagBuilder list = new TagBuilder("li");
                TagBuilder anchor = new TagBuilder("a");
                anchor.InnerHtml = item;
                anchor.MergeAttribute("href", "#");
                anchor.AddCssClass("gold-menu");
                list.AddCssClass("gold-list");

                list.InnerHtml = anchor.ToString();                
                result.Append(list.ToString());
            }

            unlist.InnerHtml = result.ToString();
            span.InnerHtml = unlist.ToString();
            result.Clear();
            result.Append(span.ToString());

            return MvcHtmlString.Create(result.ToString());
        } //end of Secondary Menu

        public static MvcHtmlString topAppsMenu(this HtmlHelper helper)
        {
            StringBuilder result = new StringBuilder();
            var menu = new List<string> {"Mobile Apps","ePaper","Login","Subscribe Now" };
            TagBuilder unlist = new TagBuilder("ul");
            unlist.AddCssClass("nav navbar-nav");
            foreach(var item in menu)
            {
                TagBuilder list_item = new TagBuilder("li");
                TagBuilder anchor_item = new TagBuilder("a");
                anchor_item.InnerHtml = item;
                switch(item)
                {
                    case "Logout":
                    case "Login":
                        if (!HttpContext.Current.User.Identity.IsAuthenticated)
                        {
                            anchor_item.MergeAttribute("href", "/Account/Login");
                            anchor_item.InnerHtml = "Login";
                        }
                        else
                        {
                            anchor_item.MergeAttribute("href", "/Account/Logout");
                            anchor_item.InnerHtml = "Logout";
                        }
                        
                        break;
                    default:
                        anchor_item.MergeAttribute("href", "#");
                        break;
                }
                
               
                list_item.InnerHtml = anchor_item.ToString();

                result.Append(list_item.ToString());
            }
            unlist.InnerHtml = result.ToString();
            result.Clear();
            result.Append(unlist.ToString());

            return MvcHtmlString.Create(result.ToString());
        }//end of topAppMenu 


        public static MvcHtmlString weatherIcon(this HtmlHelper helper, string weatherName)
        {
            StringBuilder result = new StringBuilder();
            TagBuilder img_tag = new TagBuilder("img");
            img_tag.MergeAttribute("alt", weatherName);
            img_tag.MergeAttribute("src", "~/images/" + weatherName+".jpg");
            img_tag.MergeAttribute("class", "weather-img");

            result.Append(img_tag.ToString());


            return MvcHtmlString.Create(result.ToString());
        }//end of weatherIcon

        public static MvcHtmlString ThirdLevelMenu(this HtmlHelper helper)
        {
            StringBuilder results = new StringBuilder();
            TagBuilder image = new TagBuilder("img");
            image.MergeAttribute("src", "/images/adTop.jpg");
            image.MergeAttribute("alt","");
            image.MergeAttribute("class", "img-responsive");

            results.Append(image.ToString());
            return MvcHtmlString.Create(results.ToString());
        } //end of ThirdLevelMenu

        public static MvcHtmlString InTheNews(this HtmlHelper helper)
        {
            StringBuilder result = new StringBuilder();
            TagBuilder first_item = new TagBuilder("a");
            first_item.MergeAttribute("href", "#");
            first_item.InnerHtml = "myReport";
            first_item.MergeAttribute("class", "in-news-firt-item in-news-global");

            TagBuilder second_item_container = new TagBuilder("span");
            second_item_container.MergeAttribute("class", "icon-circle ");

            TagBuilder second_item = new TagBuilder("p"); 
            second_item.InnerHtml = "&#9899;";
         

            second_item_container.InnerHtml = second_item.ToString();

            List<string> items = new List<string> {"WATCH: 14 shot dead in US...More Trafigura deals...Youths dominate voters' list" };

            result.Append(first_item.ToString());
            result.Append(second_item_container.ToString());
            foreach(var item in items)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", "#");
                tag.MergeAttribute("class", "in-news-second-item in-news-global");
                tag.InnerHtml = item;

                result.Append(tag.ToString());
            }
            return MvcHtmlString.Create(result.ToString());
        }

    
    }//class
} //namespace