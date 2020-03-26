using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GleanerMimic.Domain.Entities;
using GleanerMimic.Domain.Abstract;
using System.Web.Security;
using System.Web.UI.WebControls;
 

namespace GleanerMimic.WebUi.Controllers
{
    public class AccountController : Controller
    {
        IMyUser userRepository;
        public AccountController(IMyUser userRepository)
        {
            this.userRepository = userRepository;
        }
        //
        // GET: /Account/
        [HttpGet]
        public ActionResult Login()
        {
            if(User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Admin", "Administration");
            }else
            {
                return View(new MyUser());
            }
           
        }

        [HttpPost]
        public ActionResult Login(MyUser myUsers)
        {
            if(ModelState.IsValid)
            {
                
                var userExist = userRepository.myUsers
                    .Where(x => x.myUserName ==myUsers.myUserName.Trim() && x.myPassword ==myUsers.myPassword.Trim()).Count();
                if (userExist > 0)
                {
                    FormsAuthentication.SetAuthCookie(myUsers.myUserName, false);
                    return RedirectToAction("Admin","Administration");
                }
                else
                {
                  
                    
                    ModelState.AddModelError("sdf", "Invalid User Name or Password");
                    return View(myUsers);
                }                
              
            }else{
                return View(myUsers);
            }

            
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Home","Home");
        }
    }
}
