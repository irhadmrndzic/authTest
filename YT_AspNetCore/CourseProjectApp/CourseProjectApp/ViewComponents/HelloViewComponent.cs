using CourseProjectApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.ViewComponents
{
    public  class HelloViewComponent : ViewComponent
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public HelloViewComponent(UserManager<ApplicationUser> uMan)
        {
            _userManager = uMan;
        }
        public Task<ApplicationUser> GetCurrentUserAsync()
        {
            return _userManager.GetUserAsync(HttpContext.User);
        }

        [HttpGet]
        public async Task<string> GetCurrentUsername()
        {
            ApplicationUser usr = await GetCurrentUserAsync();
            return usr?.UserName;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ApplicationUser usr = await GetCurrentUserAsync();
            return View("Default",usr);
        }
    }
}
