﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.Services
{
    public class MessageSenderOptions
    {
        public string SendGridApiKey { get; set; }

        public string Sid { get; set; }
        public string AuthoToken { get; set; }

    }
}
