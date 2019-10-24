using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCApp.Services.DBModels;

namespace MVCApp.Services
{
    public class DataEntry
    {

        public void PostEntry(Models.DummyData d)
        {
            using (var context = new TicketingSystemContext())
            {
                var e = new Employee()
                {
                    EmployeeName = "Bob"
                };
                context.Employee.Add(e);
                context.SaveChanges();
            }

        }
    }
}
