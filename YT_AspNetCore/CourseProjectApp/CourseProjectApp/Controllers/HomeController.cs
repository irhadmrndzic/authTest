using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using CourseProjectApp.Entities; EXCLUDED FROM PROJECT
using CourseProjectApp.Models;
using CourseProjectApp.Services;
using CourseProjectApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CourseProjectApp.Controllers
{
    public class HomeController : Controller
    {

        private IMyInjectedInterface myService;
    //    private ApplicationDbContext myContext;

        public HomeController(IMyInjectedInterface service /*,ApplicationDbContext context*/)
        {
            myService = service;
         //   myContext = context;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.myObject = myService;
          //  SeedData.Seed(myContext);
            return View();  
        }
        

        public IActionResult FirstView()
        {
            // var model = new Test { Id = 2, Value = "Testiranje dodavanja podataka u view" };

            var model = new List<Test> {
                new Test{Id=1,Value="Prva vrijednost."},
                new Test{Id=2,Value="Druga vrijednost."},
                new Test{Id=3,Value="Treca vrijednost."},
                new Test{Id=4,Value="Četvrta vrijednost."},
                new Test{Id=5,Value="Peta vrijednost."}
            };
            //Kreira se enitet u koji se posalje viewModel

            var viewModel = new TestViewModel();
            viewModel.TipTest = model;

            return View(viewModel);
        }
        public ContentResult IdRoute() //isto kao da vraca string 
        {
            return Content("Neki string");
        }

        //vracanje objekata

        public ObjectResult Objekat() //koristi se kod WEB API-a, Moze se koristiti i JsonResult
        {
            var model = new Test { Id=1, Value="Irhad"};
            return new ObjectResult(model); // Moze vracati i return Json(model)
        } 

        private async Task<IMyInjectedInterface> GetGuid()
        {
            return await Task.FromResult(myService);
        }
        public  IActionResult Tester()
        {
            return View();
        }
    }
}
