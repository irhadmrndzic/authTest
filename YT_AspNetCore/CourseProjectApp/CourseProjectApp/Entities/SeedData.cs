using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.Entities
{
    public static class SeedData
    {
        public static void Seed(ApplicationDbContext context)
        {
            using (context)
            {

                context.AddRange(new Person
                {

                    FirstName = "Irhad",
                    LastName = "Mrndzic"
                },
                new Person
                {

                    FirstName = "John",
                    LastName = "Doe"
                });

                context.AddRange(new Address
                {

                    StreetName = "Marsala Tita",
                    City = "Mostar",
                    State = "Bosna i Hercegovina",
                    ZipCode = "88000",
                    PersonId = 1

                },
                new Address
                {

                    StreetName = "Brace Fejića",
                    City = "Mostar",
                    State = "Bosna i Hercegovina",
                    ZipCode = "88000",
                    PersonId = 2
                });
                context.SaveChanges();
                context.Dispose();
            }
        }
    }
}
