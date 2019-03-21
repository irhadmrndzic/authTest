using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.Services
{
    public interface IEmailSend
    {
        Task SendEmailAsync(string Email, string Subject, string Message);
    }
}
