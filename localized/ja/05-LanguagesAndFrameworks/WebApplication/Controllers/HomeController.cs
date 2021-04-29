using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // 1. Navigate to view
        public IActionResult Index(int? id)
        {
            // <shortcut id="Go to Declaration or Usages">Ctrl+Click</shortcut> on View
            // Navigate to Index.cshtml, or definition of View method
            if (id == null)
                return View();

            // <shortcut id="Go to Declaration or Usages">Ctrl+Click</shortcut> on string literal argument
            return View("Index");
        }
        
        // 2. Create view from usage
        public IActionResult Details(int? id)
        {
            // View is marked as error, but code compiles
            // <shortcut id="Go to Declaration or Usages">Ctrl+Click</shortcut> navigates straight to definition of View method
            // <shortcut id="Show context actions">Alt+Enter</shortcut> to create view as .cshtml, .aspx, with layout, via VS wizard, etc.
            if (id == null)
                return View();

            // View is marked as error, but code compiles
            // <shortcut id="Go to Declaration or Usages">Ctrl+Click</shortcut> navigates straight to definition of View method
            // <shortcut id="Show context actions">Alt+Enter</shortcut> to create view as .cshtml, .aspx, with layout, via VS wizard, etc.
            return View("MoreDetails");
        }
        
        // 3. Code completion for views
        public IActionResult DoThing()
        {
            // Place text caret inside string literal
            // Invoke completion (<shortcut id="Basic Completion">Ctrl+Space</shortcut>)
            return View("");
        }
        
        // 3. Code completion in RedirectToAction
        [HttpPost]
        public ActionResult Create(SampleModel model)
        {
            // a. Place text caret inside string literal for actionName
            //    Invoke completion (<shortcut id="Basic Completion">Ctrl+Space</shortcut>) - suggests actions from this controller
            if (model == null)
            {
                // b. <shortcut id="Go to Declaration or Usages">Ctrl+Click</shortcut>on RedirectToAction method
                //    Navigates to method or controller
                return RedirectToAction(actionName: "");
            }

            // c. Place text caret inside string literal for actionName
            //    Invoke completion (<shortcut id="Basic Completion">Ctrl+Space</shortcut>) - no suggestions
            //    Place text caret inside string literal for controllerName
            //    Invoke completion - suggests controllers
            //    Place text caret inside string literal for actionName
            //    Invoke completion - suggests actions for selected controller
            return RedirectToAction(actionName: "", controllerName: "");

            // d. Navigate to action or controller
            //    <shortcut id="Go to Declaration or Usages">Ctrl+Click</shortcut> on string literal to navigate
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}