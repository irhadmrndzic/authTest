using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.Services
{
   public interface IMyInjectedInterface
    {
        Guid MyGuid { get; set; }
    }
    public class MyInjectedService : IMyInjectedInterface
    {
        public Guid MyGuid { get; set; }
        public MyInjectedService()
        {
            MyGuid = Guid.NewGuid();
        }
    }
}
