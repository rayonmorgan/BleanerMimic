using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Web.Mvc;

namespace GleanerMimic.Domain.Entities
{
   [Table("Article")]
    public class Article
    {
        [Key]  
        [HiddenInput] 
        public int? itemId { get; set; }  //Unique Identification of the item being stored
        public string imageFolder { get; set; } //folder containing the Article  image
        public string imageName { get; set; } //name of image for the article
        
        [DisplayName("Article Title")]
        [MaxLength(400)]
        [Required(ErrorMessage="Title of article is required")]
        public string headerText { get; set; } //Header text for article
       
        [DataType(DataType.MultilineText)]
        [DisplayName("Article Body")]
        [Required(ErrorMessage="Body of the article is required")]
        public string bodyText { get; set; }    //body of the article
       
        [Required(AllowEmptyStrings=false,ErrorMessage="Please select an article type")]
        public string articleType { get; set; } //type of article: Latest News,Lead Stories,News,Sports,Business,Entertainment
                                              //Commentary,World News,Art&Leisure,Auto,In Focus,Outlook,
        
        public DateTime? submitTime { get; set; } //date and time article was submitted
        public string submittedBy { get; set; } //article was submitted by who 
        public string article_option { get; set; } //primary of secondary article
        
    }

   [Table("articleType")]
   public class articleType
   {
       public int id { get; set; }
       public string articletype { get; set; }
   }
}
    