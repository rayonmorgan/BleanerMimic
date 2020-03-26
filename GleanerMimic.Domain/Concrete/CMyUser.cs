using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GleanerMimic.Domain.Abstract;
using GleanerMimic.Domain.Entities;

namespace GleanerMimic.Domain.Concrete
{
   public class CMyUser : IMyUser
    {
       private DbArticleContext myUserEF = new DbArticleContext();

        public IQueryable<MyUser> myUsers
        {
            get { return myUserEF.myUser; }
        }
    }
}
