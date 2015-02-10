using System.Web.Mvc;

namespace AspNetMvc.Controllers
{
    public class DefaultController : Controller
    {
        // 1. Navigate to view
        public ActionResult Index(int? id)
        {
            // Ctrl+Click on View
            // Navigate to Index.cshtml, or definition of View method
            if (id == null)
                return View();

            // Ctrl+Click on string literal argument
            return View("Index");
        }

        // 2. Create view from usage
        public ActionResult Details(int? id)
        {
            // View is marked as error, but code compiles
            // Ctrl+Click navigates straight to definition of View method
            // Alt+Enter to create view as .cshtml, .aspx, with layout, via VS wizard, etc.
            if (id == null)
                return View();

            // View is marked as error, but code compiles
            // Ctrl+Click navigates straight to definition of View method
            // Alt+Enter to create view as .cshtml, .aspx, with layout, via VS wizard, etc.
            return View("MoreDetails");
        }

        // 3. Code completion for views
        public ActionResult DoThing()
        {
            // Place text caret inside string literal
            // Invoke completion (Ctrl+Space)
            return View("");
        }

        // 3. Code completion in RedirectToAction
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            // a. Place text caret inside string literal for actionName
            //    Invoke completion (Ctrl+Space) - suggests actions from this controller
            if (collection == null)
            {
                // b. Ctrl+Click on RedirectToAction method
                //    Navigates to method or controller
                return RedirectToAction(actionName: "");
            }

            // c. Place text caret inside string literal for actionName
            //    Invoke completion (Ctrl+Space) - no suggestions
            //    Place text caret inside string literal for controllerName
            //    Invoke completion - suggests controllers
            //    Place text caret inside string literal for actionName
            //    Invoke completion - suggests actions for selected controller
            return RedirectToAction(actionName: "", controllerName: "");

            // d. Navigate to action or controller
            //    Ctrl+Click on string literal to navigate
        }
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
