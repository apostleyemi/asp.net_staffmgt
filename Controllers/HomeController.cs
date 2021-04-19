using ems.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ems.Models;



namespace ems.Controllers
{
    public class HomeController : Controller
    {


        //  private readonly IStaffRepository _staffRepository;
        // //public HomeController(IStaffRepository staffRepository)
        // public HomeController()
        // {
        //     _staffRepository = new MockStaffsRepository();  
        // }

        private readonly IStaffRepository _staffRepository;
        //public HomeController(IStaffRepository staffRepository)
        public HomeController(IStaffRepository staffRepository)
        {
            _staffRepository =staffRepository;  
        }


        //private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger, IStaffRepository staffRepository)
        // {
        //         _logger = logger;
        //       _staffRepository =staffRepository;  
        // }
        
         // this method returns multiple data from the Model
        public ViewResult Index()
        {
            var model= _staffRepository.GetAllStaffs();
            return View(model); 
        }
        
        public string Indexview()
        {
             return _staffRepository.GetStaffs(1).Name;
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        
        [HttpPost]
         public IActionResult Create(Staffs staff)
        {
           // return View();
        if(ModelState.IsValid)
        {

      
           Staffs newStaff= _staffRepository.Add(staff);

           return RedirectToAction("Detailsgetwithid", new {id=newStaff.Id});
         }

         return View();

        }

        //get the info in json form
        public ViewResult Details()
        {  Staffs model= _staffRepository.GetStaffs(1);
            ViewData["Staff"]=model;
            ViewData["PageTitle"] ="Staff Details";
            return View(model);

        }

        //this method get user dynamically by id
         //get the info in json form
        public ViewResult Detailsgetwithid(int id)
        {  Staffs model= _staffRepository.GetStaffs(id);
            ViewData["Staff"]=model;
            ViewData["PageTitle"] ="A Staff Detail fetch with ID";
            return View(model);

        }

        // using viewbag to send data to view

        public ViewResult ShowDataBag(){
            Staffs model= _staffRepository.GetStaffs(1);
            ViewBag.Staff=model;
            ViewBag.PageTitle= "Staff Details";

            return View();

        }

        public ViewResult ShowStrongData()
        {
             Staffs model= _staffRepository.GetStaffs(2);
             ViewBag.PageTitle= "Staff Details on Strongly Display data";

             return View(model);
        }

        //return to a default view 
        //send value to view with Viewdata method
        public ViewResult Resultpage()
        {  Staffs model= _staffRepository.GetStaffs(1);
            return View(model);
        }

        //this method send data between ViewModels , view and Controller 
        //the essence is to send more than on data at a time

        public ViewResult Getdetails()
        {    HomeGetdetailsViewModel homeGetdetailsViewModel  = new HomeGetdetailsViewModel()
        {
            Staffs = _staffRepository.GetStaffs(1),
            nStaffs = _staffRepository.GetStaffs(2),

            PageTitle = "Staff Information Page with ModelView"

        };
             //Staffs model= _staffReposito ry.GetStaffs(1);
            return View(homeGetdetailsViewModel);
        }
 
        //return to a specified view test.cshtml
        
         public ViewResult Resulttest()
        {  Staffs model= _staffRepository.GetStaffs(1);
            return View("Test");
        }
        // get the value in object form
         public ObjectResult Inobj()
        {  Staffs model= _staffRepository.GetStaffs(2);
            return new ObjectResult(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
