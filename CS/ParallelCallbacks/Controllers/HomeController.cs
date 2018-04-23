using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace DevExpressMvcApplication1.Controllers {
    public class HomeController : Controller {
        private static int progress;
        public ActionResult Index() {
            return View();
        }
        [HttpPost]
        public JsonResult Start() {
            int count = 10;
            for (int i = 0; i < count; i++) {
                progress = Convert.ToInt32(Convert.ToDouble(i) / Convert.ToDouble(count) * 100);
                System.Threading.Thread.Sleep(500);
            }
            var result = new { StartResult = "ok" };
            progress = 0;
            return Json(result);
        }
        [HttpPost]
        public JsonResult Progress() {
            var result = new { ProgressResult = progress };
            return Json(result);
        }
    }
}
