using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCApp.Models;

namespace MVCApp.Services
{
    public class DataEntry
    {

        public void PostEntry(TicketData td)
        {
            var x = td;
            using (var context = new TicketingSystemContext())
            {
                IEnumerable<JobType> jobs = context.JobType;
                JobType job = null;

                foreach (JobType j in jobs)
                {
                    if (td.JobType.JobType1 == j.JobType1)
                    {
                        job = j;
                        break;
                    }
                }
                var e = new Employee()
                {
                    EmployeeName = td.Employee.EmployeeName
                };

                context.Employee.Add(e);
                context.TicketData.Add(td);
                context.SaveChanges();

                int entryID = td.EntryId;

                TicketDataLogger tdl = new TicketDataLogger();
                tdl.LogChange("new entry", "created new entry", entryID);

            }
        }
    }
}
