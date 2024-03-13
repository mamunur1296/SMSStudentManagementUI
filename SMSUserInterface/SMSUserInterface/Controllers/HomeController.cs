using Microsoft.AspNetCore.Mvc;
using SMS.BusinessLogicLayer.InfrastructureService;
using SMS.BusinessObjectLayer.ViewModels;
using SMSUserInterface.Models;
using System.Diagnostics;

namespace SMSUserInterface.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWorkService _unitOfWorkService;

        public HomeController(IUnitOfWorkService unitOfWorkService)
        {
            _unitOfWorkService = unitOfWorkService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ContactInfoViewcs ContactList = new ContactInfoViewcs();
            ContactList.ContactsList = await _unitOfWorkService.ContactService.GetAllAsync();
            return View(ContactList);
        }

        [HttpGet]
        public IActionResult CreateAndUpdate()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAndUpdate(ContactInfoViewcs  model)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWorkService.ContactService.CreateAsync(model.Contact);
                return RedirectToAction("Index");
            }
            return View();
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
