using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GleanerMimic.Domain.Entities;

namespace GleanerMimic.Domain.Abstract
{
    public interface IMyUser
    {
        IQueryable<MyUser> myUsers { get; }        
    }

    
}
