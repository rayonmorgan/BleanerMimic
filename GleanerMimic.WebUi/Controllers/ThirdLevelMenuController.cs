using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GleanerMimic.WebUi.Controllers
{
    public class ThirdLevelMenuController : Controller
    {
        //
        // GET: /ThirdLevelMenu/

        public ActionResult ThirdMenu()
        {
            return PartialView();
        }

    }
}
