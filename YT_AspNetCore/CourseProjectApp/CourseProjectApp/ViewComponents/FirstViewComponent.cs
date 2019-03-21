using CourseProjectApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.ViewComponents
{
    public class FirstViewComponent :ViewComponent
    {
        private IMyInjectedInterface myService;

        public FirstViewComponent(IMyInjectedInterface service)
        {
            myService = service;
        }

        public async Task<IViewComponentResult> InvokeAsync() //overload method /InvokeAsync()/ neophodno ime
        {
            var myItem = await GetGuid();

            return View("Default", myItem);
        }

        private async Task<IMyInjectedInterface> GetGuid()
        {
            return await Task.FromResult(myService);
        }

    }
}
