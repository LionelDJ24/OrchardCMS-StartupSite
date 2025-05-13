using Microsoft.AspNetCore.Mvc;

namespace OrchardCore.Cms.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Hello()
        {
            return Content("✅ Orchard Core MVC works!");
        }
    }
}
