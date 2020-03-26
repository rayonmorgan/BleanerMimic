using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GleanerMimic.Domain.Entities
{
    [Table("MyUsers")]
    public class MyUser
    {
        [Key]
        public int? myId { get; set; }
        
        [Required]
        [DisplayName("User Name")]
        public string myUserName { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string myPassword { get; set; }
    }
}
