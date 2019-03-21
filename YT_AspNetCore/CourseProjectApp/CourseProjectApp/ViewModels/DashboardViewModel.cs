﻿using CourseProjectApp.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.ViewModels
{
    public class DashboardViewModel
    {
        public List<Individual> Individuals { get; set; }
        public List<Organization> Organization { get; set; }
        public List<Hobbies> Hobby { get; set; }


    }
}
