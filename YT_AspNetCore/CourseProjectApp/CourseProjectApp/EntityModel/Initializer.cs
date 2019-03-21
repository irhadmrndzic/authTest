using CourseProjectApp.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.EntityModel
{
    public class Initializer
    {
        public static void Seed(ProfileContext context)
        {
            using (context)
            {
                context.Database.EnsureCreated(); //da li baza postoji
                if (context.Individuals.Any())
                {
                    return;
                }
                var individual = new Individual
                {
                    FullName = "Irhad Mrndzic",
                    DateOfBirth = DateTime.Now,
                    Address = "Dracevice bb",
                    City = "Mostar",
                    AspNetUserId = "1fae27f5-0c93-4a03-a864-c321cae1cb11"
                };

                context.Individuals.Add(individual);
                context.SaveChanges();
               
                var organization = new Organization
                {
                    BussinessName = "Microsoft",
                    HireDate = DateTime.Now,
                    Address = "Some street",
                    City = "Redmond",
                    Profession = "IT",
                    AspNetUserId = "1fae27f5-0c93-4a03-a864-c321cae1cb11"
                };

                context.Organizations.Add(organization);
                context.SaveChanges();
            
                var hobby = new Hobbies
                {
                    Name = "Database Admin",
                    Rating = 5,
                    AspNetUserId = "1fae27f5-0c93-4a03-a864-c321cae1cb11"
                };
                context.Hobbies.Add(hobby);
                context.SaveChanges();

                context.Dispose();
            }
        }
    }
}

