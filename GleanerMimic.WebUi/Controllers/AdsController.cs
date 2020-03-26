using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GleanerMimic.WebUi.Controllers
{
    public class AdsController : Controller
    {
        //
        // GET: /Ads/

        public ActionResult MainAds()
        {
            List<string> ads = new List<string>
            {
                "17410747344707409392",
                "456266889215621836",
                "6359620565487284357",
                "hospitality-20151111"
            };
            return View();
        }

    }
}
