using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProjectApp.DATA;
using CourseProjectApp.EntityModel;

namespace CourseProjectApp.Repository
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly ProfileContext _context;
        public ProfileRepository(ProfileContext ctx)
        {
            _context = ctx;
        }
        public List<Hobbies> GetHobbiesList(string Id)
        {
            return _context.Hobbies.Where(x => x.AspNetUserId == Id).ToList();
        }

        public List<Individual> GetIndividualsList(string Id)
        {
            return _context.Individuals.Where(x => x.AspNetUserId == Id).ToList();
        }

        public List<Organization> GetOrganizationsList(string Id)
        {
            return _context.Organizations.Where(x => x.AspNetUserId == Id).ToList();
        }
    }
}
