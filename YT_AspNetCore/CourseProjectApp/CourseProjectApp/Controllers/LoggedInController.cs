using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CourseProjectApp.DATA;
using CourseProjectApp.Models;
using CourseProjectApp.Repository;
using CourseProjectApp.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CourseProjectApp.Controllers
{
    public class LoggedInController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IProfileRepository _profileRepository;

        public LoggedInController(UserManager<ApplicationUser> userManager, IProfileRepository repo)
        {
            _userManager = userManager;
            _profileRepository = repo;
        }

        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var hobbies = _profileRepository.GetHobbiesList(userId);
            var individual = _profileRepository.GetIndividualsList(userId);
            var organization = _profileRepository.GetOrganizationsList(userId);

            var model = new DashboardViewModel
            {
                Hobby = hobbies,
                Individuals = individual,
                Organization = organization
            };
            return View(model);
        }
    }
}