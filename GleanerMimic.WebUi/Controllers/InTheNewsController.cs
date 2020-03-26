using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GleanerMimic.WebUi.Controllers
{
    public class InTheNewsController : Controller
    {
        //
        // GET: /InTheNews/

        public ActionResult showHeadlines()
        {
            return PartialView("showHeadlines");
        }

    }
}
