using CourseProjectApp.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.Repository
{
   public interface IProfileRepository
    {
        List<Hobbies> GetHobbiesList(string Id);
        List<Individual> GetIndividualsList(string Id);
        List<Organization> GetOrganizationsList(string Id);
    }
}
