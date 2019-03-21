using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using CourseProjectApp.DATA;
using CourseProjectApp.EntityModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CourseProjectApp.Controllers
{

    [Route("api/[controller]")]
    public class ProfileController : Controller
    {

        private readonly ProfileContext _context;
        public ProfileController(ProfileContext ctx)
        {
            _context = ctx;
        }


        //Create
        [HttpPost]
        public async Task<IActionResult> CreateHobby(Hobbies model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(model);

                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index", "LoggedIn");
                }
            }
            catch (DbException e)
            {
                ModelState.AddModelError(e.ToString(), "Unable to save changes! ");
            }
            return RedirectToAction("Index", "LoggedIn", model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateIndividual(Individual model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(model);

                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index", "LoggedIn");
                }
            }
            catch (DbException e)
            {
                ModelState.AddModelError(e.ToString(), "Unable to save changes! ");
            }
            return RedirectToAction("Index", "LoggedIn", model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrganization(Organization model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(model);

                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index", "LoggedIn");
                }
            }
            catch (DbException e)
            {
                ModelState.AddModelError(e.ToString(), "Unable to save changes! ");
            }
            return RedirectToAction("Index", "LoggedIn", model);
        }


        //Edit
        [HttpPost]
        public async Task<IActionResult> EditHobby(Guid id, Hobbies model)
        {

            if (id != model.HobbiesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "LoggedIn");
                }
                catch (DbUpdateException e)
                {

                    ModelState.AddModelError(e.ToString(), "Unable to edit changes! ");
                }
            }
            return RedirectToAction("Index", "LoggedIn", model);
        }

        [HttpPost]
        public async Task<IActionResult> EditOrganization(Guid id, Organization model)
        {

            if (id != model.OrganizationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "LoggedIn");

                }
                catch (DbUpdateException e)
                {

                    ModelState.AddModelError(e.ToString(), "Unable to edit changes! ");
                }
            }
            return RedirectToAction("Index", "LoggedIn", model);
        }


        [HttpPost]
        public async Task<IActionResult> EditIndividual(Guid id, Individual model)
        {

            if (id != model.IndividualId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "LoggedIn");
                }
                catch (DbUpdateException e)
                {
                    ModelState.AddModelError(e.ToString(), "Unable to edit changes! ");
                }
            }
            return RedirectToAction("Index", "LoggedIn", model);
        }

        //Delete

        [HttpPost]

        public async Task<IActionResult> DeleteHobby(Guid Id)
        {
            var model = await _context.Hobbies.SingleOrDefaultAsync(x => x.HobbiesId == Id);

            if (model == null)
            {
                return RedirectToAction("Index", "LoggedIn");
            }
            try
            {
                _context.Hobbies.Remove(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "LoggedIn");

            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError(ex.ToString(),"Error");
                return RedirectToAction("Index", "LoggedIn");

            }
        }

        public async Task<IActionResult> DeleteIndividual(Guid Id)
        {
            var model = await _context.Individuals.SingleOrDefaultAsync(x => x.IndividualId == Id);

            if (model == null)
            {
                return RedirectToAction("Index", "LoggedIn");
            }
            try
            {
                _context.Individuals.Remove(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "LoggedIn");

            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError(ex.ToString(), "Error");
                return RedirectToAction("Index", "LoggedIn");

            }
        }

        public async Task<IActionResult> DeleteOrganization(Guid Id)
        {
            var model = await _context.Organizations.SingleOrDefaultAsync(x => x.OrganizationId == Id);

            if (model == null)
            {
                return RedirectToAction("Index", "LoggedIn");
            }
            try
            {
                _context.Organizations.Remove(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "LoggedIn");

            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError(ex.ToString(), "Error");
                return RedirectToAction("Index", "LoggedIn");

            }
        }

        //DetailHobby
        [HttpGet]
        public async Task<IActionResult>DetailHobby(Guid? Id)
        {
            if (Id==null)
            {
                return NotFound();
            }
            var model = await _context.Hobbies.SingleOrDefaultAsync(x => x.HobbiesId == Id);

            if (model == null)
            {
                return NotFound();
            }
            return PartialView(model);

        }

        [HttpGet]
        public async Task<IActionResult> DetailIndividual(Guid? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            var model = await _context.Individuals.SingleOrDefaultAsync(x => x.IndividualId == Id);

            if (model == null)
            {
                return NotFound();
            }
            return PartialView(model);

        }

        [HttpGet]
        public async Task<IActionResult> DetailOrganization(Guid? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            var model = await _context.Organizations.SingleOrDefaultAsync(x => x.OrganizationId == Id);

            if (model == null)
            {
                return NotFound();
            }
            return PartialView(model);

        }

    }
}
